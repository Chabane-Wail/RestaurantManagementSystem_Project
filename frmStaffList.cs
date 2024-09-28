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
    public partial class frmStaffList : Form
    {


        private static DataTable _dtAllStaff = clsStaff.GetAllStaff();




        private DataTable _dtStaff = _dtAllStaff.DefaultView.ToTable(false, "EmployeeName", "Phone", "Role");




        private void _RefreshPeoplList()
        {

            txtFilterValue.Focus();
            lblRecordsCount.Text = kryptonDataGridView1.Rows.Count.ToString();

            _dtAllStaff = clsStaff.GetAllStaff();

            _dtStaff = _dtAllStaff.DefaultView.ToTable(false, "EmployeeName", "Phone", "Role");

            kryptonDataGridView1.DataSource = _dtStaff;



            kryptonDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;



        }


        //private void button1_Click(object sender, EventArgs e)
        //{


        //    frmAddNewCategory frmAddNewCategory = new frmAddNewCategory();

        //    frmAddNewCategory.ShowDialog();
        //    _RefreshPeoplList();


        //}





        //private void updateCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmAddNewCategory frmAddNewCategory = new frmAddNewCategory((int)kryptonDataGridView1.CurrentRow.Cells[0].Value);

        //    frmAddNewCategory.ShowDialog();
        //    _RefreshPeoplList();
        //}

       




 

        private void frmStaffList_Load(object sender, EventArgs e)
        {
            kryptonDataGridView1.DataSource = _dtStaff;
            txtFilterValue.Focus();
            lblRecordsCount.Text = kryptonDataGridView1.Rows.Count.ToString();

            kryptonDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;

            if (kryptonDataGridView1.Rows.Count > 0)
            {

                kryptonDataGridView1.Columns[0].HeaderText = "EmployeeName";
                kryptonDataGridView1.Columns[0].Width = 110;

                kryptonDataGridView1.Columns[1].HeaderText = "Phone";
                kryptonDataGridView1.Columns[1].Width = 120;

                kryptonDataGridView1.Columns[1].HeaderText = "Role";
                kryptonDataGridView1.Columns[1].Width = 120;

            }

        }





        public frmStaffList()
        {
            InitializeComponent();
        }


        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "EmployeeName";


            if (txtFilterValue.Text.Trim() == "")
            {
                _dtStaff.DefaultView.RowFilter = "";
                lblRecordsCount.Text = kryptonDataGridView1.Rows.Count.ToString();
                return;
            }
            _dtStaff.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = kryptonDataGridView1.Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void updateCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {







        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete Person [" + kryptonDataGridView1.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsStaff.DeleteEmployee((string)kryptonDataGridView1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeoplList();
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
