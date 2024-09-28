using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem_Project
{
    public partial class frmMain : KryptonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void AddControls(Form f)
        {



            CenterPanale.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanale.Controls.Add(f);
            f.Show();

        }









         
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //frmLogin frmLogin = new frmLogin();
            //frmLogin.ShowDialog();
        }

        
         
          
 
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void lblCategories_Click_1(object sender, EventArgs e)
        {


            AddControls(new frmCategoryList());


        }

        private void lblProducts_Click(object sender, EventArgs e)
        {
            AddControls(new frmStaffList());
        }
    }
}
