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
    public partial class cntAddAndUpdateEmployee : UserControl
    {
        public cntAddAndUpdateEmployee()
        {
            InitializeComponent();
        }


        //private clsStaff _Employee;

        //private int _EmployeeID = -1;


        //public void LoadPersonInfo(int _EmployeeID)
        //{
        //    _Employee = clsStaff.Find(_EmployeeID);
        //    if (_Employee == null)
        //    {
        //        ResetPersonInfo();
        //        MessageBox.Show("No Employee with this ID. = " + _EmployeeID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    _FillPersonInfo();
        //}

        private void FillcbEmployeeRole() 
        {

            DataTable dtRols = clsRole.GetAllRols();

            foreach (DataRow row in dtRols.Rows)
            {
                cbEmployeeRole.Items.Add(row["Role"]);
            }



        }



        //private void _FillPersonInfo()
        //{

        //    _EmployeeID = _Employee.EmployeeID;
        //    txbEmployeeName.Text = _Employee.EmployeeName.ToString();
        //    txbEmployeePhone.Text = _Employee.EmployeeName.ToString();

        //    lblAddNewCategory.Text = "Update Category";
        //}





        //public void ResetPersonInfo()
        //{
        //    _CategoryID = -1;
        //    lblCategoryName.Text = "";



        //}

        private void txbCategoryName_TextChanged(object sender, EventArgs e)
        {

        }








        //public void AddNewCategory()
        //{


        //    if (!this.ValidateChildren())
        //    {
        //        //Here we dont continue becuase the form is not valid
        //        MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;

        //    }


        //    clsStaff Employee = new clsStaff();

        //    Employee.EmployeeName = txbEmployeeName.Text.Trim();

        //    Employee.Phone = txbEmployeeName.Text.Trim();





        //    if (!clsCategory.isCategoryExist(txbCategoryName.Text.Trim()))
        //        {
        //            if (Category.Save())
        //            {
        //                MessageBox.Show("Category Save Saccessfuly");



        //            }

        //            if (OnSavingEnd != null)
        //                // Raise the event with a parameter
        //                SavingEnd(Category.CategoryID);




        //        }
        //        else
        //        {

        //            MessageBox.Show("Category Name already exists, try another one ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //        }







        //}

        //public void UpdateCategory(int _CategoryID)
        //{

        //    _Category = clsCategory.Find(_CategoryID);


        //    _Category.CategoryName = txbCategoryName.Text.Trim();
        //    _Category.CategoryID = _CategoryID;


        //    if (_Category != null)
        //    {



        //        if (_Category.Save())
        //        {

        //            MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        }
        //        else
        //            MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        //    }


        //}







        private void cntAddAndUpdateEmployee_Load(object sender, EventArgs e)
        {
            FillcbEmployeeRole();
        }

        private void txbEmployeeName_Validating(object sender, CancelEventArgs e)
        {
            if (txbEmployeeName.Text == "")
            {
                txbEmployeeName.Focus();
                errorProvider1.SetError(txbEmployeeName, "EmployeeName is Emty");
            }
            else
            {
                errorProvider1.SetError(txbEmployeeName, null);
            }
        }

        private void txbEmployeePhone_Validating(object sender, CancelEventArgs e)
        {
            if (txbEmployeePhone.Text == "")
            {
                txbEmployeePhone.Focus();
                errorProvider1.SetError(txbEmployeePhone, "EmployeePhone is Emty");
            }
            else
            {
                errorProvider1.SetError(txbEmployeePhone, null);
            }
        }

        //private void txbEmployeeRole_Validating(object sender, CancelEventArgs e)
        //{
        //    if (txbEmployeeRole.Text == "")
        //    {
        //        txbEmployeeRole.Focus();
        //        errorProvider1.SetError(txbEmployeeRole, "EmployeeRole is Emty");
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txbEmployeeRole, null);
        //    }
        //}
    }
}
