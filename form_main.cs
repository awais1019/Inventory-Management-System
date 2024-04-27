using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MidProjectEven.UserControls;

namespace MidProjectEven
{
    public partial class main_form : Form
    {

      

        public main_form()
        {
            InitializeComponent();
           
        }
        public void setMenu(Control control, string header_name)
        {

            main_panel.Controls.Clear();
            label_header_main.Text = header_name; 
            main_panel.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
 

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            setMenu(new Home_UserControl(), "Home");


        }


        private void btn_home_Click(object sender, EventArgs e)
        {
            setMenu(new Home_UserControl(), "Home");

        }

        private void Students_btn_Click(object sender, EventArgs e)
        {

            setMenu(new Student_control(), "Students");

        }
    
        private void Assesment_btn_Click(object sender, EventArgs e)
        {
            setMenu(new MakeAssesment_Control(), "Assessments");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Close Application", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            { 
                Application.Exit();
            }
         
        }
        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            sidepicture.Location = new Point(b.Location.X + 118, b.Location.Y - 30);
            sidepicture.SendToBack();
        }
        private void btn_home_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void maximize_btn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
              
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
         
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void attendance_btn_Click(object sender, EventArgs e)
        {
            setMenu(new Attendance_Record(), "Attendance Record");
        }

        private void Clo_btn_Click(object sender, EventArgs e)
        {
            setMenu(new ManageClos_Control(), "CLO Details and Rubric Management");
        }

        private void Assessment_Components_Click(object sender, EventArgs e)
        {
            setMenu(new AssessmentComponents(), "Assessment Components");
        }

        private void Evalution_btn_Click(object sender, EventArgs e)
        {
            setMenu(new MarkEvalution(), "Mark Evaluation");
        }
    }
  
}
