using Restaurant_Business;
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
    public partial class cntAddAndUpdateCategory : UserControl
    {
        public cntAddAndUpdateCategory()
        {
            InitializeComponent();
        }

        public event Action<int> OnSavingEnd;
        // Create a protected method to raise the event with a parameter
        protected virtual void SavingEnd(int PersonID)
        {
            Action<int> handler = OnSavingEnd;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }


        private clsCategory _Category;

        private int _CategoryID = -1;

 
        public void LoadPersonInfo(int _CategoryID)
        {
            _Category = clsCategory.Find(_CategoryID);
            if (_Category == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National No. = " + _CategoryID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        private void _FillPersonInfo()
        {

            _CategoryID = _Category.CategoryID;
            txbCategoryName.Text = _Category.CategoryName.ToString();
            lblAddNewCategory.Text = "Update Category";
        }


      


        public void ResetPersonInfo()
        {
            _CategoryID = -1;
            lblCategoryName.Text = "";

            

        }

        private void txbCategoryName_TextChanged(object sender, EventArgs e)
        {

        }








        public void AddNewCategory()
        {
            if (txbCategoryName.Text == "")
            {
                txbCategoryName.Focus();
                errorProvider1.SetError(txbCategoryName, "CategoryName is Emty");
            }
            else
            {
                errorProvider1.SetError(txbCategoryName, null);

                clsCategory Category = new clsCategory();

                Category.CategoryName = txbCategoryName.Text.Trim();


                if (!clsCategory.isCategoryExist(txbCategoryName.Text.Trim()))
                {
                    if (Category.Save())
                    {
                        MessageBox.Show("Category Save Saccessfuly");



                    }

                    if (OnSavingEnd != null)
                        // Raise the event with a parameter
                        SavingEnd(Category.CategoryID);




                }
                else
                {

                    MessageBox.Show("Category Name already exists, try another one ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }





            };


        }

        public void UpdateCategory(int _CategoryID)
        {

            _Category = clsCategory.Find(_CategoryID);


            _Category.CategoryName = txbCategoryName.Text.Trim();
            _Category.CategoryID = _CategoryID;


            if (_Category != null)
            {



                if (_Category.Save())
                {

                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }


        }
        private void cntAddAndUpdateCategory_Load(object sender, EventArgs e)
        {

        }

        private void txbCategoryName_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
