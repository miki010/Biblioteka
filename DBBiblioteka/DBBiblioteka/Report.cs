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
        public Report()
        {
            InitializeComponent();
            CrystalReportViewer reportViewer = new CrystalReportViewer();
            this.Controls.Add(reportViewer);

            reportViewer.Dock = DockStyle.Fill;

            var rpt = new ReportDocument();

            string reportPath = @"C:\Users\vladimir.klisura\Desktop\BibliotekaReport.rpt";
            rpt.Load(reportPath);


            //definisati parametre
            // rpt.SetParameterValue("@SalesOrderID", 43659);
            //rpt.SetParameterValue("@RadnikId, null"); null = koju vrijednost proslijedjujemo

            reportViewer.ReportSource = rpt;

            reportViewer.Refresh();
        }
    }

      
    }

