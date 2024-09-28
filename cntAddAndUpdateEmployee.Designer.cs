namespace RestaurantManagementSystem_Project
{
    partial class cntAddAndUpdateEmployee
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txbEmployeeName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddNewCategory = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbEmployeePhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbEmployeeRole = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(11, 126);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(152, 24);
            this.lblEmployeeName.TabIndex = 12;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // txbEmployeeName
            // 
            this.txbEmployeeName.Location = new System.Drawing.Point(11, 161);
            this.txbEmployeeName.Name = "txbEmployeeName";
            this.txbEmployeeName.Size = new System.Drawing.Size(208, 20);
            this.txbEmployeeName.TabIndex = 11;
            this.txbEmployeeName.Validating += new System.ComponentModel.CancelEventHandler(this.txbEmployeeName_Validating);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lblAddNewCategory);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 111);
            this.panel1.TabIndex = 10;
            // 
            // lblAddNewCategory
            // 
            this.lblAddNewCategory.AutoSize = true;
            this.lblAddNewCategory.BackColor = System.Drawing.Color.Navy;
            this.lblAddNewCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewCategory.ForeColor = System.Drawing.Color.White;
            this.lblAddNewCategory.Location = new System.Drawing.Point(123, 37);
            this.lblAddNewCategory.Name = "lblAddNewCategory";
            this.lblAddNewCategory.Size = new System.Drawing.Size(348, 44);
            this.lblAddNewCategory.TabIndex = 1;
            this.lblAddNewCategory.Text = "Add New Employee";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::RestaurantManagementSystem_Project.Properties.Resources.inventory_category__2_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txbEmployeePhone
            // 
            this.txbEmployeePhone.Location = new System.Drawing.Point(249, 161);
            this.txbEmployeePhone.Name = "txbEmployeePhone";
            this.txbEmployeePhone.Size = new System.Drawing.Size(208, 20);
            this.txbEmployeePhone.TabIndex = 14;
            this.txbEmployeePhone.Validating += new System.ComponentModel.CancelEventHandler(this.txbEmployeePhone_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Employee Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Employee Phone";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbEmployeeRole
            // 
            this.cbEmployeeRole.FormattingEnabled = true;
            this.cbEmployeeRole.Location = new System.Drawing.Point(11, 229);
            this.cbEmployeeRole.Name = "cbEmployeeRole";
            this.cbEmployeeRole.Size = new System.Drawing.Size(208, 21);
            this.cbEmployeeRole.TabIndex = 17;
            // 
            // cntAddAndUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbEmployeeRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbEmployeePhone);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.txbEmployeeName);
            this.Controls.Add(this.panel1);
            this.Name = "cntAddAndUpdateEmployee";
            this.Size = new System.Drawing.Size(476, 265);
            this.Load += new System.EventHandler(this.cntAddAndUpdateEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txbEmployeeName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddNewCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbEmployeePhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbEmployeeRole;
    }
}
