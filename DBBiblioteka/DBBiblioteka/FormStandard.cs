using System;
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
using System.Drawing;
using System.Text;
using System.Globalization;

namespace DBBiblioteka
{
    public partial class FormStandard : MetroForm
    {
        PropertyLogin propertyLogin = new PropertyLogin();

        public static string zaposleniId;
        public static string korisnickoIme;
        public static string radnoMjestoId;


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
            this.tileDodaj.BringToFront();
            this.tileIzmijeni.BringToFront();
            this.tileObrisi.BringToFront();
            this.tileVrati.BringToFront();
            tileSelectFirst.BringToFront();
            tileSelectLast.BringToFront();
            tileSelectNext.BringToFront();
            tileSelectPrevious.BringToFront();
            tileDetaljnaPretraga.BringToFront();
            tileAzurirajZapise.BringToFront();
            metroLabel1.BringToFront();
            txtPretraga.BringToFront();
            panelPretraga.BringToFront();
            labelTitle.BringToFront();
            lblBrojRedova.BringToFront();
            lblDetaljno.BringToFront();
            lblRedIndex.BringToFront();
            panelDetalno.BringToFront();
          
            dgvPrikaz.BringToFront();
            
        }

        private void FormStandard_Load(object sender, EventArgs e)
        {
            if (state == StateEnum.LookUp)
            {
                panelCrud.Visible = true;
                panelCrud.Enabled = false;
                panelVrati.Visible = true;
            }
            else
            {
                panelCrud.Visible = true;
                panelCrud.Enabled = true;
                panelVrati.Visible = true;
                panelVrati.Enabled = false;
            }
            loadTable();
            dgvPrikaz.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrikaz.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPrikaz.MultiSelect = false;
            dgvPrikaz.Rows[0].Selected = true;
            dgvPrikaz.Focus();
            //}
            dgvPrikaz.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dgvPrikaz.EnableHeadersVisualStyles = false;

            foreach (DataGridViewColumn column in dgvPrikaz.Columns)
            {
                if (column.HeaderText.Contains("ID"))
                    column.Width = 130;
            }
            if (myProperty is PropertyIznajmljivanje)
            {
                dgvPrikaz.Columns[dgvPrikaz.Columns.Count - 1].Width = 80;
                dgvPrikaz.Columns[dgvPrikaz.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvPrikaz.Columns[dgvPrikaz.Columns.Count - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvPrikaz.AlternatingRowsDefaultCellStyle.BackColor = Color.PowderBlue;
            foreach (DataGridViewColumn column in dgvPrikaz.Columns)
            {
                if (column.ValueType.ToString() == "System.DateTime")
                    column.DefaultCellStyle.Format = "dd.MM.yyyy";
            }
        }

        private void loadTable()
        {
            DataTable dt = new DataTable();
            SqlDataReader reader = null;
        
            dgvPrikaz.Focus();
            //if (state == StateEnum.View)
            //{

            //}
            //else
            //{
            reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
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
                FormInput formInput = new FormInput(myProperty, StateEnum.Create);
                formInput.ShowDialog();
                if (formInput.DialogResult == DialogResult.OK)
                {
                    refreshTable();
                }
            }
            catch (Exception ex)
            {
                return;
               // MessageBox.Show(ex.ToString(), "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    catch (Exception)
                    {
                        return;
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
                            MessageBox.Show("Brisanje nije moguće, podatak se koristi u drugoj tabeli!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if (row.Cells[item.GetCustomAttribute<SqlNameAttribute>().Name].ToString() == "DatumRazduzivanja")
                        continue;
                    else
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
                if (table.Columns[i].DataType.ToString() == "System.String")
                    columnNames.Add(table.Columns[i].ColumnName);
            }

            for (int i = 0; i < columnNames.Count - 1; i++)
                searchString += columnNames[i] + " LIKE '%{0}%' or ";

            if (columnNames.Count > 0)
                searchString += columnNames[columnNames.Count - 1] + " LIKE '%{0}%'";
            (dgvPrikaz.DataSource as DataTable).DefaultView.RowFilter = string.Format(searchString, txtPretraga.Text).Trim();

        }

        private void btnDetaljnaPretraga_Click(object sender, EventArgs e)
        {
            FilterString filterString = new FilterString();
            try
            {
                FormInput formInput = new FormInput(myProperty, StateEnum.Search, filterString);
                formInput.ShowDialog();
                if (formInput.DialogResult == DialogResult.OK)
                {
                    (dgvPrikaz.DataSource as DataTable).DefaultView.RowFilter = filterString.FStr;
                    if (dgvPrikaz.Rows.Count == 0)
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
        int idReda, idKnjige, idZaposlenog;
        private void dgvPrikaz_MouseClick(object sender, MouseEventArgs e)
        {
            //popunjavanje list box-a
            lbDetaljno.Items.Clear();
            if (dgvPrikaz.HitTest(e.X, e.Y).RowIndex >= 0)
            {
                bool jeLiRazduzeno = false;
                string datumRazd = "";
                for (int i = 0; i < dgvPrikaz.SelectedCells.Count; i++)
                {
                    try
                    {
                        if (dgvPrikaz.Columns[i].ValueType == typeof(bool))
                        {
                            lbDetaljno.Items.Add(dgvPrikaz.Columns[i].HeaderText + " : " + ((bool)dgvPrikaz.SelectedRows[0].Cells[i].Value ? "Da" : "Ne"));
                            jeLiRazduzeno = (bool)dgvPrikaz.SelectedRows[0].Cells[i].Value;
                        }
                            

                        else if (dgvPrikaz.Columns[i].ValueType == typeof(DateTime))
                        {
                            DateTime datum = (DateTime)dgvPrikaz.SelectedRows[0].Cells[i].Value;
                            if (dgvPrikaz.Columns[i].HeaderText == "Datum razduživanja") //ubacuje rok umjesto datuma razduzivanja
                            {
                                datumRazd = string.Format("{0}.{1}.{2}", datum.Day, datum.Month, datum.Year);
                                continue;
                            }
                            string date = string.Format("{0}.{1}.{2}", datum.Day, datum.Month, datum.Year);
                            lbDetaljno.Items.Add(dgvPrikaz.Columns[i].HeaderText + " : " + date);

                            string rokZaVracanje = string.Format("{0}.{1}.{2}", datum.AddDays(15).Day, datum.AddDays(15).Month, datum.AddDays(15).Year);
                            lbDetaljno.Items.Add("Rok za vraćanje: " + rokZaVracanje);
                        }
                        else
                            lbDetaljno.Items.Add(dgvPrikaz.Columns[i].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[i].Value);
                    }
                    catch (Exception) { } // U slucaju da je datum ili bool NULL
                }
                if (jeLiRazduzeno)
                    lbDetaljno.Items.Add("Datum razduživanja: " + datumRazd);

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
                        //m.Items.Add("Izmjeni izdavača").Name = "IzdavacIzmjena";
                        m.Items.Add("Dodaj autora").Name = "Autor";
                        //m.Items.Add("Izmjeni autora").Name = "AutorIzmjena";

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
            if (myProperty.GetType() == typeof(PropertyKnjiga))//NECE BITI DOVOLJNO
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
            else if (myProperty.GetType() == typeof(PropertyZaposleni))
            {
                if (dgvPrikaz.HitTest(e.X, e.Y).RowIndex >= 0)
                {

                    try
                    {
                        ViewDetailsData(dgvPrikaz.SelectedRows[0].ToString());

                        //desni
                        if(e.Button == MouseButtons.Right)
                        {
                            try
                            {
                                ContextMenuStrip m = new ContextMenuStrip();
                                idReda = dgvPrikaz.HitTest(e.X, e.Y).RowIndex;
                                zaposleniId = dgvPrikaz.SelectedRows[0].Cells[0].Value.ToString();
                                korisnickoIme = dgvPrikaz.SelectedRows[0].Cells[1].Value.ToString().ToLower() + "." + dgvPrikaz.SelectedRows[0].Cells[3].Value.ToString().ToLower();


                                string normal = korisnickoIme.Normalize(NormalizationForm.FormD);
                                var withoutDiacritics = normal.Where(
                                    c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark);
                                string final = new string(withoutDiacritics.ToArray());
                                if (final != korisnickoIme)
                                    korisnickoIme = final;
                              


                                radnoMjestoId = dgvPrikaz.SelectedRows[0].Cells[10].Value.ToString();
                                if (idReda >= 0)
                                {                                    
                                    m.Items.Add("Dodaj pristupne podatke").Name = "PristupniPodaci";
   
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
                    }
                    catch (Exception)
                    {

                        return;
                    }
                }
            }
            else if (myProperty.GetType() == typeof(PropertyClanarina))
            {
                if (dgvPrikaz.HitTest(e.X, e.Y).RowIndex >= 0)
                {

                    try
                    {
                        ViewDetailsData(dgvPrikaz.SelectedRows[0].ToString());
                    }
                    catch (Exception)
                    {

                        return;
                    }
                }
            }
            else if (myProperty.GetType() == typeof(PropertyIznajmljivanje))
            {
                if (dgvPrikaz.HitTest(e.X, e.Y).RowIndex >= 0)
                {
                    try
                    {

                        ViewDetailsData(dgvPrikaz.SelectedRows[0].ToString());
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
                case "PristupniPodaci":                   
                    FormInput inputPodaci = new FormInput(new PropertyLogin(), StateEnum.Create);
                    inputPodaci.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void dgvPrikaz_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvPrikaz.Rows.Count == 1)
                lblBrojRedova.Text = "1 rezultat";
            else
                lblBrojRedova.Text = dgvPrikaz.Rows.Count + " rezultata";
        }

        private void dgvPrikaz_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvPrikaz.Rows.Count == 1)
                lblBrojRedova.Text = "1 rezultat";
            else
                lblBrojRedova.Text = dgvPrikaz.Rows.Count + " rezultata";
        }

        private void ViewDetailsData(string id)
        {
            populatePropertyInterface();
            //dt za autora
            DataTable dt = new DataTable();
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
            myProperty.GetProcedureSelectAllDetails(), myProperty.GetProcedureParametersIznajmljivanjeID().ToArray());

            dt.Load(reader);
            reader.Close();

            if (myProperty.GetType() == typeof(PropertyZaposleni))
            {

                lbDetaljno.Items.Add("-----------------------------------------");
                lbDetaljno.Items.Add("Radno mjesto: ");

                foreach (DataRow row in dt.Rows)
                {
                    int h = 0;
                    foreach (DataColumn col in dt.Columns)
                    {
                        lbDetaljno.Items.Add("\t" + row[h++]);
                    }
                }
            }
            else if (myProperty.GetType() == typeof(PropertyClanarina))
            {
                lbDetaljno.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int h = 0;
                    foreach (DataColumn col in dt.Columns)
                    {
                        lbDetaljno.Items.Add(col + ": " + row[h++]);
                    }
                }
            }
            else if (myProperty.GetType() == typeof(PropertyIznajmljivanje))
            {
                lbDetaljno.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    int h = 0;
                    foreach (DataColumn col in dt.Columns)
                    {
                        lbDetaljno.Items.Add(col + ": " + row[h++]);
                    }
                }
            }
        }

        private void dgvPrikaz_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrikaz.Rows.Count > 0)
                lblRedIndex.Text = (dgvPrikaz.CurrentCell.RowIndex + 1).ToString() + "/" + dgvPrikaz.Rows.Count;
            else
                lblRedIndex.Text = "0/0";
        }


        private void tileDetaljnaPretraga_Click(object sender, EventArgs e)
        {
            FilterString filterString = new FilterString();
            try
            {
                FormInput formInput = new FormInput(myProperty, StateEnum.Search, filterString);
                formInput.ShowDialog();
                if (formInput.DialogResult == DialogResult.OK)
                {
                    (dgvPrikaz.DataSource as DataTable).DefaultView.RowFilter = filterString.FStr;
                    if (dgvPrikaz.Rows.Count == 0)
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

        private void tileAzurirajZapise_Click(object sender, EventArgs e)
        {
            refreshTable();
            dgvPrikaz.ClearSelection();
        }

        //Vlado promjena reda na dugme i detaljan prikaz*************************************************************************************
        private void tileSelectNext_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dgvPrikaz;
            dgv.Focus();
            if (dgv.SelectedRows[0].Index == dgv.Rows.Count - 1) return;

            if (dgv.Rows[0].Index == dgv.Rows.Count + 1)
            {
                for (int i = 0; i < dgvPrikaz.SelectedCells.Count; i++)
                {
                    if (myProperty.GetType() == typeof(PropertyClanarina) || myProperty.GetType() == typeof(PropertyIznajmljivanje))
                    {
                        ViewDetailsData(dgvPrikaz.SelectedRows[0].ToString());
                    }
                    else if (myProperty.GetType() == typeof(PropertyZaposleni))
                    {
                        for (int j = 0; j < dgvPrikaz.SelectedCells.Count; j++)
                        {
                            lbDetaljno.Items.Add(dgvPrikaz.Columns[j].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[j].Value);
                        }
                        ViewDetailsData(dgvPrikaz.SelectedRows[0].ToString());
                        break;
                    }
                    else if (myProperty.GetType() == typeof(PropertyKnjiga))
                    {
                        //lbDetaljno.Items.Clear();
                        for (int j = 0; j < dgvPrikaz.SelectedCells.Count; j++)
                        {
                            lbDetaljno.Items.Add(dgvPrikaz.Columns[j].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[j].Value);
                        }

                        ViewDetails(dgvPrikaz.SelectedRows[0].ToString());
                        break;
                    }
                    else
                    {
                        lbDetaljno.Items.Add(dgvPrikaz.Columns[i].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[i].Value);
                    }
                }
            }
            dgv.Rows[dgv.SelectedRows[0].Index + 1].Selected = true;
            dgv.CurrentCell = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0];
            lbDetaljno.Items.Clear();

            for (int i = 0; i < dgvPrikaz.SelectedCells.Count; i++)
            {
                if (myProperty.GetType() == typeof(PropertyClanarina) || myProperty.GetType() == typeof(PropertyIznajmljivanje))
                {
                    ViewDetailsData(dgvPrikaz.SelectedRows[0].ToString());
                }
                else if (myProperty.GetType() == typeof(PropertyZaposleni))
                {
                    for (int j = 0; j < dgvPrikaz.SelectedCells.Count; j++)
                    {
                        lbDetaljno.Items.Add(dgvPrikaz.Columns[j].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[j].Value);
                    }
                    ViewDetailsData(dgvPrikaz.SelectedRows[0].ToString());
                    break;
                }
                else if (myProperty.GetType() == typeof(PropertyKnjiga))
                {
                    //lbDetaljno.Items.Clear();
                    for (int j = 0; j < dgvPrikaz.SelectedCells.Count; j++)
                    {
                        lbDetaljno.Items.Add(dgvPrikaz.Columns[j].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[j].Value);
                    }
                    ViewDetails(dgvPrikaz.SelectedRows[0].ToString());
                    break;
                }
                else
                {
                    lbDetaljno.Items.Add(dgvPrikaz.Columns[i].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[i].Value);
                }
            }
        }

        private void tileSelectPrevious_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dgvPrikaz;
            dgv.Focus();
            if (dgv.SelectedRows[0].Index == 0) return;
            if (dgv.Rows[0].Index == dgv.Rows.Count + 1)
            {
                for (int i = 0; i < dgvPrikaz.SelectedCells.Count; i++)
                {
                    if (myProperty.GetType() == typeof(PropertyClanarina) || myProperty.GetType() == typeof(PropertyIznajmljivanje))
                    {
                        ViewDetailsData(dgvPrikaz.SelectedRows[0].ToString());

                    }
                    else if (myProperty.GetType() == typeof(PropertyZaposleni))
                    {
                        for (int j = 0; j < dgvPrikaz.SelectedCells.Count; j++)
                        {
                            lbDetaljno.Items.Add(dgvPrikaz.Columns[j].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[j].Value);
                        }
                        ViewDetailsData(dgvPrikaz.SelectedRows[0].ToString());
                        break;
                    }
                    else if (myProperty.GetType() == typeof(PropertyKnjiga))
                    {
                        //lbDetaljno.Items.Clear();
                        for (int j = 0; j < dgvPrikaz.SelectedCells.Count; j++)
                        {
                            lbDetaljno.Items.Add(dgvPrikaz.Columns[j].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[j].Value);
                        }
                        ViewDetails(dgvPrikaz.SelectedRows[0].ToString());
                        break;
                    }
                    else
                    {
                       lbDetaljno.Items.Add(dgvPrikaz.Columns[i].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[i].Value);
                    }
                }
            }
            dgv.Rows[dgv.SelectedRows[0].Index - 1].Selected = true;
            dgv.CurrentCell = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0];
            lbDetaljno.Items.Clear();
            for (int i = 0; i < dgvPrikaz.SelectedCells.Count; i++)
            {
                if (myProperty.GetType() == typeof(PropertyClanarina) || myProperty.GetType() == typeof(PropertyIznajmljivanje))
                {
                    ViewDetailsData(dgvPrikaz.SelectedRows[0].ToString());

                }
                else if (myProperty.GetType() == typeof(PropertyZaposleni))
                {
                    for (int j = 0; j < dgvPrikaz.SelectedCells.Count; j++)
                    {
                        lbDetaljno.Items.Add(dgvPrikaz.Columns[j].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[j].Value);
                    }
                    ViewDetailsData(dgvPrikaz.SelectedRows[0].ToString());
                    break;
                }
                else if (myProperty.GetType() == typeof(PropertyKnjiga))
                {
                    //lbDetaljno.Items.Clear();
                    for (int j = 0; j < dgvPrikaz.SelectedCells.Count; j++)
                    {
                        lbDetaljno.Items.Add(dgvPrikaz.Columns[j].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[j].Value);
                    }
                    ViewDetails(dgvPrikaz.SelectedRows[0].ToString());
                    break;
                }
                else
                {
                    lbDetaljno.Items.Add(dgvPrikaz.Columns[i].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[i].Value);
                }
            }
        }

        private void tileSelectLast_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dgvPrikaz;
            dgv.Focus();
            try
            {
                dgv.ClearSelection();
                int Index = dgv.Rows.Count - 1;

                dgv.Rows[Index].Selected = true;
                dgv.Rows[Index].Cells[0].Selected = true;
                lbDetaljno.Items.Clear();
                for (int i = 0; i < dgvPrikaz.SelectedCells.Count; i++)
                {
                    if (myProperty.GetType() == typeof(PropertyClanarina) || myProperty.GetType() == typeof(PropertyIznajmljivanje))
                    {
                        ViewDetailsData(dgvPrikaz.SelectedRows[0].ToString());
                    }
                    else if (myProperty.GetType() == typeof(PropertyZaposleni))
                    {
                        for (int j = 0; j < dgvPrikaz.SelectedCells.Count; j++)
                        {
                            lbDetaljno.Items.Add(dgvPrikaz.Columns[j].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[j].Value);
                        }
                        ViewDetailsData(dgvPrikaz.SelectedRows[0].ToString());
                        break;
                    }
                    else if (myProperty.GetType() == typeof(PropertyKnjiga))
                    {
                        //lbDetaljno.Items.Clear();
                        for (int j = 0; j < dgvPrikaz.SelectedCells.Count; j++)
                        {
                            lbDetaljno.Items.Add(dgvPrikaz.Columns[j].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[j].Value);
                        }
                        ViewDetails(dgvPrikaz.SelectedRows[0].ToString());
                        break;
                    }
                    else
                    {
                        lbDetaljno.Items.Add(dgvPrikaz.Columns[i].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[i].Value);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void tileSelectFirst_Click(object sender, EventArgs e)
        {

            DataGridView dgv = dgvPrikaz;
            dgv.Focus();
            try
            {
                dgv.ClearSelection();
                int Index = 0;

                dgv.Rows[Index].Selected = true;
                dgv.Rows[Index].Cells[0].Selected = true;
                lbDetaljno.Items.Clear();

                for (int i = 0; i < dgvPrikaz.SelectedCells.Count; i++)
                {
                    if (myProperty.GetType() == typeof(PropertyClanarina) || myProperty.GetType() == typeof(PropertyIznajmljivanje))
                    {
                        ViewDetailsData(dgvPrikaz.SelectedRows[0].ToString());

                    }
                    else if (myProperty.GetType() == typeof(PropertyZaposleni))
                    {
                        for (int j = 0; j < dgvPrikaz.SelectedCells.Count; j++)
                        {
                            lbDetaljno.Items.Add(dgvPrikaz.Columns[j].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[j].Value);
                        }
                        ViewDetailsData(dgvPrikaz.SelectedRows[0].ToString());
                        break;
                    }
                    else if (myProperty.GetType() == typeof(PropertyKnjiga))
                    {
                        //lbDetaljno.Items.Clear();
                        for (int j = 0; j < dgvPrikaz.SelectedCells.Count; j++)
                        {
                            lbDetaljno.Items.Add(dgvPrikaz.Columns[j].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[j].Value);
                        }
                        ViewDetails(dgvPrikaz.SelectedRows[0].ToString());
                        break;
                    }
                    else
                    {
                        lbDetaljno.Items.Add(dgvPrikaz.Columns[i].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[i].Value);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvPrikaz_KeyDown(object sender, KeyEventArgs e)
        {
        
        }

        private void dgvPrikaz_KeyUp(object sender, KeyEventArgs e)
        {
            DataGridView dgv = dgvPrikaz;
            dgv.Focus();
            dgv.CurrentCell = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0];
            lbDetaljno.Items.Clear();
            for (int i = 0; i < dgvPrikaz.SelectedCells.Count; i++)
            {
                if (myProperty.GetType() == typeof(PropertyClanarina) || myProperty.GetType() == typeof(PropertyIznajmljivanje))
                {
                    ViewDetailsData(dgvPrikaz.SelectedRows[0].ToString());

                }
                else if (myProperty.GetType() == typeof(PropertyZaposleni))
                {
                    for (int j = 0; j < dgvPrikaz.SelectedCells.Count; j++)
                    {
                        lbDetaljno.Items.Add(dgvPrikaz.Columns[j].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[j].Value);
                    }
                    ViewDetailsData(dgvPrikaz.SelectedRows[0].ToString());
                    break;
                }
                else if (myProperty.GetType() == typeof(PropertyKnjiga))
                {
                    //lbDetaljno.Items.Clear();
                    for (int j = 0; j < dgvPrikaz.SelectedCells.Count; j++)
                    {
                        lbDetaljno.Items.Add(dgvPrikaz.Columns[j].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[j].Value);
                    }
                    ViewDetails(dgvPrikaz.SelectedRows[0].ToString());
                    break;
                }
                else
                {

                    lbDetaljno.Items.Add(dgvPrikaz.Columns[i].HeaderText + " : " + dgvPrikaz.SelectedRows[0].Cells[i].Value);
                }
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tileSelectNext_MouseHover(object sender, EventArgs e)
        {
            metroToolTip1.Show("Pređite na sledeću stavku", tileSelectNext);
        }

        private void tileSelectLast_MouseHover(object sender, EventArgs e)
        {
            metroToolTip2.Show("Pređite na poslednju stavku", tileSelectLast);
        }

        private void tileSelectPrevious_MouseHover(object sender, EventArgs e)
        {
            metroToolTip3.Show("Vratite se na prethodnu stavku", tileSelectPrevious);
        }

        private void tileSelectFirst_MouseHover(object sender, EventArgs e)
        {
            metroToolTip4.Show("Vratite se na prvu stavku", tileSelectFirst);
        }

        private void tileDodaj_MouseHover(object sender, EventArgs e)
        {
            metroToolTip5.Show("Dodaj", tileDodaj);
        }

        private void tileIzmijeni_MouseHover(object sender, EventArgs e)
        {
            metroToolTip5.Show("Izmjeni", tileIzmijeni);
        }

        private void tileObrisi_MouseHover(object sender, EventArgs e)
        {
            metroToolTip5.Show("Obriši", tileObrisi);
        }

        private void tileVrati_MouseHover(object sender, EventArgs e)
        {
            metroToolTip5.Show("Potvrdi", tileVrati);
        }

        private void tileDetaljnaPretraga_MouseHover(object sender, EventArgs e)
        {
            metroToolTip6.Show("Detaljna pretraga", tileDetaljnaPretraga);
        }

        private void txtPretraga_MouseHover(object sender, EventArgs e)
        {
            metroToolTip6.Show("Brza pretraga", txtPretraga);
        }

        private void tileAzurirajZapise_MouseHover(object sender, EventArgs e)
        {
            metroToolTip6.Show("Osvježi prikaz", tileAzurirajZapise);
        }

        private void dgvPrikaz_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void dgvPrikaz_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //metroToolTip6.Show("Desni klik", dgvPrikaz);
            if ((e.RowIndex != -1) && (e.ColumnIndex == 1))
            {
                //MessageBox.Show("TEST");
                ToolTip tooltip1 = new ToolTip();
                tooltip1.Show("hello", dgvPrikaz, Cursor.Position.X, Cursor.Position.Y);

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
