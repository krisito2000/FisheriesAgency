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
            this.txtCatchAmount = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvTrip = new System.Windows.Forms.DataGridView();
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
            this.lblTripStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTripStart.Location = new System.Drawing.Point(88, 62);
            this.lblTripStart.Name = "lblTripStart";
            this.lblTripStart.Size = new System.Drawing.Size(101, 28);
            this.lblTripStart.TabIndex = 64;
            this.lblTripStart.Text = "Trip Start";
            // 
            // lblTripEnd
            // 
            this.lblTripEnd.AutoSize = true;
            this.lblTripEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTripEnd.Location = new System.Drawing.Point(100, 107);
            this.lblTripEnd.Name = "lblTripEnd";
            this.lblTripEnd.Size = new System.Drawing.Size(89, 28);
            this.lblTripEnd.TabIndex = 65;
            this.lblTripEnd.Text = "Trip End";
            // 
            // lblCatchAmount
            // 
            this.lblCatchAmount.AutoSize = true;
            this.lblCatchAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCatchAmount.Location = new System.Drawing.Point(42, 156);
            this.lblCatchAmount.Name = "lblCatchAmount";
            this.lblCatchAmount.Size = new System.Drawing.Size(147, 28);
            this.lblCatchAmount.TabIndex = 66;
            this.lblCatchAmount.Text = "Catch Amount";
            // 
            // dtpTripStart
            // 
            this.dtpTripStart.Location = new System.Drawing.Point(220, 64);
            this.dtpTripStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpTripStart.Name = "dtpTripStart";
            this.dtpTripStart.Size = new System.Drawing.Size(243, 27);
            this.dtpTripStart.TabIndex = 75;
            // 
            // dtpTripEnd
            // 
            this.dtpTripEnd.Location = new System.Drawing.Point(220, 109);
            this.dtpTripEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpTripEnd.Name = "dtpTripEnd";
            this.dtpTripEnd.Size = new System.Drawing.Size(243, 27);
            this.dtpTripEnd.TabIndex = 76;
            // 
            // txtCatchAmount
            // 
            this.txtCatchAmount.Location = new System.Drawing.Point(220, 156);
            this.txtCatchAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCatchAmount.Name = "txtCatchAmount";
            this.txtCatchAmount.Size = new System.Drawing.Size(243, 27);
            this.txtCatchAmount.TabIndex = 77;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(175, 267);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 40);
            this.btnEdit.TabIndex = 80;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(116, 219);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 40);
            this.btnDelete.TabIndex = 79;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(231, 219);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(109, 40);
            this.btnCreate.TabIndex = 78;
            this.btnCreate.Text = "Create ";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // dgvTrip
            // 
            this.dgvTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrip.Location = new System.Drawing.Point(490, 64);
            this.dgvTrip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTrip.Name = "dgvTrip";
            this.dgvTrip.RowHeadersWidth = 51;
            this.dgvTrip.RowTemplate.Height = 25;
            this.dgvTrip.Size = new System.Drawing.Size(421, 200);
            this.dgvTrip.TabIndex = 81;
            this.dgvTrip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellClick);
            // 
            // frmFishingTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 370);
            this.Controls.Add(this.dgvTrip);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtCatchAmount);
            this.Controls.Add(this.dtpTripEnd);
            this.Controls.Add(this.dtpTripStart);
            this.Controls.Add(this.lblCatchAmount);
            this.Controls.Add(this.lblTripEnd);
            this.Controls.Add(this.lblTripStart);
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
        private TextBox txtCatchAmount;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnCreate;
        private DataGridView dgvTrip;
    }
}