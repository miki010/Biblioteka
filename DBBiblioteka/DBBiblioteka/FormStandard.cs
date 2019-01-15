﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DBBiblioteka.Helper;
using DBBiblioteka.PropertiesClass;
using DBBiblioteka.AtributesClass;
using System.Reflection;
using MetroFramework.Forms;

namespace DBBiblioteka
{
    public partial class FormStandard : MetroForm
    {
        PropertyInterface myProperty;

        StateEnum state;
        public string Key;
        public string Value;
        public int red;

        public FormStandard()
        {
            InitializeComponent();

        }

        public FormStandard(PropertyInterface propertyInterface)
        {
            InitializeComponent();
            this.myProperty = propertyInterface;
        }

        public FormStandard(PropertyInterface propertyInterface, StateEnum stateEnum)
        {
            InitializeComponent();
            this.myProperty = propertyInterface;
            this.state = stateEnum;
        }

        public FormStandard(PropertyInterface propertyInterface, StateEnum stateEnum, int red)
        {
            InitializeComponent();
            this.myProperty = propertyInterface;
            this.state = stateEnum;
            this.red = red;
            loadTable();

        }

        private void FormStandard_Load(object sender, EventArgs e)
        {
            if (state == StateEnum.LookUp)
            {
                metroPanel1.Visible = false;
                metroPanel2.Visible = true;
            }

            loadTable();
            dgvPrikaz.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrikaz.MultiSelect = false;
            
        }

