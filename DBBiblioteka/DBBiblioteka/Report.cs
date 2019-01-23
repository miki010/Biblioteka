using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBBiblioteka
{
    public partial class Report : Form
    {
        string korisnik = "";
 

        public Report(string korisnik)
        {
            this.korisnik = korisnik;

            InitializeComponent();
            CrystalReportViewer reportViewer = new CrystalReportViewer();
            this.Controls.Add(reportViewer);

            reportViewer.Dock = DockStyle.Fill;

            if (korisnik == "iznajmljivanje")
            {
                var rpt = new ReportDocument();
                string reportPath = @"C:\Users\vladimir.klisura\Desktop\IzvjestajIznajmljivanje.rpt";
                rpt.Load(reportPath);
                reportViewer.ReportSource = rpt;

                reportViewer.Refresh();

            }
            else if (korisnik == "blagajnik")
            {
                var rpt2 = new ReportDocument();
                string reportPath2 = @"C:\Users\vladimir.klisura\Desktop\FinansijskiIzvjestaj.rpt";
                rpt2.Load(reportPath2);
               
                reportViewer.ReportSource = rpt2;

                reportViewer.Refresh();
            }
            else if(korisnik == "Knjige")
            {
                var rpt3 = new ReportDocument();
                string reportPath3 = @"C:\Users\vladimir.klisura\Desktop\PregledKnjiga.rpt";
                rpt3.Load(reportPath3);
               
                reportViewer.ReportSource = rpt3;

                reportViewer.Refresh();

            }
        }
    }
}

      
    

