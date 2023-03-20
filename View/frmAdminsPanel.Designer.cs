namespace FisheriesAgency.View
{
    partial class frmAdminsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminsPanel));
            btncreate = new Button();
            btnDelete = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            dgvFisheriesAgencyDB = new DataGridView();
            btnLogout = new Button();
            btnEdit = new Button();
            cbAdmin = new CheckBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            btnViewPassword = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFisheriesAgencyDB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // btncreate
            // 
            btncreate.Location = new Point(568, 154);
            btncreate.Name = "btncreate";
            btncreate.Size = new Size(95, 30);
            btncreate.TabIndex = 2;
            btncreate.Text = "Create ";
            btncreate.UseVisualStyleBackColor = true;
            btncreate.Click += btncreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(464, 154);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(557, 39);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(106, 23);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(557, 86);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(106, 23);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(464, 41);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 21);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(469, 88);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 21);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // dgvFisheriesAgencyDB
            // 
            dgvFisheriesAgencyDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFisheriesAgencyDB.Location = new Point(62, 39);
            dgvFisheriesAgencyDB.Name = "dgvFisheriesAgencyDB";
            dgvFisheriesAgencyDB.RowHeadersWidth = 51;
            dgvFisheriesAgencyDB.RowTemplate.Height = 25;
            dgvFisheriesAgencyDB.Size = new Size(349, 202);
            dgvFisheriesAgencyDB.TabIndex = 10;
            dgvFisheriesAgencyDB.CellClick += dgvFisheriesAgencyDB_CellClick;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(568, 213);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(95, 30);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(464, 213);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 30);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cbAdmin
            // 
            cbAdmin.AutoSize = true;
            cbAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbAdmin.Location = new Point(568, 123);
            cbAdmin.Name = "cbAdmin";
            cbAdmin.Size = new Size(75, 25);
            cbAdmin.TabIndex = 13;
            cbAdmin.Text = "Admin";
            cbAdmin.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnViewPassword
            // 
            btnViewPassword.BackColor = Color.DimGray;
            btnViewPassword.BackgroundImage = (Image)resources.GetObject("btnViewPassword.BackgroundImage");
            btnViewPassword.BackgroundImageLayout = ImageLayout.Stretch;
            btnViewPassword.Cursor = Cursors.Hand;
            btnViewPassword.FlatStyle = FlatStyle.Popup;
            btnViewPassword.ForeColor = Color.Black;
            btnViewPassword.Location = new Point(669, 88);
            btnViewPassword.Name = "btnViewPassword";
            btnViewPassword.Size = new Size(27, 27);
            btnViewPassword.TabIndex = 14;
            btnViewPassword.UseVisualStyleBackColor = false;
            btnViewPassword.Click += btnViewPassword_Click;
            // 
            // frmAdminsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 281);
            Controls.Add(btnViewPassword);
            Controls.Add(cbAdmin);
            Controls.Add(btnEdit);
            Controls.Add(btnLogout);
            Controls.Add(dgvFisheriesAgencyDB);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnDelete);
            Controls.Add(btncreate);
            Name = "frmAdminsPanel";
            Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)dgvFisheriesAgencyDB).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btncreate;
        private Button btnDelete;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private DataGridView dgvFisheriesAgencyDB;
        private Button btnLogout;
        private Button btnEdit;
        private CheckBox cbAdmin;
        private FileSystemWatcher fileSystemWatcher1;
        private Button btnViewPassword;
    }
}