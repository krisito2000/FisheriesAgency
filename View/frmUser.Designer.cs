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
            dgvInformation = new DataGridView();
            cmbTables = new ComboBox();
            btnTicket = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInformation).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(275, 293);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(64, 28);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvInformation
            // 
            dgvInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInformation.Location = new Point(312, 66);
            dgvInformation.Name = "dgvInformation";
            dgvInformation.RowTemplate.Height = 25;
            dgvInformation.Size = new Size(325, 192);
            dgvInformation.TabIndex = 14;
            // 
            // cmbTables
            // 
            cmbTables.FormattingEnabled = true;
            cmbTables.Location = new Point(91, 138);
            cmbTables.Name = "cmbTables";
            cmbTables.Size = new Size(121, 23);
            cmbTables.TabIndex = 15;
            cmbTables.Text = "Select a table";
            // 
            // btnTicket
            // 
            btnTicket.Location = new Point(91, 201);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(121, 28);
            btnTicket.TabIndex = 16;
            btnTicket.Text = "Create a ticket";
            btnTicket.UseVisualStyleBackColor = true;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 353);
            Controls.Add(btnTicket);
            Controls.Add(cmbTables);
            Controls.Add(dgvInformation);
            Controls.Add(btnLogout);
            Name = "frmUser";
            Text = "User";
            ((System.ComponentModel.ISupportInitialize)dgvInformation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogout;
        private DataGridView dgvInformation;
        private ComboBox cmbTables;
        private Button btnTicket;
    }
}