        private void loadTable()
        {
            DataTable dt = new DataTable();
            SqlDataReader reader = null;
            //if (state == StateEnum.View)
            //{

            //}
            //else
            //{
            reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
               myProperty.GetSelectQuery());
            //}
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
                FormInput formInput = new FormInput(myProperty, StateEnum.Create);
                formInput.ShowDialog();
                if (formInput.DialogResult == DialogResult.OK)
                {
                    refreshTable();
                    // loadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void tileIzmijeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrikaz.SelectedRows[0] != null)
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
                        //hvata exception za nevalidan unos u textID lookupcontrol polje
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selektujte u tabeli podatak koji zelite da izmjenite!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tileObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrikaz.SelectedRows[0] != null)
                {
                    if (MessageBox.Show("Da li ste sigurni da zelite da obrisete ovaj podatak?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        populatePropertyInterface();
                        try
                        {
                            SqlHelper.ExecuteNonQuery(SqlHelper.GetConnectionString(), CommandType.Text, myProperty.GetDeleteQuery(), myProperty.GetDeleteParameters().ToArray());
                            MessageBox.Show("Podatak je obrisan!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshTable();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Selektujte u tabeli podatak za brisanje!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        //klikom na DataGridView selektuje se zeljeni red i ti se podaci prosljedjuju u input formu
        private void populatePropertyInterface()
        {
            //try
            //{
            if (dgvPrikaz.SelectedRows[0] != null)
            {
                DataGridViewRow row = dgvPrikaz.SelectedRows[0];
                var properties = myProperty.GetType().GetProperties();

                foreach (PropertyInfo item in properties)
                {
                    string value = row.Cells[item.GetCustomAttribute<SqlNameAttribute>().Name].Value.ToString();
                    item.SetValue(myProperty, Convert.ChangeType(value, item.PropertyType));

                }
            }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Selektujte u tabeli podatak za brisanje!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}          
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

        public void btnVrati_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvPrikaz.SelectedRows[0];

            var properties = myProperty.GetType().GetProperties();
            string columnName = properties.Where(x => x.GetCustomAttribute<LookupKey>() != null).FirstOrDefault().GetCustomAttribute<SqlNameAttribute>().Name;

            Key = row.Cells[columnName].Value.ToString();
            var lookUpValues = properties.Where(p => p.GetCustomAttribute<LookupValue>() != null);

            foreach (var item in lookUpValues)
            {
                Value += row.Cells[item.GetCustomAttribute<SqlNameAttribute>().Name].Value.ToString() + " ";
            }
            DialogResult = DialogResult.OK;
            this.Close();

        }

        public void Vrati()
        {
            DataGridViewRow row = dgvPrikaz.Rows.Cast<DataGridViewRow>().Where(r => r.Cells[0].Value.ToString().Equals(red.ToString())).FirstOrDefault();

            if (row == default(DataGridViewRow))  //u slucaju da ID-a nema u tabeli
                return;

            var properties = myProperty.GetType().GetProperties();
            string columnName = properties.Where(x => x.GetCustomAttribute<LookupKey>() != null).FirstOrDefault().GetCustomAttribute<SqlNameAttribute>().Name;

            Key = row.Cells[columnName].Value.ToString();
            var lookUpValues = properties.Where(p => p.GetCustomAttribute<LookupValue>() != null);

            foreach (var item in lookUpValues)
            {
                Value += row.Cells[item.GetCustomAttribute<SqlNameAttribute>().Name].Value.ToString() + " ";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<string> columnNames = new List<string>();
            string searchString = "";

            DataTable table = dgvPrikaz.DataSource as DataTable;

            for (int i = 0; i < table.Columns.Count; i++)
            {
                if (table.Columns[i].DataType.ToString() != "System.DateTime" && table.Columns[i].DataType.ToString() != "System.Int32" 
                    && table.Columns[i].DataType.ToString() != "System.Byte" && table.Columns[i].DataType.ToString() != "System.Decimal") // ili !nvarchar...
                    columnNames.Add(table.Columns[i].ColumnName);
                
            }

            for (int i = 0; i < columnNames.Count - 1; i++)
                searchString += columnNames[i] + " LIKE '%{0}%' or ";

            if(columnNames.Count > 0)
            searchString += columnNames[columnNames.Count - 1] + " LIKE '%{0}%'";
            (dgvPrikaz.DataSource as DataTable).DefaultView.RowFilter = string.Format(searchString, txtPretraga.Text).Trim();

        }

        private void btnDetaljnaPretraga_Click(object sender, EventArgs e)
        {
            FilterString filterString = new FilterString();
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            try
            {
                FormInput formInput = new FormInput(myProperty, StateEnum.Search, filterString);
                formInput.ShowDialog();
                if (formInput.DialogResult == DialogResult.OK)
                {
                    (dgvPrikaz.DataSource as DataTable).DefaultView.RowFilter = filterString.FStr;
                    if(dgvPrikaz.Rows.Count == 0)
                    {
                        refreshTable();
                        MessageBox.Show("Odgovarajući podatak(podaci) ne postoje u bazi!", "Pretraga");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 

        }

        private void btnAzurirajZapise_Click(object sender, EventArgs e)
        {
            refreshTable();
            dgvPrikaz.ClearSelection();
        }
        int idReda, idKnjige;
        private void dgvPrikaz_MouseClick(object sender, MouseEventArgs e)
        {
            //popunjavanje list box-a
            lbDetaljno.Items.Clear();
            if (dgvPrikaz.HitTest(e.X, e.Y).RowIndex >= 0)
            {
                for (int i = 0; i < dgvPrikaz.SelectedCells.Count; i++)
                {
                    lbDetaljno.Items.Add(dgvPrikaz.Columns[i].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[i].Value);
                }
            }


            //pozivanje procedure, preko txtPretraga implementirati da se posalje parametar u proceduru
            if (state == StateEnum.View)
            {
                populatePropertyInterface();
                DataTable dt = new DataTable();
                SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
                myProperty.GetSelectPregledClanarinePoClanovima(), myProperty.GetSelectPregledClanarinePoClanovimaParameters().ToArray());
                dt.Load(reader);
                reader.Close();
                dgvPrikaz.DataSource = dt;
            }
            //provjerava da li se radi o klasi PropertyKnjiga 
            if (e.Button == MouseButtons.Right && myProperty.GetType() == typeof(PropertyKnjiga))
            {
                try
                {
                    ContextMenuStrip m = new ContextMenuStrip();
                    idReda = dgvPrikaz.HitTest(e.X, e.Y).RowIndex;
                    idKnjige = Convert.ToInt32(dgvPrikaz.SelectedRows[0].Cells[0].Value);
                    if (idReda >= 0)
                    {
                        m.Items.Add("Dodaj izdavača").Name = "Izdavac";
                        m.Items.Add("Dodaj autora").Name = "Autor";
                    }
                    m.Show(dgvPrikaz, new Point(e.X, e.Y));
                    m.ItemClicked += new ToolStripItemClickedEventHandler(m_ItemClicked);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }

            }
            if (myProperty.GetType() == typeof(PropertyKnjiga))
            {
                if (dgvPrikaz.HitTest(e.X, e.Y).RowIndex >= 0)
                {

                    try
                    {
                        ViewDetails(dgvPrikaz.SelectedRows[0].ToString());
                    }
                    catch (Exception)
                    {

                        return;
                    }
                }
            }

        }

        private void m_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "Izdavac":
                    FormInput inputIzdavac = new FormInput(new PropertyIzdavacKnjiga(), StateEnum.Create, idKnjige);
                    inputIzdavac.ShowDialog();

                    break;
                case "Autor":
                    FormInput inputAutor = new FormInput(new PropertyAutorKnjiga(), StateEnum.Create, idKnjige);
                    inputAutor.ShowDialog();

                    break;
                default:
                    break;
            }
        }

        private void ViewDetails(string id)
        {
            //pozivanje view-a ili procedure, kojima ce se prikazati sredjeni podaci bez ID-eva ili zajedno sa njima
            //1.treba mi id reda 
            //2.select upit - procedura
            //3.rezultat smjesti u ListBox

            populatePropertyInterface();
            //dt za autora
            DataTable dt = new DataTable();
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
            myProperty.GetProcedureSelectAutor(), myProperty.GetProcedureParameters().ToArray());
            dt.Load(reader);
            reader.Close();

            //dt za izdavaca
            DataTable dti = new DataTable();
            SqlDataReader readeri = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
            myProperty.GetProcedureSelectIzdavac(), myProperty.GetProcedureParameters().ToArray());
            dti.Load(readeri);
            readeri.Close();

            //prikazuje se Autor/i knjige
            if (dt.Rows.Count == 1)
            {
                lbDetaljno.Items.Add("-----------------------------------------");
                lbDetaljno.Items.Add("Autor: ");
            }
            else
            {
                lbDetaljno.Items.Add("-----------------------------------------");
                lbDetaljno.Items.Add("Autori: ");
            }
            foreach (DataRow row in dt.Rows)
            {
                int h = 0;
                foreach (DataColumn col in dt.Columns)
                {
                    lbDetaljno.Items.Add("\t" + row[h++]);
                }

            }

            //prikazuje se Izdavac/i knjige
            if (dti.Rows.Count == 1)
            {
                lbDetaljno.Items.Add("-----------------------------------------");
                lbDetaljno.Items.Add("Izdavač: ");
            }
            else
            {
                lbDetaljno.Items.Add("-----------------------------------------");
                lbDetaljno.Items.Add("Izdavači: ");
            }

            foreach (DataRow row in dti.Rows)
            {
                int h = 0;
                foreach (DataColumn col in dti.Columns)
                {
                    lbDetaljno.Items.Add("\t" + col + ": " + row[h++]);
                }
                lbDetaljno.Items.Add("\t" + "--------------------------------");
            }

        }
    }
}
