namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    partial class frmFishingTrip
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
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.lblTripStart = new System.Windows.Forms.Label();
            this.lblTripEnd = new System.Windows.Forms.Label();
            this.lblCatchAmount = new System.Windows.Forms.Label();
            this.dtpTripStart = new System.Windows.Forms.DateTimePicker();
            this.dtpTripEnd = new System.Windows.Forms.DateTimePicker();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvTrip = new System.Windows.Forms.DataGridView();
            this.cbVessels = new System.Windows.Forms.ComboBox();
            this.pnlUsernametxt = new System.Windows.Forms.Panel();
            this.txtCatchAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrip)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // lblTripStart
            // 
            this.lblTripStart.AutoSize = true;
            this.lblTripStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTripStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTripStart.ForeColor = System.Drawing.Color.Aqua;
            this.lblTripStart.Location = new System.Drawing.Point(77, 46);
            this.lblTripStart.Name = "lblTripStart";
            this.lblTripStart.Size = new System.Drawing.Size(79, 21);
            this.lblTripStart.TabIndex = 64;
            this.lblTripStart.Text = "Trip Start";
            // 
            // lblTripEnd
            // 
            this.lblTripEnd.AutoSize = true;
            this.lblTripEnd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTripEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTripEnd.ForeColor = System.Drawing.Color.Aqua;
            this.lblTripEnd.Location = new System.Drawing.Point(88, 80);
            this.lblTripEnd.Name = "lblTripEnd";
            this.lblTripEnd.Size = new System.Drawing.Size(72, 21);
            this.lblTripEnd.TabIndex = 65;
            this.lblTripEnd.Text = "Trip End";
            // 
            // lblCatchAmount
            // 
            this.lblCatchAmount.AutoSize = true;
            this.lblCatchAmount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCatchAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCatchAmount.ForeColor = System.Drawing.Color.Aqua;
            this.lblCatchAmount.Location = new System.Drawing.Point(37, 117);
            this.lblCatchAmount.Name = "lblCatchAmount";
            this.lblCatchAmount.Size = new System.Drawing.Size(119, 21);
            this.lblCatchAmount.TabIndex = 66;
            this.lblCatchAmount.Text = "Catch Amount";
            // 
            // dtpTripStart
            // 
            this.dtpTripStart.CalendarForeColor = System.Drawing.Color.Aqua;
            this.dtpTripStart.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpTripStart.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpTripStart.CalendarTitleForeColor = System.Drawing.Color.Aqua;
            this.dtpTripStart.CalendarTrailingForeColor = System.Drawing.Color.Aqua;
            this.dtpTripStart.Location = new System.Drawing.Point(192, 48);
            this.dtpTripStart.Name = "dtpTripStart";
            this.dtpTripStart.Size = new System.Drawing.Size(213, 23);
            this.dtpTripStart.TabIndex = 75;
            // 
            // dtpTripEnd
            // 
            this.dtpTripEnd.CalendarForeColor = System.Drawing.Color.Aqua;
            this.dtpTripEnd.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpTripEnd.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpTripEnd.CalendarTitleForeColor = System.Drawing.Color.Aqua;
            this.dtpTripEnd.CalendarTrailingForeColor = System.Drawing.Color.Aqua;
            this.dtpTripEnd.Location = new System.Drawing.Point(192, 82);
            this.dtpTripEnd.Name = "dtpTripEnd";
            this.dtpTripEnd.Size = new System.Drawing.Size(213, 23);
            this.dtpTripEnd.TabIndex = 76;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DimGray;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.Aqua;
            this.btnEdit.Location = new System.Drawing.Point(149, 236);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 30);
            this.btnEdit.TabIndex = 80;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.Aqua;
            this.btnDelete.Location = new System.Drawing.Point(98, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 30);
            this.btnDelete.TabIndex = 79;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DimGray;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.ForeColor = System.Drawing.Color.Aqua;
            this.btnCreate.Location = new System.Drawing.Point(198, 200);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(95, 30);
            this.btnCreate.TabIndex = 78;
            this.btnCreate.Text = "Create ";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // dgvTrip
            // 
            this.dgvTrip.BackgroundColor = System.Drawing.Color.Aqua;
            this.dgvTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrip.Location = new System.Drawing.Point(429, 48);
            this.dgvTrip.Name = "dgvTrip";
            this.dgvTrip.RowHeadersWidth = 51;
            this.dgvTrip.RowTemplate.Height = 25;
            this.dgvTrip.Size = new System.Drawing.Size(368, 150);
            this.dgvTrip.TabIndex = 81;
            // 
            // cbVessels
            // 
            this.cbVessels.BackColor = System.Drawing.Color.Gray;
            this.cbVessels.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbVessels.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbVessels.ForeColor = System.Drawing.Color.Aqua;
            this.cbVessels.FormattingEnabled = true;
            this.cbVessels.Location = new System.Drawing.Point(140, 162);
            this.cbVessels.Name = "cbVessels";
            this.cbVessels.Size = new System.Drawing.Size(121, 23);
            this.cbVessels.TabIndex = 82;
            this.cbVessels.Text = "Vessels";
            // 
            // pnlUsernametxt
            // 
            this.pnlUsernametxt.BackColor = System.Drawing.Color.Aqua;
            this.pnlUsernametxt.Location = new System.Drawing.Point(192, 138);
            this.pnlUsernametxt.Name = "pnlUsernametxt";
            this.pnlUsernametxt.Size = new System.Drawing.Size(213, 1);
            this.pnlUsernametxt.TabIndex = 84;
            // 
            // txtCatchAmount
            // 
            this.txtCatchAmount.BackColor = System.Drawing.Color.Black;
            this.txtCatchAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCatchAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCatchAmount.ForeColor = System.Drawing.Color.White;
            this.txtCatchAmount.Location = new System.Drawing.Point(192, 117);
            this.txtCatchAmount.Name = "txtCatchAmount";
            this.txtCatchAmount.Size = new System.Drawing.Size(213, 22);
            this.txtCatchAmount.TabIndex = 83;
            // 
            // frmFishingTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(839, 278);
            this.Controls.Add(this.pnlUsernametxt);
            this.Controls.Add(this.txtCatchAmount);
            this.Controls.Add(this.cbVessels);
            this.Controls.Add(this.dgvTrip);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dtpTripEnd);
            this.Controls.Add(this.dtpTripStart);
            this.Controls.Add(this.lblCatchAmount);
            this.Controls.Add(this.lblTripEnd);
            this.Controls.Add(this.lblTripStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFishingTrip";
            this.Text = "Fishing Trip";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label lblTripStart;
        private Label lblTripEnd;
        private Label lblCatchAmount;
        private DateTimePicker dtpTripStart;
        private DateTimePicker dtpTripEnd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnCreate;
        private DataGridView dgvTrip;
        private ComboBox cbVessels;
        private Panel pnlUsernametxt;
        private TextBox txtCatchAmount;
    }
}