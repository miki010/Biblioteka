using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBBiblioteka.AtributesClass;
using DBBiblioteka.PropertiesClass;
using DBBiblioteka.Helper;
using DBBiblioteka.AttributesClass;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace DBBiblioteka
{
    public partial class FormInput : MetroFramework.Forms.MetroForm
    {
        PropertyInterface myProperty;
        StateEnum state;
        int? idKnjige;

        FilterString filterString;

        public FormInput()
        {
            InitializeComponent();
        }

        public FormInput(PropertyInterface myInterface, StateEnum state)
        {
            InitializeComponent();
            this.myProperty = myInterface;
            this.state = state;

            PopulateControls();
        }
        public FormInput(PropertyInterface myInterface, StateEnum state, int id)
        {
            InitializeComponent();
            this.myProperty = myInterface;
            this.state = state;
            this.idKnjige = id;
            PopulateControls();
        }

        public FormInput(PropertyInterface myInterface, StateEnum state, FilterString filterString)  //konstruktor za Search inputform
        {
            InitializeComponent();
            this.myProperty = myInterface;
            this.state = state;
            this.filterString = filterString;

            PopulateControls();
        }

        private void PopulateControls()
        {
            foreach (PropertyInfo item in myProperty.GetType().GetProperties())
            {
                if (item.GetCustomAttribute<ForeignKeyAttribute>() != null)
                {
                    PropertyInterface foreignKeyInterface = Assembly.GetExecutingAssembly().
                        CreateInstance(item.GetCustomAttribute<ForeignKeyAttribute>().className) as PropertyInterface;
                    LookUpControl ul = new LookUpControl(foreignKeyInterface);
                    ul.Name = item.Name;

                    //provjerava da li ima, id koji se prosljedjuje kroz konstruktor, kod unosa autora i izdavaca knjige
                    if (idKnjige != null && ul.Name == "KnjigaID" && state != StateEnum.Search)
                    {
                        ul.SetKey(idKnjige.ToString());
                        ul.Enabled = false;
                    }

                    //kao id zaposlenog postavlja se vrijednost staticke varijable koja tu vrijednost dobija prilikom logovanja
                    if (ul.Name == "ZaposleniID" && state != StateEnum.Search)
                    {
                        ul.SetKey(FormLogin.idZaposlenog);
                        ul.Enabled = false;
                    }

                    ul.SetLabel(item.GetCustomAttribute<DisplayNameAttribute>().DisplayName);
                    if (state == StateEnum.Update)
                    {
                        ul.SetKey(item.GetValue(myProperty).ToString());
                    }
                    flPanelControls.Controls.Add(ul);
                }

                else if (item.GetCustomAttribute<DateTimeAttribute>() != null)
                {
                    if (state == StateEnum.Create || state == StateEnum.Update)
                    {
                        DateTimeControl dtc = new DateTimeControl();
                        dtc.Name = item.Name;
                        dtc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);

                        if (dtc.Name == "DatumRazduzivanja" || dtc.Name == "DatumIznajmljivanja")
                            dtc.Enabled = false;

                        if (state == StateEnum.Create)
                            dtc.SetValue(DateTime.Now);
                        else if (state == StateEnum.Update)
                            dtc.SetValue((DateTime)item.GetValue(myProperty));

                        flPanelControls.Controls.Add(dtc);

                        if (state == StateEnum.Create && dtc.Name == "DatumRazduzivanja")
                            dtc.SetValue(DateTime.Now.AddDays(15));
                        else if (state == StateEnum.Update && dtc.Name == "DatumRazduzivanja")
                            dtc.SetValue(DateTime.Now);
                    }
                    else if (state == StateEnum.Search)
                    {
                        DateRangeControl dateRange = new DateRangeControl();
                        dateRange.Name = item.Name;
                        dateRange.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                        //dateRange.SetValue(DateTimePicker.MinimumDateTime, DateTimePicker.MinimumDateTime);
                        flPanelControls.Controls.Add(dateRange);
                    }

                }
                else if (item.GetCustomAttribute<RadioValue>() != null)
                {
                    UserControlRadio ucr = new UserControlRadio();
                    ucr.Name = item.Name;
                    ucr.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);

                    if (state == StateEnum.Update)
                    {
                        ucr.SetValue(item.GetValue(myProperty).ToString());
                    }

                    flPanelControls.Controls.Add(ucr);
                }
                else
                {
                    InputControl ic = new InputControl();
                    ic.Name = item.Name;
                    ic.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);

                    if (state == StateEnum.Create && item.GetCustomAttribute<PrimaryKeyAttribute>() != null)
                    {
                        ic.SetValue("0");
                        ic.Visible = false;
                    }
                    else if (state == StateEnum.Update && item.GetCustomAttribute<PrimaryKeyAttribute>() != null)
                    {
                        ic.Visible = true;
                        ic.Enabled = false;
                    }
                    if (state == StateEnum.Update)
                    {
                        ic.SetValue(item.GetValue(myProperty).ToString());
                    }
                    if (item.GetCustomAttribute<ForeignKeyAttribute>() != null && state == StateEnum.Update)
                    {
                        ic.Enabled = false;
                    }

                    if (myProperty is PropertyKnjiga && ic.Name == "Kolicina" && state != StateEnum.Search)
                        ic.Enabled = false;
                    flPanelControls.Controls.Add(ic);
                }
            }
        }

        private void tilePotvrdi_Click(object sender, EventArgs e)
        {
            DateTime[] datumi = new DateTime[2]; //cuva datum Iznajmljivanja i datum Razduzivanja(u slucaju razduzivanja)
            int j = 0; //brojac datuma^
            var properties = myProperty.GetType().GetProperties();
            int idClana = 0; //cuva vrijednost iz lookup kontrole pri provjere da li clan postoji u tabeli clanarina
            if (state != StateEnum.Search)
                foreach (var item in flPanelControls.Controls)
                {
                    if (item.GetType() == typeof(LookUpControl))
                    {
                        LookUpControl input = item as LookUpControl;
                        string value = input.Key;
                        PropertyInfo property = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                        property.SetValue(myProperty, Convert.ChangeType(value, property.PropertyType));

                        if (input.Name == "ClanID")
                            idClana = Convert.ToInt32(input.Key);
                    }
                    else if (item.GetType() == typeof(InputControl))
                    {
                        InputControl input = item as InputControl;
                        string value = input.GetValue();
                        PropertyInfo property = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                        property.SetValue(myProperty, Convert.ChangeType(value, property.PropertyType));
                    }
                    else if (item.GetType() == typeof(DateTimeControl))
                    {
                        DateTimeControl input = item as DateTimeControl;
                        DateTime value = input.GetValue();
                        PropertyInfo property = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                        property.SetValue(myProperty, Convert.ChangeType(value, property.PropertyType));

                        if (myProperty is PropertyIznajmljivanje && state == StateEnum.Update)
                            datumi[j++] = input.GetValue(); //cuva datum Iznajmljivanja i Danasnji datum(datum Razduzivanja knjige)
                    }

                }
            else
            {

                for (int i = 0; i < flPanelControls.Controls.Count; i++)
                {
                    var item = flPanelControls.Controls[i];

                    if (item.GetType() == typeof(LookUpControl))
                    {
                        LookUpControl input = item as LookUpControl;
                        if (string.IsNullOrEmpty(input.Key))
                            continue;

                        string value = input.Key.Trim();
                        filterString.FStr += input.Name + " = " + value + " and ";
                    }
                    else if (item.GetType() == typeof(InputControl))
                    {
                        InputControl input = item as InputControl;
                        string value = input.GetValue().Trim();
                        if (input.Name.Contains("ID") || input.Name.Contains("Iznos") || input.Name.Contains("Kolicina"))
                        {
                            if (string.IsNullOrEmpty(input.GetValue()))
                                continue;
                            else if (!int.TryParse(input.GetValue(), out int number1) && !double.TryParse(input.GetValue(), out double numer2))
                            {
                                MessageBox.Show("Polje " + input.Name + " može sadržati samo brojevne podatke!", "Greška");
                                input.SetValue("");
                                return;
                            }
                        }

                        if (!string.IsNullOrEmpty(input.GetValue()) && (input.Name.Contains("ID") || input.Name.Contains("Iznos") || input.Name.Contains("Kolicina")))
                            filterString.FStr += input.Name + " = " + value + " and ";
                        else if (!string.IsNullOrEmpty(input.GetValue()))
                            filterString.FStr += input.Name + " LIKE '%" + value + "%' and ";
                    }
                    else if (item.GetType() == typeof(DateRangeControl))
                    {
                        DateRangeControl input = item as DateRangeControl;
                        DateTime[] dates = input.GetValue();
                        if (!input.GetChecked())
                            continue;
                        else if (dates[0].Date > dates[1].Date)
                        {
                            MessageBox.Show("Izaberite validan raspon datuma!", "Greška");
                            return;
                        }
                        filterString.FStr += input.Name + " >= '" + dates[0].Date.ToString() + "' and " + input.Name + " <= '" + dates[1].Date.ToString() + "' and ";
                    }
                    else if (item.GetType() == typeof(UserControlRadio))
                    {
                        UserControlRadio input = item as UserControlRadio;
                        string value = input.GetValue();
                        filterString.FStr += input.Name + " LIKE '" + value + "' and ";
                    }
                }
                if (filterString.FStr.Length == 0)
                    return;
                filterString.FStr = filterString.FStr.Substring(0, filterString.FStr.Length - 5);
                MessageBox.Show(filterString.FStr);
            }

            if (myProperty is PropertyIznajmljivanje)
            {

                if (state == StateEnum.Create) // provjerava da li je clanu istekla clanarina pri pokusaju iznajmljivanja knjige
                {
                    PropertyClanarina clanarina = new PropertyClanarina();
                    DataTable tableClanarina = new DataTable();
                    SqlDataReader reader2 = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
                    clanarina.GetSelectQuery());
                    tableClanarina.Load(reader2);
                    reader2.Close();

                    bool ima = false;
                    for (int i = 0; i < tableClanarina.Rows.Count; i++)
                    {
                        if ((int)(tableClanarina.Rows[i][1]) == idClana)
                        {
                            ima = true;
                        }
                    }
                    if (!ima)
                    {
                        MessageBox.Show("Korisnik nije uplatio članarinu, iznajmljivanje nije moguće!", "Greška!");
                        return;
                    }


                    DataTable dt = new DataTable();
                    SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
                    myProperty.GetProcedureStatusClanarineZaClanID(), myProperty.GetProcedureParameters().ToArray());
                    dt.Load(reader);
                    reader.Close();

                    DateTime datumIsteka = (DateTime)dt.Rows[0][1];
                    if (datumIsteka < DateTime.Now)
                    {
                        MessageBox.Show("Korisniku je istekla članarina, iznajmljivanje nije moguće!", "Greška!");
                        return;
                    }
                }
                else if (state == StateEnum.Update)
                {
                    if(((TimeSpan)(datumi[1].AddDays(15) - datumi[0])).Days <= 15 && datumi[0] <= datumi[1])
                    {
                        MessageBox.Show("Knjiga uredno vraćena");
                       
                    }
                    else
                    {
                        MessageBox.Show(DatePart.TimeSpanToDateParts(datumi[0].AddDays(15), datumi[1])); //
                        return;
                    }
                    
                }
            }

            if (state == StateEnum.Create)
            {
                SqlHelper.ExecuteNonQuery(SqlHelper.GetConnectionString(), CommandType.Text,
                    myProperty.GetInsertQuery(), myProperty.GetInsertParameters().ToArray());
                MessageBox.Show("Podatak je sacuvan!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (state == StateEnum.Update)
            {
                SqlHelper.ExecuteNonQuery(SqlHelper.GetConnectionString(), CommandType.Text,
                    myProperty.GetUpdateQuery(), myProperty.GetUpdateParameters().ToArray());
                MessageBox.Show("Podatak je izmjenjen!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            DialogResult = DialogResult.OK;

        }

        private void tileOdustani_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da zelite da izadjete?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
