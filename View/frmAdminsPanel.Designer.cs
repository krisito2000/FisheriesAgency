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
            lblTables.BackColor = SystemColors.ActiveCaptionText;
            lblTables.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTables.ForeColor = Color.Aqua;
            lblTables.Location = new Point(203, 30);
            lblTables.Name = "lblTables";
            lblTables.Size = new Size(85, 32);
            lblTables.TabIndex = 18;
            lblTables.Text = "Tables";
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.DimGray;
            btnUsers.Cursor = Cursors.Hand;
            btnUsers.FlatStyle = FlatStyle.Popup;
            btnUsers.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsers.ForeColor = Color.Aqua;
            btnUsers.Location = new Point(48, 82);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(94, 33);
            btnUsers.TabIndex = 19;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnFishingPermits
            // 
            btnFishingPermits.BackColor = Color.DimGray;
            btnFishingPermits.Cursor = Cursors.Hand;
            btnFishingPermits.FlatStyle = FlatStyle.Popup;
            btnFishingPermits.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnFishingPermits.ForeColor = Color.Aqua;
            btnFishingPermits.Location = new Point(245, 82);
            btnFishingPermits.Name = "btnFishingPermits";
            btnFishingPermits.Size = new Size(94, 33);
            btnFishingPermits.TabIndex = 20;
            btnFishingPermits.Text = "Permits";
            btnFishingPermits.UseVisualStyleBackColor = false;
            btnFishingPermits.Click += btnFishingPermits_Click;
            // 
            // btnVessels
            // 
            btnVessels.BackColor = Color.DimGray;
            btnVessels.Cursor = Cursors.Hand;
            btnVessels.FlatStyle = FlatStyle.Popup;
            btnVessels.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnVessels.ForeColor = Color.Aqua;
            btnVessels.Location = new Point(146, 82);
            btnVessels.Name = "btnVessels";
            btnVessels.Size = new Size(94, 33);
            btnVessels.TabIndex = 21;
            btnVessels.Text = "Vessels";
            btnVessels.UseVisualStyleBackColor = false;
            btnVessels.Click += btnVessels_Click;
            // 
            // btnTickets
            // 
            btnTickets.BackColor = Color.DimGray;
            btnTickets.Cursor = Cursors.Hand;
            btnTickets.FlatStyle = FlatStyle.Popup;
            btnTickets.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnTickets.ForeColor = Color.Aqua;
            btnTickets.Location = new Point(344, 82);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(94, 33);
            btnTickets.TabIndex = 22;
            btnTickets.Text = "Tickets";
            btnTickets.UseVisualStyleBackColor = false;
            btnTickets.Click += btnTickets_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DimGray;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Aqua;
            btnLogout.Location = new Point(194, 214);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 36);
            btnLogout.TabIndex = 25;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnCaptains
            // 
            btnCaptains.BackColor = Color.DimGray;
            btnCaptains.Cursor = Cursors.Hand;
            btnCaptains.FlatStyle = FlatStyle.Popup;
            btnCaptains.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnCaptains.ForeColor = Color.Aqua;
            btnCaptains.Location = new Point(48, 123);
            btnCaptains.Name = "btnCaptains";
            btnCaptains.Size = new Size(94, 33);
            btnCaptains.TabIndex = 26;
            btnCaptains.Text = "Captains";
            btnCaptains.UseVisualStyleBackColor = false;
            btnCaptains.Click += btnCaptains_Click;
            // 
            // btnCatches
            // 
            btnCatches.BackColor = Color.DimGray;
            btnCatches.Cursor = Cursors.Hand;
            btnCatches.FlatStyle = FlatStyle.Popup;
            btnCatches.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnCatches.ForeColor = Color.Aqua;
            btnCatches.Location = new Point(146, 123);
            btnCatches.Name = "btnCatches";
            btnCatches.Size = new Size(94, 33);
            btnCatches.TabIndex = 27;
            btnCatches.Text = "Catches";
            btnCatches.UseVisualStyleBackColor = false;
            btnCatches.Click += btnCatches_Click;
            // 
            // btnTrips
            // 
            btnTrips.BackColor = Color.DimGray;
            btnTrips.Cursor = Cursors.Hand;
            btnTrips.FlatStyle = FlatStyle.Popup;
            btnTrips.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrips.ForeColor = Color.Aqua;
            btnTrips.Location = new Point(245, 123);
            btnTrips.Name = "btnTrips";
            btnTrips.Size = new Size(94, 33);
            btnTrips.TabIndex = 28;
            btnTrips.Text = "Trips";
            btnTrips.UseVisualStyleBackColor = false;
            btnTrips.Click += btnTrips_Click;
            // 
            // btnInspector
            // 
            btnInspector.BackColor = Color.DimGray;
            btnInspector.Cursor = Cursors.Hand;
            btnInspector.FlatStyle = FlatStyle.Popup;
            btnInspector.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnInspector.ForeColor = Color.Aqua;
            btnInspector.Location = new Point(344, 123);
            btnInspector.Name = "btnInspector";
            btnInspector.Size = new Size(94, 33);
            btnInspector.TabIndex = 29;
            btnInspector.Text = "Inspector";
            btnInspector.UseVisualStyleBackColor = false;
            btnInspector.Click += btnInspector_Click;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = Color.DimGray;
            btnMembers.Cursor = Cursors.Hand;
            btnMembers.FlatStyle = FlatStyle.Popup;
            btnMembers.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnMembers.ForeColor = Color.Aqua;
            btnMembers.Location = new Point(95, 162);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(94, 33);
            btnMembers.TabIndex = 30;
            btnMembers.Text = "Members";
            btnMembers.UseVisualStyleBackColor = false;
            btnMembers.Click += btnMembers_Click;
            // 
            // btnOwners
            // 
            btnOwners.BackColor = Color.DimGray;
            btnOwners.Cursor = Cursors.Hand;
            btnOwners.FlatStyle = FlatStyle.Popup;
            btnOwners.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnOwners.ForeColor = Color.Aqua;
            btnOwners.Location = new Point(194, 162);
            btnOwners.Name = "btnOwners";
            btnOwners.Size = new Size(94, 33);
            btnOwners.TabIndex = 31;
            btnOwners.Text = "Owners";
            btnOwners.UseVisualStyleBackColor = false;
            btnOwners.Click += btnOwners_Click;
            // 
            // btnOther
            // 
            btnOther.BackColor = Color.DimGray;
            btnOther.Cursor = Cursors.Hand;
            btnOther.FlatStyle = FlatStyle.Popup;
            btnOther.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnOther.ForeColor = Color.Aqua;
            btnOther.Location = new Point(294, 162);
            btnOther.Name = "btnOther";
            btnOther.Size = new Size(94, 33);
            btnOther.TabIndex = 32;
            btnOther.Text = "Other";
            btnOther.UseVisualStyleBackColor = false;
            btnOther.Click += btnOther_Click;
            // 
            // frmAdminsPanel
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(485, 282);
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
            MinimizeBox = false;
            Name = "frmAdminsPanel";
            StartPosition = FormStartPosition.CenterParent;
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