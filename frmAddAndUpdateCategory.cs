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
    public partial class frmAddAndUpdateCategory : Form
    {


       private  enum _enMod {AddNew=1,Update=2};
       private  _enMod _Mod;

        private int _CaegoryID = -1;



        public frmAddAndUpdateCategory()
        {
            InitializeComponent();
            _Mod = _enMod.AddNew;
        }


        public frmAddAndUpdateCategory(int CaegoryID)
        {
            InitializeComponent();
            _CaegoryID = CaegoryID;  
            _Mod =_enMod.Update;
        }






        private void BnSave_Click(object sender, EventArgs e)
        {

            switch (_Mod)
            {

                case _enMod.AddNew:

                    cntAddAndUpdateCategory1.AddNewCategory();
                    break;

                case _enMod.Update:

                    cntAddAndUpdateCategory1.UpdateCategory(_CaegoryID);
                    break;

            }







        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddAndUpdateCategory1_Load(object sender, EventArgs e)
        {
           
            if (_Mod == _enMod.Update)
            cntAddAndUpdateCategory1.LoadPersonInfo(_CaegoryID);
           

        }
    }
}
