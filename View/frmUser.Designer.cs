namespace FisheriesAgency.View
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
            btnLogout = new Button();
            dgvTickets = new DataGridView();
            btnMyTickets = new Button();
            btnStore = new Button();
            lblTickets = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DimGray;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.ForeColor = Color.Aqua;
            btnLogout.Location = new Point(70, 214);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(64, 28);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvTickets
            // 
            dgvTickets.BackgroundColor = Color.Aqua;
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Location = new Point(215, 87);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.RowTemplate.Height = 25;
            dgvTickets.Size = new Size(325, 192);
            dgvTickets.TabIndex = 14;
            dgvTickets.CellClick += dgvTickets_CellClick;
            // 
            // btnMyTickets
            // 
            btnMyTickets.BackColor = Color.DimGray;
            btnMyTickets.Cursor = Cursors.Hand;
            btnMyTickets.FlatStyle = FlatStyle.Popup;
            btnMyTickets.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMyTickets.ForeColor = Color.Aqua;
            btnMyTickets.Location = new Point(50, 156);
            btnMyTickets.Name = "btnMyTickets";
            btnMyTickets.Size = new Size(106, 32);
            btnMyTickets.TabIndex = 17;
            btnMyTickets.Text = "My Tickets";
            btnMyTickets.UseVisualStyleBackColor = false;
            btnMyTickets.Click += btnMyTickets_Click;
            // 
            // btnStore
            // 
            btnStore.BackColor = Color.DimGray;
            btnStore.Cursor = Cursors.Hand;
            btnStore.FlatStyle = FlatStyle.Popup;
            btnStore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStore.ForeColor = Color.Aqua;
            btnStore.Location = new Point(50, 112);
            btnStore.Name = "btnStore";
            btnStore.Size = new Size(106, 32);
            btnStore.TabIndex = 18;
            btnStore.Text = "Store";
            btnStore.UseVisualStyleBackColor = false;
            btnStore.Click += btnStore_Click;
            // 
            // lblTickets
            // 
            lblTickets.AutoSize = true;
            lblTickets.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            lblTickets.ForeColor = Color.Aqua;
            lblTickets.Location = new Point(323, 24);
            lblTickets.Name = "lblTickets";
            lblTickets.Size = new Size(107, 47);
            lblTickets.TabIndex = 19;
            lblTickets.Text = "Store";
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(588, 302);
            Controls.Add(lblTickets);
            Controls.Add(btnStore);
            Controls.Add(btnMyTickets);
            Controls.Add(dgvTickets);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private DataGridView dgvTickets;
        private Button btnMyTickets;
        private Button btnStore;
        private Label lblTickets;
    }
}