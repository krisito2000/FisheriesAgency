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
            btnLogout = new Button();
            btnCaptains = new Button();
            btnCatches = new Button();
            btnTrips = new Button();
            btnInspector = new Button();
            btnMembers = new Button();
            btnOwners = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtMonths
            // 
            txtMonths.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonths.Location = new Point(525, 229);
            txtMonths.Name = "txtMonths";
            txtMonths.Size = new Size(62, 36);
            txtMonths.TabIndex = 15;
            // 
            // lblMonths
            // 
            lblMonths.AutoSize = true;
            lblMonths.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonths.Location = new Point(594, 232);
            lblMonths.Name = "lblMonths";
            lblMonths.Size = new Size(95, 30);
            lblMonths.TabIndex = 16;
            lblMonths.Text = "Month/s";
            // 
            // btnGetPermits
            // 
            btnGetPermits.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGetPermits.Location = new Point(427, 232);
            btnGetPermits.Name = "btnGetPermits";
            btnGetPermits.Size = new Size(81, 33);
            btnGetPermits.TabIndex = 17;
            btnGetPermits.Text = "Permits";
            btnGetPermits.UseVisualStyleBackColor = true;
            // 
            // lblTables
            // 
            lblTables.AutoSize = true;
            lblTables.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTables.Location = new Point(199, 34);
            lblTables.Name = "lblTables";
            lblTables.Size = new Size(73, 30);
            lblTables.TabIndex = 18;
            lblTables.Text = "Tables";
            // 
            // btnUsers
            // 
            btnUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsers.Location = new Point(38, 80);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(94, 33);
            btnUsers.TabIndex = 19;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnFishingPermits
            // 
            btnFishingPermits.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFishingPermits.Location = new Point(235, 80);
            btnFishingPermits.Name = "btnFishingPermits";
            btnFishingPermits.Size = new Size(94, 33);
            btnFishingPermits.TabIndex = 20;
            btnFishingPermits.Text = "Permits";
            btnFishingPermits.UseVisualStyleBackColor = true;
            btnFishingPermits.Click += btnFishingPermits_Click;
            // 
            // btnVessels
            // 
            btnVessels.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVessels.Location = new Point(136, 80);
            btnVessels.Name = "btnVessels";
            btnVessels.Size = new Size(94, 33);
            btnVessels.TabIndex = 21;
            btnVessels.Text = "Vessels";
            btnVessels.UseVisualStyleBackColor = true;
            btnVessels.Click += btnVessels_Click;
            // 
            // btnTickets
            // 
            btnTickets.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTickets.Location = new Point(334, 80);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(94, 33);
            btnTickets.TabIndex = 22;
            btnTickets.Text = "Tickets";
            btnTickets.UseVisualStyleBackColor = true;
            btnTickets.Click += btnTickets_Click;
            // 
            // btnBestCatchForTheYear
            // 
            btnBestCatchForTheYear.Location = new Point(502, 271);
            btnBestCatchForTheYear.Name = "btnBestCatchForTheYear";
            btnBestCatchForTheYear.Size = new Size(86, 30);
            btnBestCatchForTheYear.TabIndex = 23;
            btnBestCatchForTheYear.Text = "Years Catch";
            btnBestCatchForTheYear.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(184, 231);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 36);
            btnLogout.TabIndex = 25;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnCaptains
            // 
            btnCaptains.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCaptains.Location = new Point(38, 129);
            btnCaptains.Name = "btnCaptains";
            btnCaptains.Size = new Size(94, 33);
            btnCaptains.TabIndex = 26;
            btnCaptains.Text = "Captains";
            btnCaptains.UseVisualStyleBackColor = true;
            btnCaptains.Click += btnCaptains_Click;
            // 
            // btnCatches
            // 
            btnCatches.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCatches.Location = new Point(136, 129);
            btnCatches.Name = "btnCatches";
            btnCatches.Size = new Size(94, 33);
            btnCatches.TabIndex = 27;
            btnCatches.Text = "Catches";
            btnCatches.UseVisualStyleBackColor = true;
            btnCatches.Click += btnCatches_Click;
            // 
            // btnTrips
            // 
            btnTrips.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTrips.Location = new Point(235, 129);
            btnTrips.Name = "btnTrips";
            btnTrips.Size = new Size(94, 33);
            btnTrips.TabIndex = 28;
            btnTrips.Text = "Trips";
            btnTrips.UseVisualStyleBackColor = true;
            btnTrips.Click += btnTrips_Click;
            // 
            // btnInspector
            // 
            btnInspector.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInspector.Location = new Point(334, 129);
            btnInspector.Name = "btnInspector";
            btnInspector.Size = new Size(94, 33);
            btnInspector.TabIndex = 29;
            btnInspector.Text = "Inspector";
            btnInspector.UseVisualStyleBackColor = true;
            btnInspector.Click += btnInspector_Click;
            // 
            // btnMembers
            // 
            btnMembers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMembers.Location = new Point(136, 177);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(94, 33);
            btnMembers.TabIndex = 30;
            btnMembers.Text = "Members";
            btnMembers.UseVisualStyleBackColor = true;
            btnMembers.Click += btnMembers_Click;
            // 
            // btnOwners
            // 
            btnOwners.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOwners.Location = new Point(235, 177);
            btnOwners.Name = "btnOwners";
            btnOwners.Size = new Size(94, 33);
            btnOwners.TabIndex = 31;
            btnOwners.Text = "Owners";
            btnOwners.UseVisualStyleBackColor = true;
            btnOwners.Click += btnOwners_Click;
            // 
            // frmAdminsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 326);
            Controls.Add(btnOwners);
            Controls.Add(btnMembers);
            Controls.Add(btnInspector);
            Controls.Add(btnTrips);
            Controls.Add(btnCatches);
            Controls.Add(btnCaptains);
            Controls.Add(btnLogout);
            Controls.Add(btnBestCatchForTheYear);
            Controls.Add(btnTickets);
            Controls.Add(btnVessels);
            Controls.Add(btnFishingPermits);
            Controls.Add(btnUsers);
            Controls.Add(lblTables);
            Controls.Add(btnGetPermits);
            Controls.Add(lblMonths);
            Controls.Add(txtMonths);
            Name = "frmAdminsPanel";
            Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button btnLogout;
        private Button btnOwners;
        private Button btnMembers;
        private Button btnInspector;
        private Button btnTrips;
        private Button btnCatches;
        private Button btnCaptains;
    }
}