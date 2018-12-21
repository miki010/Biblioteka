using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBBiblioteka.Helper;
using DBBiblioteka.PropertiesClass;
using DBBiblioteka.AtributesClass;
using System.Reflection;

namespace DBBiblioteka
{
    public partial class FormStandard : MetroFramework.Forms.MetroForm
    {
        PropertyInterface myProperty;
        public string Key;
        public string Value;

        public FormStandard()
        {
            InitializeComponent();
        }
        
        public FormStandard(PropertyInterface propertyInterface)
        {
            InitializeComponent();          
            this.myProperty = propertyInterface;
            loadTable();
            dgvPrikaz.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrikaz.MultiSelect = false;
        }

        private void FormStandard_Load(object sender, EventArgs e)
        {
            //this.Focus();
        }

        private void loadTable()
        {
            MessageBox.Show("usao");
            DataTable dt = new DataTable();
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
                myProperty.GetSelectQuery());
            dt.Load(reader);
            reader.Close();
            dgvPrikaz.DataSource = dt;

            var type = myProperty.GetType();
            var properties = type.GetProperties();

            foreach (DataGridViewColumn item in dgvPrikaz.Columns)
            {
                item.HeaderText = properties.Where(x => x.GetCustomAttributes<SqlNameAttribute>().FirstOrDefault().Name
                == item.HeaderText).FirstOrDefault().GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName;
            }

        }

        private void tileDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                FormInput formInput = new FormInput(myProperty, StateEnum.Create);//dodati enum
                formInput.ShowDialog();
                if (formInput.DialogResult == DialogResult.OK)
                {
                    refreshTable();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ovdje je ex");
                MessageBox.Show(ex.ToString(), "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void tileIzmijeni_Click(object sender, EventArgs e)
        {
            populatePropertyInterface();
            try
            {
                FormInput formInput = new FormInput(myProperty, StateEnum.Update);//enum
                formInput.ShowDialog();
                if (formInput.DialogResult == DialogResult.OK)
                {
                    refreshTable();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tileObrisi_Click(object sender, EventArgs e)
        {
            populatePropertyInterface();
            try
            {
                SqlHelper.ExecuteNonQuery(SqlHelper.GetConnectionString(), CommandType.Text, myProperty.GetDeleteQuery(), myProperty.GetDeleteParameters().ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //klikom na DataGridView selektuje se zeljeni red i ti se podaci prosljedjuju u input formu
        private void populatePropertyInterface()
        {
            DataGridViewRow row = dgvPrikaz.SelectedRows[0];
            var properties = myProperty.GetType().GetProperties();

            foreach (PropertyInfo item in properties)
            {
                string value = row.Cells[item.GetCustomAttribute<SqlNameAttribute>().Name].Value.ToString();
                item.SetValue(myProperty, Convert.ChangeType(value, item.PropertyType));
            }
        }

        private void refreshTable()
        {
            DataTable dt = new DataTable();
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
                myProperty.GetSelectQuery());
            dt.Load(reader);
            reader.Close();
            dgvPrikaz.DataSource = dt;

        }

    }
}
