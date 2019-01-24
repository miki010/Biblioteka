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
using MetroFramework.Controls;

namespace DBBiblioteka
{
    public partial class FormInput : MetroFramework.Forms.MetroForm
    {
        PropertyInterface myInterface;
        PropertyIzdavacKnjiga izdavacKnjigaProperty = new PropertyIzdavacKnjiga();
        PropertyIznajmljivanje iznajmljivanje = new PropertyIznajmljivanje();
        PropertyIzdavacKnjiga izdavacKnjiga = new PropertyIzdavacKnjiga();
        PropertyLogin propertyLogin = new PropertyLogin();
        StateEnum state;
        int? id;
        int idZaposlenog;


        FilterString filterString;

        #region Konstruktori
        public FormInput()
        {
            InitializeComponent();
        }

        public FormInput(PropertyInterface myInterface, StateEnum state)
        {
            InitializeComponent();
            this.myInterface = myInterface;
            this.state = state;
            PopulateControls();
        }
        public FormInput(PropertyInterface myInterface, StateEnum state, int id)
        {
            InitializeComponent();
            this.myInterface = myInterface;
            this.state = state;
            this.id = id;
            PopulateControls();
        }

        public FormInput(PropertyInterface myInterface, StateEnum state, FilterString filterString)  //konstruktor za Search inputform
        {
            InitializeComponent();
            this.myInterface = myInterface;
            this.state = state;
            this.filterString = filterString;

            PopulateControls();
        }
        #endregion

