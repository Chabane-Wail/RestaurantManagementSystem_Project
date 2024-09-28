using ComponentFactory.Krypton.Toolkit;
using Restaurant_Business;
using RestaurantManagementSystem_Project.Clases;
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
    public partial class frmLogin : KryptonForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void isreal()
        {
            clsUser user = clsUser.FindByUsernameAndPassword(txtUsername.Text.Trim(), clsUtil.Encrypt(txtPassword.Text.Trim(), clsUtil.key));

            if (user != null)
            {

                if (chkRememberMe.Checked)
                {
                    //store username and password
                    clsGlobel.RememberUsernameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());

                }
                else
                {
                    //store empty username and password
                    clsGlobel.RememberUsernameAndPassword("", "");

                }

                //incase the user is not active
                if (user.IsActive)
                {

                    txtUsername.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsGlobel.CurrentUser = user;
                this.Hide();
                frmMain frm = new frmMain();
                frm.ShowDialog();


            }
            else
            {
                txtUsername.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }











  

 



        private void kbLogin_Click(object sender, EventArgs e)
        {

            isreal();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsGlobel.GetStoredCredential(ref UserName, ref Password))
            {
                txtUsername.Text = UserName;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;
        }

      
        private void kbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
