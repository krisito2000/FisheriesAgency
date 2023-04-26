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
            dgvFisheriesAgencyDB = new DataGridView();
            fileSystemWatcher1 = new FileSystemWatcher();
            txtMonths = new TextBox();
            lblMonths = new Label();
            btnGetPermits = new Button();
            lblTables = new Label();
            btnUsers = new Button();
            btnFishingPermits = new Button();
            btnVessels = new Button();
            btnTickets = new Button();
            btnBestCatchForTheYear = new Button();
            btn = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFisheriesAgencyDB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
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
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
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
            btnBestCatchForTheYear.Location = new Point(316, 278);
            btnBestCatchForTheYear.Name = "btnBestCatchForTheYear";
            btnBestCatchForTheYear.Size = new Size(86, 30);
            btnBestCatchForTheYear.TabIndex = 23;
            btnBestCatchForTheYear.Text = "Years Catch";
            btnBestCatchForTheYear.UseVisualStyleBackColor = true;
            btnBestCatchForTheYear.Click += btnBestCatchForTheYear_Click;
            // 
            // btn
            // 
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn.Location = new Point(36, 129);
            btn.Name = "btn";
            btn.Size = new Size(81, 33);
            btn.TabIndex = 24;
            btn.Text = "Test";
            btn.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(173, 281);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(95, 30);
            btnLogout.TabIndex = 25;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // frmAdminsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 543);
            Controls.Add(btnLogout);
            Controls.Add(btn);
            Controls.Add(btnBestCatchForTheYear);
            Controls.Add(btnTickets);
            Controls.Add(btnVessels);
            Controls.Add(btnFishingPermits);
            Controls.Add(btnUsers);
            Controls.Add(lblTables);
            Controls.Add(btnGetPermits);
            Controls.Add(lblMonths);
            Controls.Add(txtMonths);
            Controls.Add(dgvFisheriesAgencyDB);
            Name = "frmAdminsPanel";
            Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)dgvFisheriesAgencyDB).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvFisheriesAgencyDB;
        private FileSystemWatcher fileSystemWatcher1;
        private Button btnGetPermits;
        private Label lblMonths;
        private TextBox txtMonths;
        private Button btnUsers;
        private Label lblTables;
        private Button btnFishingPermits;
        private Button btnVessels;
        private Button btnTickets;
        private Button btnBestCatchForTheYear;
        private Button btn;
        private Button btnLogout;
    }
}