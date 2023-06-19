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
            // btnUsers
            // 
            btnUsers.BackColor = Color.DimGray;
            btnUsers.Cursor = Cursors.Hand;
            btnUsers.FlatStyle = FlatStyle.Popup;
            btnUsers.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsers.ForeColor = Color.Aqua;
            btnUsers.Location = new Point(46, 39);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(94, 33);
            btnUsers.TabIndex = 0;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            btnUsers.Enter += btnUsers_Enter;
            btnUsers.Leave += btnUsers_Leave;
            btnUsers.MouseEnter += btnUsers_MouseEnter;
            btnUsers.MouseLeave += btnUsers_MouseLeave;
            // 
            // btnFishingPermits
            // 
            btnFishingPermits.BackColor = Color.DimGray;
            btnFishingPermits.Cursor = Cursors.Hand;
            btnFishingPermits.FlatStyle = FlatStyle.Popup;
            btnFishingPermits.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnFishingPermits.ForeColor = Color.Aqua;
            btnFishingPermits.Location = new Point(245, 39);
            btnFishingPermits.Name = "btnFishingPermits";
            btnFishingPermits.Size = new Size(94, 33);
            btnFishingPermits.TabIndex = 2;
            btnFishingPermits.Text = "Permits";
            btnFishingPermits.UseVisualStyleBackColor = false;
            btnFishingPermits.Click += btnFishingPermits_Click;
            btnFishingPermits.Enter += btnFishingPermits_Enter;
            btnFishingPermits.Leave += btnFishingPermits_Leave;
            btnFishingPermits.MouseEnter += btnFishingPermits_MouseEnter;
            btnFishingPermits.MouseLeave += btnFishingPermits_MouseLeave;
            // 
            // btnVessels
            // 
            btnVessels.BackColor = Color.DimGray;
            btnVessels.Cursor = Cursors.Hand;
            btnVessels.FlatStyle = FlatStyle.Popup;
            btnVessels.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnVessels.ForeColor = Color.Aqua;
            btnVessels.Location = new Point(146, 39);
            btnVessels.Name = "btnVessels";
            btnVessels.Size = new Size(94, 33);
            btnVessels.TabIndex = 1;
            btnVessels.Text = "Vessels";
            btnVessels.UseVisualStyleBackColor = false;
            btnVessels.Click += btnVessels_Click;
            btnVessels.Enter += btnVessels_Enter;
            btnVessels.Leave += btnVessels_Leave;
            btnVessels.MouseEnter += btnVessels_MouseEnter;
            btnVessels.MouseLeave += btnVessels_MouseLeave;
            // 
            // btnTickets
            // 
            btnTickets.BackColor = Color.DimGray;
            btnTickets.Cursor = Cursors.Hand;
            btnTickets.FlatStyle = FlatStyle.Popup;
            btnTickets.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnTickets.ForeColor = Color.Aqua;
            btnTickets.Location = new Point(345, 39);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(94, 33);
            btnTickets.TabIndex = 3;
            btnTickets.Text = "Tickets";
            btnTickets.UseVisualStyleBackColor = false;
            btnTickets.Click += btnTickets_Click;
            btnTickets.Enter += btnTickets_Enter;
            btnTickets.Leave += btnTickets_Leave;
            btnTickets.MouseEnter += btnTickets_MouseEnter;
            btnTickets.MouseLeave += btnTickets_MouseLeave;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DimGray;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Aqua;
            btnLogout.Location = new Point(203, 173);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(79, 27);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            btnLogout.Enter += btnLogout_Enter;
            btnLogout.Leave += btnLogout_Leave;
            btnLogout.MouseEnter += btnLogout_MouseEnter;
            btnLogout.MouseLeave += btnLogout_MouseLeave;
            // 
            // btnCaptains
            // 
            btnCaptains.BackColor = Color.DimGray;
            btnCaptains.Cursor = Cursors.Hand;
            btnCaptains.FlatStyle = FlatStyle.Popup;
            btnCaptains.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnCaptains.ForeColor = Color.Aqua;
            btnCaptains.Location = new Point(48, 80);
            btnCaptains.Name = "btnCaptains";
            btnCaptains.Size = new Size(94, 33);
            btnCaptains.TabIndex = 4;
            btnCaptains.Text = "Captains";
            btnCaptains.UseVisualStyleBackColor = false;
            btnCaptains.Click += btnCaptains_Click;
            btnCaptains.Enter += btnCaptains_Enter;
            btnCaptains.Leave += btnCaptains_Leave;
            btnCaptains.MouseEnter += btnCaptains_MouseEnter;
            btnCaptains.MouseLeave += btnCaptains_MouseLeave;
            // 
            // btnCatches
            // 
            btnCatches.BackColor = Color.DimGray;
            btnCatches.Cursor = Cursors.Hand;
            btnCatches.FlatStyle = FlatStyle.Popup;
            btnCatches.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnCatches.ForeColor = Color.Aqua;
            btnCatches.Location = new Point(146, 80);
            btnCatches.Name = "btnCatches";
            btnCatches.Size = new Size(94, 33);
            btnCatches.TabIndex = 5;
            btnCatches.Text = "Catches";
            btnCatches.UseVisualStyleBackColor = false;
            btnCatches.Click += btnCatches_Click;
            btnCatches.Enter += btnCatches_Enter;
            btnCatches.Leave += btnCatches_Leave;
            btnCatches.MouseEnter += btnCatches_MouseEnter;
            btnCatches.MouseLeave += btnCatches_MouseLeave;
            // 
            // btnTrips
            // 
            btnTrips.BackColor = Color.DimGray;
            btnTrips.Cursor = Cursors.Hand;
            btnTrips.FlatStyle = FlatStyle.Popup;
            btnTrips.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrips.ForeColor = Color.Aqua;
            btnTrips.Location = new Point(245, 80);
            btnTrips.Name = "btnTrips";
            btnTrips.Size = new Size(94, 33);
            btnTrips.TabIndex = 6;
            btnTrips.Text = "Trips";
            btnTrips.UseVisualStyleBackColor = false;
            btnTrips.Click += btnTrips_Click;
            btnTrips.Enter += btnTrips_Enter;
            btnTrips.Leave += btnTrips_Leave;
            btnTrips.MouseEnter += btnTrips_MouseEnter;
            btnTrips.MouseLeave += btnTrips_MouseLeave;
            // 
            // btnInspector
            // 
            btnInspector.BackColor = Color.DimGray;
            btnInspector.Cursor = Cursors.Hand;
            btnInspector.FlatStyle = FlatStyle.Popup;
            btnInspector.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnInspector.ForeColor = Color.Aqua;
            btnInspector.Location = new Point(344, 80);
            btnInspector.Name = "btnInspector";
            btnInspector.Size = new Size(94, 33);
            btnInspector.TabIndex = 7;
            btnInspector.Text = "Inspector";
            btnInspector.UseVisualStyleBackColor = false;
            btnInspector.Click += btnInspector_Click;
            btnInspector.Enter += btnInspector_Enter;
            btnInspector.Leave += btnInspector_Leave;
            btnInspector.MouseEnter += btnInspector_MouseEnter;
            btnInspector.MouseLeave += btnInspector_MouseLeave;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = Color.DimGray;
            btnMembers.Cursor = Cursors.Hand;
            btnMembers.FlatStyle = FlatStyle.Popup;
            btnMembers.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnMembers.ForeColor = Color.Aqua;
            btnMembers.Location = new Point(95, 119);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(94, 33);
            btnMembers.TabIndex = 8;
            btnMembers.Text = "Members";
            btnMembers.UseVisualStyleBackColor = false;
            btnMembers.Click += btnMembers_Click;
            btnMembers.Enter += btnMembers_Enter;
            btnMembers.Leave += btnMembers_Leave;
            btnMembers.MouseEnter += btnMembers_MouseEnter;
            btnMembers.MouseLeave += btnMembers_MouseLeave;
            // 
            // btnOwners
            // 
            btnOwners.BackColor = Color.DimGray;
            btnOwners.Cursor = Cursors.Hand;
            btnOwners.FlatStyle = FlatStyle.Popup;
            btnOwners.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnOwners.ForeColor = Color.Aqua;
            btnOwners.Location = new Point(194, 119);
            btnOwners.Name = "btnOwners";
            btnOwners.Size = new Size(94, 33);
            btnOwners.TabIndex = 9;
            btnOwners.Text = "Owners";
            btnOwners.UseVisualStyleBackColor = false;
            btnOwners.Click += btnOwners_Click;
            btnOwners.Enter += btnOwners_Enter;
            btnOwners.Leave += btnOwners_Leave;
            btnOwners.MouseEnter += btnOwners_MouseEnter;
            btnOwners.MouseLeave += btnOwners_MouseLeave;
            // 
            // btnOther
            // 
            btnOther.BackColor = Color.DimGray;
            btnOther.Cursor = Cursors.Hand;
            btnOther.FlatStyle = FlatStyle.Popup;
            btnOther.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnOther.ForeColor = Color.Aqua;
            btnOther.Location = new Point(294, 119);
            btnOther.Name = "btnOther";
            btnOther.Size = new Size(94, 33);
            btnOther.TabIndex = 10;
            btnOther.Text = "Other";
            btnOther.UseVisualStyleBackColor = false;
            btnOther.Click += btnOther_Click;
            btnOther.Enter += btnOther_Enter;
            btnOther.Leave += btnOther_Leave;
            btnOther.MouseEnter += btnOther_MouseEnter;
            btnOther.MouseLeave += btnOther_MouseLeave;
            // 
            // frmAdminsPanel
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(485, 238);
            ControlBox = false;
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmAdminsPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FileSystemWatcher fileSystemWatcher1;
        private Button btnUsers;
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