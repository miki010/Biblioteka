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

namespace DBBiblioteka
{
    public partial class FormInput : MetroFramework.Forms.MetroForm
    {
        PropertyInterface myInterface;
        StateEnum state;
        int? idKnjige;


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
            this.idKnjige = id;
            PopulateControls();
        }

        private void PopulateControls()
        {
            foreach (PropertyInfo item in myInterface.GetType().GetProperties())
            {
                if (item.GetCustomAttribute<ForeignKeyAttribute>() != null)
                {
                    PropertyInterface foreignKeyInterface = Assembly.GetExecutingAssembly().
                        CreateInstance(item.GetCustomAttribute<ForeignKeyAttribute>().className) as PropertyInterface;
                    LookUpControl ul = new LookUpControl(foreignKeyInterface);
                    ul.Name = item.Name;

                    //provjerava da li ima, id koji se prosljedjuje kroz konstruktor, kod unosa autora i izdavaca knjige
                    if (idKnjige != null && ul.Name == "KnjigaID")
                    {
                        ul.SetKey(idKnjige.ToString());
                        ul.Enabled = false;
                    }

                    //kao id zaposlenog postavlja se vrijednost staticke varijable koja tu vrijednost dobija prilikom logovanja
                    if (ul.Name == "ZaposleniID")
                    {
                        ul.SetKey(FormLogin.idZaposlenog);
                        ul.Enabled = false;
                    }

                    ul.SetLabel(item.GetCustomAttribute<DisplayNameAttribute>().DisplayName);
                    if (state == StateEnum.Update)
                    {
                        ul.SetKey(item.GetValue(myInterface).ToString());
                    }
                    flPanelControls.Controls.Add(ul);
                }

                else if (item.GetCustomAttribute<DateTimeAttribute>() != null)
                {
                    DateTimeControl dtc = new DateTimeControl();
                    dtc.Name = item.Name;
                    dtc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);

                    if (state == StateEnum.Create)
                    {
                        dtc.SetValue(DateTime.Now);
                    }
                    else
                    {
                        dtc.SetValue((DateTime)item.GetValue(myInterface));
                    }
                    flPanelControls.Controls.Add(dtc);
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
                        ic.SetValue(item.GetValue(myInterface).ToString());
                    }
                    if (item.GetCustomAttribute<ForeignKeyAttribute>() != null && state == StateEnum.Update)
                    {
                        ic.Enabled = false;
                    }
                    flPanelControls.Controls.Add(ic);
                }
            }
        }
        bool popunjeno = true;
        private void tilePotvrdi_Click(object sender, EventArgs e)
        {

            var properties = myInterface.GetType().GetProperties();

            
            foreach (var item in flPanelControls.Controls)
            {

                if (item.GetType() == typeof(LookUpControl))
                {
                    LookUpControl input = item as LookUpControl;
                    string value = input.Key;
                    try
                    {
                        PropertyInfo property = properties.Where(x => input.Name == x.Name).FirstOrDefault();                        
                        property.SetValue(myInterface, Convert.ChangeType(value, property.PropertyType));
                        if (property.GetCustomAttribute<RequiredAttribute>() != null && value == null)
                        {
                            input.SetLabelObavezno(property.GetCustomAttribute<RequiredAttribute>().ErrorMessage);
                            popunjeno = false;
                            return;
                        }
                        else
                            popunjeno = true;
                    }
                    catch (Exception)
                    {

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
                        property.SetValue(myInterface, Convert.ChangeType(value, property.PropertyType));

                        if (property.GetCustomAttribute<RequiredAttribute>() != null && value.Trim().Equals(""))
                        {

                            input.SetLblObavezno(property.GetCustomAttribute<RequiredAttribute>().ErrorMessage);
                            popunjeno = false;

                            return;
                        }
                        else
                            popunjeno = true;
                    }
                    catch (Exception ex)
                    {
                        return;
                    }

                }
                else if (item.GetType() == typeof(DateTimeControl))
                {
                    DateTimeControl input = item as DateTimeControl;
                    DateTime value = input.GetValue();
                    PropertyInfo property = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                    property.SetValue(myInterface, Convert.ChangeType(value, property.PropertyType));
                }
                else if (item.GetType() == typeof(UserControlRadio))
                {
                    UserControlRadio input = item as UserControlRadio;
                    string value = input.GetValue();
                    PropertyInfo property = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                    property.SetValue(myInterface, Convert.ChangeType(value, property.PropertyType));
                }
            }



            if (popunjeno)
            {
                if (state == StateEnum.Create)
                {
                    SqlHelper.ExecuteNonQuery(SqlHelper.GetConnectionString(), CommandType.Text,
                        myInterface.GetInsertQuery(), myInterface.GetInsertParameters().ToArray());
                    MessageBox.Show("Podatak je sacuvan!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (state == StateEnum.Update)
                {
                    SqlHelper.ExecuteNonQuery(SqlHelper.GetConnectionString(), CommandType.Text,
                        myInterface.GetUpdateQuery(), myInterface.GetUpdateParameters().ToArray());
                    MessageBox.Show("Podatak je izmjenjen!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DialogResult = DialogResult.OK;

            }
            else
                return;


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
