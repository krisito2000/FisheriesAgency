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
            btnEdit = new Button();
            lbIPassword = new Label();
            lblUsername = new Label();
            btnDelete = new Button();
            btnCreate = new Button();
            btnViewPassword = new Button();
            cbAdmin = new CheckBox();
            dgvUser = new DataGridView();
            panel2 = new Panel();
            txtUsername = new TextBox();
            panel1 = new Panel();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DimGray;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Aqua;
            btnEdit.Location = new Point(95, 229);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 30);
            btnEdit.TabIndex = 65;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // lbIPassword
            // 
            lbIPassword.AutoSize = true;
            lbIPassword.BackColor = SystemColors.ActiveCaptionText;
            lbIPassword.FlatStyle = FlatStyle.System;
            lbIPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbIPassword.ForeColor = Color.Aqua;
            lbIPassword.Location = new Point(46, 103);
            lbIPassword.Name = "lbIPassword";
            lbIPassword.Size = new Size(82, 21);
            lbIPassword.TabIndex = 64;
            lbIPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = SystemColors.ActiveCaptionText;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.Aqua;
            lblUsername.Location = new Point(41, 56);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 21);
            lblUsername.TabIndex = 63;
            lblUsername.Text = "Username";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DimGray;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Aqua;
            btnDelete.Location = new Point(44, 193);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 60;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DimGray;
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.Aqua;
            btnCreate.Location = new Point(145, 193);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(95, 30);
            btnCreate.TabIndex = 59;
            btnCreate.Text = "Create ";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnViewPassword
            // 
            btnViewPassword.BackColor = Color.DimGray;
            btnViewPassword.BackgroundImage = (Image)resources.GetObject("btnViewPassword.BackgroundImage");
            btnViewPassword.BackgroundImageLayout = ImageLayout.Stretch;
            btnViewPassword.Cursor = Cursors.Hand;
            btnViewPassword.FlatStyle = FlatStyle.Popup;
            btnViewPassword.Location = new Point(246, 97);
            btnViewPassword.Name = "btnViewPassword";
            btnViewPassword.Size = new Size(27, 27);
            btnViewPassword.TabIndex = 66;
            btnViewPassword.UseVisualStyleBackColor = false;
            btnViewPassword.Click += btnViewPassword_Click;
            // 
            // cbAdmin
            // 
            cbAdmin.AutoSize = true;
            cbAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbAdmin.ForeColor = Color.Aqua;
            cbAdmin.Location = new Point(145, 145);
            cbAdmin.Name = "cbAdmin";
            cbAdmin.Size = new Size(80, 25);
            cbAdmin.TabIndex = 67;
            cbAdmin.Text = "Admin";
            cbAdmin.UseVisualStyleBackColor = true;
            // 
            // dgvUser
            // 
            dgvUser.BackgroundColor = Color.Aqua;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(303, 56);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 51;
            dgvUser.RowTemplate.Height = 25;
            dgvUser.Size = new Size(453, 195);
            dgvUser.TabIndex = 68;
            dgvUser.CellClick += dgvUser_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Aqua;
            panel2.Location = new Point(130, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(110, 1);
            panel2.TabIndex = 102;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Black;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(130, 55);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(110, 22);
            txtUsername.TabIndex = 101;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aqua;
            panel1.Location = new Point(130, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(110, 1);
            panel1.TabIndex = 104;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Black;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(130, 103);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(110, 22);
            txtPassword.TabIndex = 103;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 303);
            Controls.Add(panel1);
            Controls.Add(txtPassword);
            Controls.Add(panel2);
            Controls.Add(txtUsername);
            Controls.Add(dgvUser);
            Controls.Add(cbAdmin);
            Controls.Add(btnViewPassword);
            Controls.Add(btnEdit);
            Controls.Add(lbIPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Name = "frmUser";
            Text = "Users";
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Label lbIPassword;
        private Label lblUsername;
        private Button btnDelete;
        private Button btnCreate;
        private Button btnViewPassword;
        private CheckBox cbAdmin;
        private DataGridView dgvUser;
        private Panel panel2;
        private TextBox txtUsername;
        private Panel panel1;
        private TextBox txtPassword;
    }
}