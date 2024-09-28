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
    public partial class frmCategoryList : Form
    {
        public frmCategoryList()
        {
            InitializeComponent();
        }



        private static DataTable _dtAllCAtegory = clsCategory.GetAllCategory();







        private DataTable _dtCatagory = _dtAllCAtegory.DefaultView.ToTable(false, "CategoryID", "CategoryName");



        
        private void _RefreshPeoplList()
        {

            txtFilterValue.Focus();
            lblRecordsCount.Text = kryptonDataGridView1.Rows.Count.ToString();

            _dtAllCAtegory = clsCategory.GetAllCategory();

            _dtCatagory = _dtAllCAtegory.DefaultView.ToTable(false, "CategoryID", "CategoryName");

            kryptonDataGridView1.DataSource = _dtCatagory;



            kryptonDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;



        }


        
     


        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "CategoryName";


            if (txtFilterValue.Text.Trim() == "")
            {
                _dtCatagory.DefaultView.RowFilter = "";
                lblRecordsCount.Text = kryptonDataGridView1.Rows.Count.ToString();
                return;
            }
            _dtCatagory.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = kryptonDataGridView1.Rows.Count.ToString();
        }






         

        private void frmCategoryList_Load(object sender, EventArgs e)
        {
            kryptonDataGridView1.DataSource = _dtCatagory;
            txtFilterValue.Focus();
            lblRecordsCount.Text = kryptonDataGridView1.Rows.Count.ToString();

            kryptonDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;




            if (kryptonDataGridView1.Rows.Count > 0)
            {

                kryptonDataGridView1.Columns[0].HeaderText = "Category ID";
                kryptonDataGridView1.Columns[0].Width = 110;

                kryptonDataGridView1.Columns[1].HeaderText = "CategoryName";


                kryptonDataGridView1.Columns[1].Width = 120;



            }

        }

        private void updateCategoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAddAndUpdateCategory frmAddAndUpdateCategory = new frmAddAndUpdateCategory((int)kryptonDataGridView1.CurrentRow.Cells[0].Value);

            frmAddAndUpdateCategory.ShowDialog();
            _RefreshPeoplList();
        }






        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + kryptonDataGridView1.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsCategory.DeleteCategory((int)kryptonDataGridView1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeoplList();
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmAddAndUpdateCategory frmAddAndUpdateCategory = new frmAddAndUpdateCategory();

            frmAddAndUpdateCategory.ShowDialog();
            _RefreshPeoplList();

        }
    }
}
