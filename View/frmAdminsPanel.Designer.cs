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
            txtMonths = new TextBox();
            lblMonths = new Label();
            btnGetPermits = new Button();
            lblTables = new Label();
            btnUsers = new Button();
            btnFishingPermits = new Button();
            btnVessels = new Button();
            btnTickets = new Button();
            btnBestCatchForTheYear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFisheriesAgencyDB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // btncreate
            // 
            btncreate.Location = new Point(561, 177);
            btncreate.Name = "btncreate";
            btncreate.Size = new Size(95, 30);
            btncreate.TabIndex = 2;
            btncreate.Text = "Create ";
            btncreate.UseVisualStyleBackColor = true;
            btncreate.Click += btncreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(457, 177);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(550, 53);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(106, 23);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(550, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(106, 23);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(457, 55);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 21);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(462, 102);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 21);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // dgvFisheriesAgencyDB
            // 
            dgvFisheriesAgencyDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFisheriesAgencyDB.Location = new Point(24, 329);
            dgvFisheriesAgencyDB.Name = "dgvFisheriesAgencyDB";
            dgvFisheriesAgencyDB.RowHeadersWidth = 51;
            dgvFisheriesAgencyDB.RowTemplate.Height = 25;
            dgvFisheriesAgencyDB.Size = new Size(666, 202);
            dgvFisheriesAgencyDB.TabIndex = 10;
            dgvFisheriesAgencyDB.CellClick += dgvFisheriesAgencyDB_CellClick;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(561, 225);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(95, 30);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(457, 225);
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
            cbAdmin.Location = new Point(561, 137);
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
            btnViewPassword.Location = new Point(662, 102);
            btnViewPassword.Name = "btnViewPassword";
            btnViewPassword.Size = new Size(27, 27);
            btnViewPassword.TabIndex = 14;
            btnViewPassword.UseVisualStyleBackColor = false;
            btnViewPassword.Click += btnViewPassword_Click;
            // 
            // txtMonths
            // 
            txtMonths.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonths.Location = new Point(527, 278);
            txtMonths.Name = "txtMonths";
            txtMonths.Size = new Size(62, 36);
            txtMonths.TabIndex = 15;
            // 
            // lblMonths
            // 
            lblMonths.AutoSize = true;
            lblMonths.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonths.Location = new Point(595, 281);
            lblMonths.Name = "lblMonths";
            lblMonths.Size = new Size(95, 30);
            lblMonths.TabIndex = 16;
            lblMonths.Text = "Month/s";
            // 
            // btnGetPermits
            // 
            btnGetPermits.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGetPermits.Location = new Point(429, 281);
            btnGetPermits.Name = "btnGetPermits";
            btnGetPermits.Size = new Size(81, 33);
            btnGetPermits.TabIndex = 17;
            btnGetPermits.Text = "Permits";
            btnGetPermits.UseVisualStyleBackColor = true;
            btnGetPermits.Click += btnGetPermits_Click;
            // 
            // lblTables
            // 
            lblTables.AutoSize = true;
            lblTables.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTables.Location = new Point(173, 35);
            lblTables.Name = "lblTables";
            lblTables.Size = new Size(73, 30);
            lblTables.TabIndex = 18;
            lblTables.Text = "Tables";
            // 
            // btnUsers
            // 
            btnUsers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsers.Location = new Point(36, 81);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(81, 33);
            btnUsers.TabIndex = 19;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnFishingPermits
            // 
            btnFishingPermits.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFishingPermits.Location = new Point(210, 81);
            btnFishingPermits.Name = "btnFishingPermits";
            btnFishingPermits.Size = new Size(81, 33);
            btnFishingPermits.TabIndex = 20;
            btnFishingPermits.Text = "Permits";
            btnFishingPermits.UseVisualStyleBackColor = true;
            btnFishingPermits.Click += btnFishingPermits_Click;
            // 
            // btnVessels
            // 
            btnVessels.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVessels.Location = new Point(123, 81);
            btnVessels.Name = "btnVessels";
            btnVessels.Size = new Size(81, 33);
            btnVessels.TabIndex = 21;
            btnVessels.Text = "Vessels";
            btnVessels.UseVisualStyleBackColor = true;
            btnVessels.Click += btnVessels_Click;
            // 
            // btnTickets
            // 
            btnTickets.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTickets.Location = new Point(297, 81);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(81, 33);
            btnTickets.TabIndex = 22;
            btnTickets.Text = "Tickets";
            btnTickets.UseVisualStyleBackColor = true;
            btnTickets.Click += btnTickets_Click;
            // 
            // btnBestCatchForTheYear
            // 
            btnBestCatchForTheYear.Location = new Point(365, 225);
            btnBestCatchForTheYear.Name = "btnBestCatchForTheYear";
            btnBestCatchForTheYear.Size = new Size(86, 30);
            btnBestCatchForTheYear.TabIndex = 23;
            btnBestCatchForTheYear.Text = "Years Catch";
            btnBestCatchForTheYear.UseVisualStyleBackColor = true;
            btnBestCatchForTheYear.Click += btnBestCatchForTheYear_Click;
            // 
            // frmAdminsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 543);
            Controls.Add(btnBestCatchForTheYear);
            Controls.Add(btnTickets);
            Controls.Add(btnVessels);
            Controls.Add(btnFishingPermits);
            Controls.Add(btnUsers);
            Controls.Add(lblTables);
            Controls.Add(btnGetPermits);
            Controls.Add(lblMonths);
            Controls.Add(txtMonths);
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
        private Button btnGetPermits;
        private Label lblMonths;
        private TextBox txtMonths;
        private Button btnUsers;
        private Label lblTables;
        private Button btnFishingPermits;
        private Button btnVessels;
        private Button btnTickets;
        private Button btnBestCatchForTheYear;
    }
}