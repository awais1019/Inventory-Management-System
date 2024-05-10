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
        List<Transportation> historyL = new List<Transportation>();
        History history = new History();
        public Print_Report(History history, List<Transportation> historyL)
        {
            InitializeComponent();
            this.history = history;
            this.historyL = historyL;
        }

        private void crystalReportViewer_Load(object sender, EventArgs e)
        {
            dispatchedProducts_CrystalReport1.SetDataSource(historyL);
            dispatchedProducts_CrystalReport1.SetParameterValue("pName", history.name);
            dispatchedProducts_CrystalReport1.SetParameterValue("pUPrice", history.price);
            dispatchedProducts_CrystalReport1.SetParameterValue("pQuantity", history.quantity);
            dispatchedProducts_CrystalReport1.SetParameterValue("pTPrice", history.totalPrice);
            dispatchedProducts_CrystalReport1.SetParameterValue("pCategory", history.category);
            dispatchedProducts_CrystalReport1.SetParameterValue("pManufacturer", history.manufacturer);
            crystalReportViewer.ReportSource = dispatchedProducts_CrystalReport1; 
            crystalReportViewer.Refresh();
        }

        private void dispatchedProducts_CrystalReport2_InitReport(object sender, EventArgs e)
        {

        }
    }
}
