using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBBiblioteka.PropertiesClass;

namespace DBBiblioteka
{
    public partial class FormBibliotekar : MetroFramework.Forms.MetroForm
    {
        public FormBibliotekar()
        {
            InitializeComponent();
            tileClanarina.BringToFront();
            tileIznajmi.BringToFront();
            tilePregledIznajmljivanja.BringToFront();
            tilePretraga.BringToFront();
            tileUnosClana.BringToFront();
            tileVracanje.BringToFront();
        }

        private void Bibliotekar_Load(object sender, EventArgs e)
        {

        }

        private void tilePretraga_Click(object sender, EventArgs e)
        {

        }

        private void tileUnosClana_Click(object sender, EventArgs e)
        {
            FormStandard formStandard = new FormStandard(new PropertyClan());
            formStandard.ShowDialog();
        }

        private void tileIznajmi_Click(object sender, EventArgs e)
        {
            FormStandard formStandard = new FormStandard(new PropertyIznajmljivanje());
            formStandard.ShowDialog();
        }

        private void tileVracanje_Click(object sender, EventArgs e)
        {
            FormStandard formStandard = new FormStandard(new PropertyIznajmljivanje());
            formStandard.ShowDialog();
        }

        private void tileClanarina_Click(object sender, EventArgs e)
        {
            FormStandard formStandard = new FormStandard(new PropertyClan(), StateEnum.View);
            formStandard.ShowDialog();
        }

        private void tileUnosClana_MouseHover(object sender, EventArgs e)
        {
            tileUnosClana.Height -= 15;
            tileUnosClana.Width -= 20;
        }

        private void tileUnosClana_MouseLeave(object sender, EventArgs e)
        {
            tileUnosClana.Height += 15;
            tileUnosClana.Width += 20;
        }

        private void tilePretraga_MouseHover(object sender, EventArgs e)
        {
            tilePretraga.Height -= 15;
            tilePretraga.Width -= 20;
        }

        private void tilePretraga_MouseLeave(object sender, EventArgs e)
        {
            tilePretraga.Height += 15;
            tilePretraga.Width += 20;
        }

        private void tilePregledIznajmljivanja_MouseHover(object sender, EventArgs e)
        {
            tilePregledIznajmljivanja.Height -= 15;
            tilePregledIznajmljivanja.Width -= 20;
        }

        private void tilePregledIznajmljivanja_MouseLeave(object sender, EventArgs e)
        {
            tilePregledIznajmljivanja.Height += 15;
            tilePregledIznajmljivanja.Width += 20;
        }

        private void tileIznajmi_MouseHover(object sender, EventArgs e)
        {
            tileIznajmi.Height -= 20;
            tileIznajmi.Width -= 15;
        }

        private void tileIznajmi_MouseLeave(object sender, EventArgs e)
        {
            tileIznajmi.Height += 20;
            tileIznajmi.Width += 15;
        }

        private void tileVracanje_MouseHover(object sender, EventArgs e)
        {
            tileVracanje.Height -= 15;
            tileVracanje.Width -= 15;
        }

        private void tileVracanje_MouseLeave(object sender, EventArgs e)
        {
            tileVracanje.Height += 15;
            tileVracanje.Width += 15;
        }

        private void tileClanarina_MouseHover(object sender, EventArgs e)
        {
            tileClanarina.Height -= 15;
            tileClanarina.Width -= 20;
        }

        private void tileClanarina_MouseLeave(object sender, EventArgs e)
        {
            tileClanarina.Height += 15;
            tileClanarina.Width += 20;
        }
    }
}
