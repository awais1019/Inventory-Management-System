using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Inventory_Management_System.BL_Classes;

namespace Inventory_Management_System
{
    public partial class Print_Report : Form
    {
        List<History> history = new List<History>();
        History history1 = new History();
        public Print_Report(History history)
        {
            InitializeComponent();
            this.history1 = history;
        }

        private void crystalReportViewer_Load(object sender, EventArgs e)
        {
            //dispatchedProducts_CrystalReport1.SetDataSource(history);
            dispatchedProducts_CrystalReport1.SetParameterValue("pName", history1.name);
            dispatchedProducts_CrystalReport1.SetParameterValue("pVehicle", "hello");
            dispatchedProducts_CrystalReport1.SetParameterValue("pdepLocation", "hello");
            dispatchedProducts_CrystalReport1.SetParameterValue("pArrLocation", "hello");
            crystalReportViewer.ReportSource = dispatchedProducts_CrystalReport1; 
            crystalReportViewer.Refresh();
        }

        private void dispatchedProducts_CrystalReport2_InitReport(object sender, EventArgs e)
        {

        }
    }
}