        #region PopulateControls
        private void PopulateControls()
        {
            Opacity = 0.9;

            if (myInterface is PropertyIznajmljivanje && state == StateEnum.Update)
                tilePotvrdi.Enabled = false;

            foreach (PropertyInfo item in myInterface.GetType().GetProperties())
            {
                if (item.GetCustomAttribute<ForeignKeyAttribute>() != null)
                {
                    PropertyInterface foreignKeyInterface = Assembly.GetExecutingAssembly().
                        CreateInstance(item.GetCustomAttribute<ForeignKeyAttribute>().className) as PropertyInterface;
                    LookUpControl ul = new LookUpControl(foreignKeyInterface);
                    ul.Name = item.Name;
                    if (state == StateEnum.Update)
                    {
                        ul.Enabled = true;
                    }

                    if (item.GetCustomAttribute<RequiredAttribute>() != null)
                    {
                        ul.SetLabelObavezno("*");
                    }

                    //provjerava da li ima, id koji se prosljedjuje kroz konstruktor, kod unosa autora i izdavaca knjige
                    if (id != null && ul.Name == "KnjigaID" && state != StateEnum.Search)
                    {
                        ul.SetKey(id.ToString());
                        ul.Enabled = false;
                    }
                    //za login
                    if (myInterface.GetType() == typeof(PropertyLogin))
                    {
                        ul.SetKey(FormStandard.radnoMjestoId);
                        ul.Enabled = false;
                    }

                    //kao id zaposlenog postavlja se vrijednost staticke varijable koja tu vrijednost dobija prilikom logovanja
                    if (ul.Name == "ZaposleniID" && state != StateEnum.Search)
                    {
                        ul.SetKey(FormLogin.idZaposlenog);
                        ul.Enabled = false;
                    }

                    if(myInterface.GetType() == typeof(PropertyIznajmljivanje) && state == StateEnum.Update)
                    {
                        ul.Enabled = false;
                    }

                    ul.SetLabel(item.GetCustomAttribute<DisplayNameAttribute>().DisplayName);
                    if (state == StateEnum.Update)
                    {
                        ul.SetKey(item.GetValue(myInterface).ToString());
                    }

                    if (myInterface is PropertyClanarina && ul.Name == "TipID" && state == StateEnum.Create)
                    {
                        ul.AddTextChangedEvent();////////////////////////// dodaje jos jedan event za automatsko mijenjanje datuma za tip clanarine
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
                            dtc.SetValue((DateTime)item.GetValue(myInterface));

                        flPanelControls.Controls.Add(dtc);

                        if (state == StateEnum.Create && dtc.Name == "DatumRazduzivanja")
                            dtc.SetValue(DateTime.Now.AddDays(15));
                        else if (state == StateEnum.Update && dtc.Name == "DatumRazduzivanja")
                            dtc.SetValue(DateTime.Now);

                        if (myInterface is PropertyClanarina)
                        {
                            dtc.Enabled = false;
                            if (dtc.Name == "DatumIstekaClanarine" && state == StateEnum.Create)
                            {
                                
                            }

                            if (state == StateEnum.Update)
                                tilePotvrdi.Enabled = false;
                        }
                            
                    }
                    else if (state == StateEnum.Search)
                    {
                        DateRangeControl dateRange = new DateRangeControl();
                        dateRange.Name = item.Name;
                        dateRange.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
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
                        ucr.SetValue(item.GetValue(myInterface).ToString());
                    }

                    if (item.GetCustomAttribute<RequiredAttribute>() != null)
                    {
                        ucr.SetLblObavezno("*");
                    }

                    flPanelControls.Controls.Add(ucr);
                }
                else if (item.GetCustomAttribute<CheckValue>() != null)
                {
                    MetroCheckBox cb = new MetroCheckBox();
                    cb.Name = "cbRazduzi";
                    cb.Text = item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName;
                    flPanelControls.Controls.Add(cb);
                    if (!((PropertyIznajmljivanje)myInterface).Razduzeno && state == StateEnum.Update)
                        cb.Enabled = true;
                    else
                        cb.Enabled = false;
                    cb.Checked = ((PropertyIznajmljivanje)myInterface).Razduzeno;
                    if (((PropertyIznajmljivanje)myInterface).Razduzeno)
                        tilePotvrdi.Enabled = false;
                    cb.Margin = new Padding(12, 0, 0, 0);

                    cb.CheckedChanged += Cb_CheckedChanged;
                    
                }
                else
                {
                    InputControl ic = new InputControl();
                    ic.Name = item.Name;
                    ic.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    
                    if (item.GetCustomAttribute<RequiredAttribute>() != null)
                    {
                        ic.SetLblObavezno("*");
                    }

                    if (state == StateEnum.Create && item.GetCustomAttribute<PrimaryKeyAttribute>() != null)
                    {
                        ic.SetValue("0");
                        ic.Visible = false;
                    }
                    else if (state == StateEnum.Update && item.GetCustomAttribute<PrimaryKeyAttribute>() != null)
                    {
                        ic.Visible = false;
                        ic.Enabled = false;
                    }
                    if (state == StateEnum.Update)
                    {
                        ic.SetValue(item.GetValue(myInterface).ToString());
                    }
                    if (item.GetCustomAttribute<ForeignKeyAttribute>() != null && state == StateEnum.Update)
                    {
                        ic.Enabled = false;
                    }

                    if (myInterface.GetType() == typeof(PropertyLogin))
                    {

                        if (ic.Name != "KorisnickoIme")
                        {
                            ic.Enabled = false; 
                        }

                        switch (ic.Name.ToString())
                        {
                            case "ZaposleniID":
                                ic.SetValue(FormStandard.zaposleniId);
                                break;
                            case "KorisnickoIme":
                                ic.SetValue(FormStandard.korisnickoIme);
                                break;

                            default:
                                break;
                        }
                    }

                    if (myInterface is PropertyKnjiga && ic.Name == "Kolicina" && state != StateEnum.Search)
                        ic.Enabled = false;
                    flPanelControls.Controls.Add(ic);
                }
            }

        }

        private void Cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            ((PropertyIznajmljivanje)myInterface).Razduzeno = cb.Checked;

            if (state == StateEnum.Update && cb.Checked == false)
                tilePotvrdi.Enabled = false;
            else
                tilePotvrdi.Enabled = true;
        }
        #endregion

        bool popunjeno = true;
        string stanje;

