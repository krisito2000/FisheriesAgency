namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    partial class frmUser
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbIPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.btnViewPassword = new System.Windows.Forms.Button();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(109, 305);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 40);
            this.btnEdit.TabIndex = 65;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lbIPassword
            // 
            this.lbIPassword.AutoSize = true;
            this.lbIPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbIPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbIPassword.Location = new System.Drawing.Point(53, 137);
            this.lbIPassword.Name = "lbIPassword";
            this.lbIPassword.Size = new System.Drawing.Size(101, 28);
            this.lbIPassword.TabIndex = 64;
            this.lbIPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(47, 75);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(106, 28);
            this.lblUsername.TabIndex = 63;
            this.lblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(153, 135);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(121, 27);
            this.txtPassword.TabIndex = 62;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(153, 77);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(121, 27);
            this.txtUsername.TabIndex = 61;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(50, 257);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 40);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(166, 257);
            this.btncreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(109, 40);
            this.btncreate.TabIndex = 59;
            this.btncreate.Text = "Create ";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnViewPassword
            // 
            this.btnViewPassword.BackColor = System.Drawing.Color.DimGray;
            this.btnViewPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewPassword.BackgroundImage")));
            this.btnViewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewPassword.Location = new System.Drawing.Point(281, 129);
            this.btnViewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewPassword.Name = "btnViewPassword";
            this.btnViewPassword.Size = new System.Drawing.Size(31, 36);
            this.btnViewPassword.TabIndex = 66;
            this.btnViewPassword.UseVisualStyleBackColor = false;
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbAdmin.Location = new System.Drawing.Point(166, 193);
            this.cbAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(96, 32);
            this.cbAdmin.TabIndex = 67;
            this.cbAdmin.Text = "Admin";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(346, 75);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 25;
            this.dgvUser.Size = new System.Drawing.Size(505, 260);
            this.dgvUser.TabIndex = 68;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 404);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.btnViewPassword);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbIPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btncreate);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUser";
            this.Text = "frmUser";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEdit;
        private Label lbIPassword;
        private Label lblUsername;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnDelete;
        private Button btncreate;
        private Button btnViewPassword;
        private CheckBox cbAdmin;
        private DataGridView dgvUser;
    }
}