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
            lblTables = new Label();
            btnUsers = new Button();
            btnFishingPermits = new Button();
            btnVessels = new Button();
            btnTickets = new Button();
            btnLogout = new Button();
            btnCaptains = new Button();
            btnCatches = new Button();
            btnTrips = new Button();
            btnInspector = new Button();
            btnMembers = new Button();
            btnOwners = new Button();
            btnOther = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblTables
            // 
            lblTables.AutoSize = true;
            lblTables.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTables.Location = new Point(194, 34);
            lblTables.Name = "lblTables";
            lblTables.Size = new Size(73, 30);
            lblTables.TabIndex = 18;
            lblTables.Text = "Tables";
            // 
            // btnUsers
            // 
            btnUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsers.Location = new Point(48, 82);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(94, 33);
            btnUsers.TabIndex = 19;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnFishingPermits
            // 
            btnFishingPermits.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFishingPermits.Location = new Point(245, 82);
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
            btnVessels.Location = new Point(146, 82);
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
            btnTickets.Location = new Point(344, 82);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(94, 33);
            btnTickets.TabIndex = 22;
            btnTickets.Text = "Tickets";
            btnTickets.UseVisualStyleBackColor = true;
            btnTickets.Click += btnTickets_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(194, 233);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 36);
            btnLogout.TabIndex = 25;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnCaptains
            // 
            btnCaptains.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCaptains.Location = new Point(48, 131);
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
            btnCatches.Location = new Point(146, 131);
            btnCatches.Name = "btnCatches";
            btnCatches.Size = new Size(94, 33);
            btnCatches.TabIndex = 27;
            btnCatches.Text = "Catches";
            btnCatches.UseVisualStyleBackColor = true;
            btnCatches.Click += btnCatches_Click;
            // 
            // btnTrips
            // 
            btnTrips.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrips.Location = new Point(245, 131);
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
            btnInspector.Location = new Point(344, 131);
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
            btnMembers.Location = new Point(95, 170);
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
            btnOwners.Location = new Point(194, 170);
            btnOwners.Name = "btnOwners";
            btnOwners.Size = new Size(94, 33);
            btnOwners.TabIndex = 31;
            btnOwners.Text = "Owners";
            btnOwners.UseVisualStyleBackColor = true;
            btnOwners.Click += btnOwners_Click;
            // 
            // btnOther
            // 
            btnOther.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOther.Location = new Point(294, 170);
            btnOther.Name = "btnOther";
            btnOther.Size = new Size(94, 33);
            btnOther.TabIndex = 32;
            btnOther.Text = "Other";
            btnOther.UseVisualStyleBackColor = true;
            btnOther.Click += btnOther_Click;
            // 
            // frmAdminsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(506, 312);
            Controls.Add(btnOther);
            Controls.Add(btnOwners);
            Controls.Add(btnMembers);
            Controls.Add(btnInspector);
            Controls.Add(btnTrips);
            Controls.Add(btnCatches);
            Controls.Add(btnCaptains);
            Controls.Add(btnLogout);
            Controls.Add(btnTickets);
            Controls.Add(btnVessels);
            Controls.Add(btnFishingPermits);
            Controls.Add(btnUsers);
            Controls.Add(lblTables);
            Name = "frmAdminsPanel";
            Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FileSystemWatcher fileSystemWatcher1;
        private Button btnUsers;
        private Label lblTables;
        private Button btnFishingPermits;
        private Button btnVessels;
        private Button btnTickets;
        private Button btnLogout;
        private Button btnOwners;
        private Button btnMembers;
        private Button btnInspector;
        private Button btnTrips;
        private Button btnCatches;
        private Button btnCaptains;
        private Button btnOther;
    }
}