        private void tilePotvrdi_Click(object sender, EventArgs e)
        {
            ///
            bool postojiIme = false;
            if (myInterface.GetType() == typeof(PropertyLogin))
            {
                DataTable dt = new DataTable();
                SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
                   myInterface.GetSelectQuery());
                dt.Load(reader);
                reader.Close();
                bool postoji = false;
                foreach (DataRow row in dt.Rows)
                {
                    string ime = row["KorisnickoIme"].ToString();
                    foreach (var item in flPanelControls.Controls)
                    {
                        if (item.GetType() == typeof(InputControl))
                        {
                            InputControl input = item as InputControl;
                            string value = input.GetValue();
                            if (input.Name == "KorisnickoIme" && ime == value)
                            {
                                postoji = true;
                                break;
                            }
                        }
                    }
                }

                postojiIme = postoji;

                if (postoji)
                {
                    MessageBox.Show("Korisnicko ime vec postoji u bazi. Molimo Vas da ga promjenite!", "Obajvestenje");
                    return;
                }
                //else if (!postoji)
                //{
                //    return postojiIme;
                //}
            }


            /////


            DateTime[] datumi = new DateTime[2]; //cuva datum Iznajmljivanja i datum Razduzivanja(u slucaju razduzivanja)
            int j = 0; //brojac datuma^
            var properties = myInterface.GetType().GetProperties();
            int idClana = 0; //cuva vrijednost iz lookup kontrole pri provjere da li clan postoji u tabeli clanarina
            if (state != StateEnum.Search)
            {
                foreach (var item in flPanelControls.Controls)
                {
                    if (item.GetType() == typeof(LookUpControl))
                    {
                        LookUpControl input = item as LookUpControl;
                        string value = input.Key;

                        if (input.Name == "ClanID")
                            idClana = Convert.ToInt32(input.Key);

                        try
                        {
                            PropertyInfo property = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                            //provjera unosa

                            if (property.GetCustomAttribute<RequiredAttribute>() != null && value == null)
                            {
                                input.txtID.Focus();

                                input.SetLabelObavezno(property.GetCustomAttribute<RequiredAttribute>().ErrorMessage);
                                popunjeno = false;
                                return;
                            }
                            else
                            {
                                popunjeno = true;
                                property.SetValue(myInterface, Convert.ChangeType(value, property.PropertyType));
                            }
                            #region Skidanje i Vracanje/Dodavanje na stanje
                            if (myInterface.GetType() == typeof(PropertyIznajmljivanje))
                            {
                                if (state == StateEnum.Create)
                                {
                                    stanje = "zaduzivanje";
                                    PropertyInfo propertyIznajmljivanje = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                                    if (input.Name == "KnjigaID")
                                    {
                                        propertyIznajmljivanje.SetValue(iznajmljivanje, Convert.ChangeType(value, property.PropertyType));
                                    }
                                }
                                else if (state == StateEnum.Update)
                                {
                                    stanje = "vracanje";
                                    PropertyInfo propertyIznajmljivanje = properties.Where(x => input.Name == x.Name).FirstOrDefault();

                                    if (input.Name == "KnjigaID")
                                    {
                                        propertyIznajmljivanje.SetValue(iznajmljivanje, Convert.ChangeType(value, property.PropertyType));
                                    }
                                }
                            }
                            else if (myInterface.GetType() == typeof(PropertyIzdavacKnjiga))
                            {
                                stanje = "kpp";//kolicina++;
                                PropertyInfo propertyIzdavac = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                                propertyIzdavac.SetValue(izdavacKnjiga, Convert.ChangeType(value, propertyIzdavac.PropertyType));

                            }
                            else if (myInterface.GetType() == typeof(PropertyZaposleni))
                            {
                                stanje = "pristupniPodaci";
                                PropertyInfo propertyLoginInfo = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                                propertyLoginInfo.SetValue(propertyLogin, Convert.ChangeType(value, propertyLoginInfo.PropertyType));//XXXXXXXXXXXXXXXXXXXXXXX
                            }

                            #endregion
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show(ex.ToString());///////////////////////////////////////////////
                            return;
                        }
                    }
                    else if (item.GetType() == typeof(InputControl))
                    {
                        InputControl input = item as InputControl;
                        string value = input.GetValue();
                        try
                        {
                            PropertyInfo property = properties.Where(x => input.Name == x.Name).FirstOrDefault();

                            if (input.Name.Contains("ID") || input.Name.Contains("Iznos") || input.Name.Contains("Kolicina"))
                            {
                                
                                if (!int.TryParse(input.GetValue(), out int number1))
                                {
                                    MessageBox.Show("Polje " + input.Name + " može biti samo cjelobrojni podatak!", "Greška");
                                    input.SetValue("");
                                    return;
                                }
                                else if(Convert.ToInt32(value) < 1)
                                {
                                        MessageBox.Show("Potrebno je dodati barem jednu knjigu!", "Greška");
                                        return;
                                }
                            }

                            if (input.Name == "Kolicina" && value == "")
                            {
                                value = "0";
                            }

                            //zadrzati provjera unosa da li je popunjeno obavezno polje
                            if (property.GetCustomAttribute<RequiredAttribute>() != null && value.Trim().Equals(""))
                            {
                                input.SetLblObavezno(property.GetCustomAttribute<RequiredAttribute>().ErrorMessage);
                                popunjeno = false;
                                return;
                            }
                            else
                            {
                                popunjeno = true;
                                property.SetValue(myInterface, Convert.ChangeType(value, property.PropertyType));
                            }

                            #region Skidanje i Vracanje/Dodavanje na stanje
                            //-**************************

                            if (myInterface.GetType() == typeof(PropertyIznajmljivanje))
                            {
                                if (state == StateEnum.Create)
                                {

                                    stanje = "zaduzivanje";
                                    PropertyInfo propertyIznajmljivanje = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                                    if (input.Name == "KnjigaID")
                                    {
                                        propertyIznajmljivanje.SetValue(iznajmljivanje, Convert.ChangeType(value, property.PropertyType));
                                    }
                                }
                                else if (state == StateEnum.Update)
                                {
                                    stanje = "vracanje";
                                    PropertyInfo propertyIzdavacKnjiga = properties.Where(x => input.Name == x.Name).FirstOrDefault();

                                    if (input.Name == "KnjigaID")
                                    {
                                        propertyIzdavacKnjiga.SetValue(izdavacKnjiga, Convert.ChangeType(value, property.PropertyType));

                                    }
                                }
                            }
                            else if (myInterface.GetType() == typeof(PropertyIzdavacKnjiga))
                            {
                                stanje = "kpp";//kolicina++;
                                PropertyInfo propertyIzdavac = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                                propertyIzdavac.SetValue(izdavacKnjiga, Convert.ChangeType(value, propertyIzdavac.PropertyType));

                            }
                            //************************************
                            #endregion

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            //input.SetLblObavezno(property.GetCustomAttribute<RequiredAttribute>().ErrorMessage);
                            //return;

                        }
                    }

                    else if (item.GetType() == typeof(DateTimeControl))
                    {
                        DateTimeControl input = item as DateTimeControl;
                        DateTime value = input.GetValue();
                        PropertyInfo property = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                        property.SetValue(myInterface, Convert.ChangeType(value, property.PropertyType));
                        if (myInterface is PropertyIznajmljivanje && state == StateEnum.Update)
                            datumi[j++] = input.GetValue(); //cuva datum Iznajmljivanja i Danasnji datum(datum Razduzivanja knjige)
                    }
                    else if (item.GetType() == typeof(UserControlRadio))
                    {
                        UserControlRadio input = item as UserControlRadio;
                        string value = input.GetValue();
                        PropertyInfo property = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                        if (property.GetCustomAttribute<RequiredAttribute>() != null && value == "N")
                        {
                            input.SetLblObavezno(property.GetCustomAttribute<RequiredAttribute>().ErrorMessage);
                            popunjeno = false;
                            return;
                        }
                        else
                        {
                            popunjeno = true;
                            property.SetValue(myInterface, Convert.ChangeType(value, property.PropertyType));
                        }
                    }

                }
            }
            #region Pretraga
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
                        if (input.GetValue() != "M" && input.GetValue() != "Ž")
                            continue;
                        string value = input.GetValue();
                        filterString.FStr += input.Name + " LIKE '" + value + "' and ";
                    }
                }
                if (string.IsNullOrEmpty(filterString.FStr) || filterString.FStr.Length == 0)
                    return;
                filterString.FStr = filterString.FStr.Substring(0, filterString.FStr.Length - 5);
                MessageBox.Show(filterString.FStr);
            }
            #endregion

            #region ProvjeraDaLiJePlacenaClanarina
            if (myInterface is PropertyIznajmljivanje)
            {
                if (state == StateEnum.Create) // provjerava da li je clanu istekla clanarina pri pokusaju iznajmljivanja knjige
                {

                    DataTable dataTable1 = new DataTable();
                    SqlDataReader dataReader1 = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
                    myInterface.GetProcedureKnjigaNaStanju(), myInterface.GetProcedureParameters().ToArray());
                    dataTable1.Load(dataReader1);
                    dataReader1.Close();

                    if (Convert.ToInt32(dataTable1.Rows[0][0]) < 1)
                    {
                        MessageBox.Show("Knjige trenutno nema na stanju!", "Greška");
                        return;
                    }

                    PropertyClanarina clanarina = new PropertyClanarina();

                    DataTable tableClanarina = new DataTable();
                    SqlDataReader readerNemaClanarine = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
                    clanarina.GetSelectQuery());
                    tableClanarina.Load(readerNemaClanarine);
                    readerNemaClanarine.Close();

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
                    SqlDataReader readerIstekClanarine = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
                    myInterface.GetProcedureStatusClanarineZaClanID(), myInterface.GetProcedureParametersClanID().ToArray());
                    dt.Load(readerIstekClanarine);
                    readerIstekClanarine.Close();

                    DateTime datumIsteka = (DateTime)dt.Rows[0][1];
                    if (datumIsteka < DateTime.Now)
                    {
                        MessageBox.Show("Korisniku je istekla clanarina, iznajmljivanje nije moguce!", "Greška!");
                        return;
                    }
                    dt.Clear();

                    DataTable dataTable = new DataTable();
                    SqlDataReader dataReader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
                    myInterface.GetProcedureMozeLiSeDici(), myInterface.GetProcedureParametersClanID().ToArray());
                    dataTable.Load(dataReader);
                    dataReader.Close();

                    if(dataTable.Rows.Count > 1)
                    {
                        MessageBox.Show("Korisnik ima više od jedne nerazdužene knjige! Iznajmljivanje nije moguće.", "Greška!");
                        return;
                    }
                    dataTable.Clear();

                }
                else if (state == StateEnum.Update)
                {
                    if (datumi[1] <= datumi[0].AddDays(15))
                    {
                        MessageBox.Show("Knjiga uredno vracena");
                    }
                    else
                    {
                        MessageBox.Show((datumi[1] - datumi[0].AddDays(15)).Days.ToString());
                        MessageBox.Show(DatePart.TimeSpanToDateParts(datumi[0].AddDays(15), datumi[1])); 

                    }

                }
            }
            #endregion

            #region Upis u bazu
            if (popunjeno)
            {
                if (state == StateEnum.Create)
                {
                    try
                    {
                        SqlHelper.ExecuteNonQuery(SqlHelper.GetConnectionString(), CommandType.Text,
                                        myInterface.GetInsertQuery(), myInterface.GetInsertParameters().ToArray());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("U bazi već postoji podatak sa istim identifikatorom!");
                        return;
                    }

                    if (stanje == "zaduzivanje")
                    {
                        try
                        {
                            SqlHelper.ExecuteNonQuery(SqlHelper.GetConnectionString(), CommandType.Text,
                                                    iznajmljivanje.GetProcedureUpdateKnjiga(), iznajmljivanje.GetProcedureParameters().ToArray());
                        }
                        catch (Exception)
                        {

                            return;
                        }
                        //MessageBox.Show("Knjiga je skinuta sa stanja!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (stanje == "kpp")
                    {
                        try
                        {
                            SqlHelper.ExecuteNonQuery(SqlHelper.GetConnectionString(), CommandType.Text,
                                            izdavacKnjiga.GetProcedureUpdateKnjiga(), izdavacKnjiga.GetProcedureParameters().ToArray());
                        }
                        catch (Exception)
                        {

                            return;
                        }
                        //MessageBox.Show("Uvecano stanje knjiga!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MessageBox.Show("Podatak je sačuvan!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    if (stanje == "pristupniPodaci")
                    {
                        //popuniPristupnePodatke();
                        SqlHelper.ExecuteNonQuery(SqlHelper.GetConnectionString(), CommandType.Text,
                         propertyLogin.GetInsertQuery(), propertyLogin.GetLoginParameters().ToArray());
                    }

                    MessageBox.Show("Podatak je sacuvan!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (state == StateEnum.Update)
                {
                    try
                    {
                        SqlHelper.ExecuteNonQuery(SqlHelper.GetConnectionString(), CommandType.Text,
                                        myInterface.GetUpdateQuery(), myInterface.GetUpdateParameters().ToArray());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("U bazi već postoji podatak sa istim identifikatorom!");
                        return;
                    }

                    if (stanje == "vracanje")
                    {
                        try
                        {
                            SqlHelper.ExecuteNonQuery(SqlHelper.GetConnectionString(), CommandType.Text,
                                            iznajmljivanje.GetProcedureSelectAllDetails(), iznajmljivanje.GetProcedureParameters().ToArray());
                        }
                        catch (Exception)
                        {

                            return;
                        }
                        //MessageBox.Show("Knjiga je vracena na stanje!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MessageBox.Show("Podatak je izmjenjen!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                DialogResult = DialogResult.OK;
                if (myInterface is PropertyIznajmljivanje)
                    ((PropertyIznajmljivanje)myInterface).Razduzeno = false;
            }
            else
            {
                return;
            }
            #endregion


        }

        private void tileOdustani_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da zelite da izadjete?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void popuniPristupnePodatke()
        {
            SqlHelper.ExecuteNonQuery(SqlHelper.GetConnectionString(), CommandType.Text,
                propertyLogin.GetInsertQuery(), propertyLogin.GetLoginParameters().ToArray());
            MessageBox.Show("dodat");
        }

        private void FormInput_Load(object sender, EventArgs e)
        {
            flPanelControls.BringToFront();
            tilePotvrdi.BringToFront();
            tileOdustani.BringToFront();
            metroPanel1.BringToFront();
        }

        private bool ProvjeraKorisnickoIme()
        {
            bool postojiIme = false;
            if (myInterface.GetType() == typeof(PropertyLogin))
            {
                DataTable dt = new DataTable();
                SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
                   myInterface.GetSelectQuery());
                dt.Load(reader);
                reader.Close();
                bool postoji = false;
                foreach (DataRow row in dt.Rows)
                {
                    string ime = row["KorisnickoIme"].ToString();
                    foreach (var item in flPanelControls.Controls)
                    {
                        if (item.GetType() == typeof(InputControl))
                        {
                            InputControl input = item as InputControl;
                            string value = input.GetValue();
                            if (input.Name == "KorisnickoIme" && ime == value)
                            {
                                postoji = true;
                                break;
                            }
                        }
                    }
                }

                postojiIme = postoji;

                if (postoji)
                {
                    MessageBox.Show("Korisnicko ime vec postoji u bazi. Molimo Vas da ga promjenite!", "Obajvestenje");
                    return postojiIme;
                }
                else if (!postoji)
                {
                    return postojiIme;
                }


            }

            return postojiIme;

        }
    }
}
