using Inventory_Management_System.BL_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Inventory_Management_System.UserControls
{
    public partial class Home_Control : UserControl
    {
        public Home_Control()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            Addcards();
            Addcards1();
        }
        void Addcards()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            for (int i = 0; i < 5; i++)
            {
                Threshold_Card card =new Threshold_Card();
              /*  card.setvalues(Name, null, null);*/
                flowLayoutPanel1.Controls.Add(card);
            
           
              
        
            }
            flowLayoutPanel1.ResumeLayout();
        }
        void Addcards1()
        {
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel2.ResumeLayout();
            for (int i = 0; i < 5; i++)
            {
                Product_Movement_Card card1=new Product_Movement_Card();
                /*  card.setvalues(Name, null, null);*/

                flowLayoutPanel2.Controls.Add(card1);
            }
            flowLayoutPanel2.ResumeLayout();
            

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
