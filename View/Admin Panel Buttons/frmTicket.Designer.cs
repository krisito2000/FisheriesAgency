namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    partial class frmTicket
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
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbIEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblTelk = new System.Windows.Forms.Label();
            this.txtTalkDecisionNum = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.cbIsPensioner = new System.Windows.Forms.CheckBox();
            this.cbIsDisabled = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTicket
            // 
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Location = new System.Drawing.Point(553, 73);
            this.dgvTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.RowHeadersWidth = 51;
            this.dgvTicket.RowTemplate.Height = 25;
            this.dgvTicket.Size = new System.Drawing.Size(274, 200);
            this.dgvTicket.TabIndex = 0;
            this.dgvTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(632, 347);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 40);
            this.btnEdit.TabIndex = 65;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lbIEndDate
            // 
            this.lbIEndDate.AutoSize = true;
            this.lbIEndDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbIEndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbIEndDate.Location = new System.Drawing.Point(75, 109);
            this.lbIEndDate.Name = "lbIEndDate";
            this.lbIEndDate.Size = new System.Drawing.Size(98, 28);
            this.lbIEndDate.TabIndex = 64;
            this.lbIEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStartDate.Location = new System.Drawing.Point(70, 47);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(110, 28);
            this.lblStartDate.TabIndex = 63;
            this.lblStartDate.Text = "Start Date";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(565, 299);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 40);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(680, 299);
            this.btncreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(109, 40);
            this.btncreate.TabIndex = 59;
            this.btncreate.Text = "Create ";
            this.btncreate.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(75, 163);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 28);
            this.lblPrice.TabIndex = 68;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(192, 165);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(228, 27);
            this.txtPrice.TabIndex = 66;
            // 
            // lblTelk
            // 
            this.lblTelk.AutoSize = true;
            this.lblTelk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTelk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelk.Location = new System.Drawing.Point(83, 347);
            this.lblTelk.Name = "lblTelk";
            this.lblTelk.Size = new System.Drawing.Size(50, 28);
            this.lblTelk.TabIndex = 73;
            this.lblTelk.Text = "Telk";
            // 
            // txtTalkDecisionNum
            // 
            this.txtTalkDecisionNum.Location = new System.Drawing.Point(192, 344);
            this.txtTalkDecisionNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTalkDecisionNum.Name = "txtTalkDecisionNum";
            this.txtTalkDecisionNum.Size = new System.Drawing.Size(121, 27);
            this.txtTalkDecisionNum.TabIndex = 71;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(192, 47);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(228, 27);
            this.dtpStartDate.TabIndex = 74;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(192, 109);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(228, 27);
            this.dtpEndDate.TabIndex = 75;
            // 
            // cbIsPensioner
            // 
            this.cbIsPensioner.AutoSize = true;
            this.cbIsPensioner.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbIsPensioner.Location = new System.Drawing.Point(131, 224);
            this.cbIsPensioner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbIsPensioner.Name = "cbIsPensioner";
            this.cbIsPensioner.Size = new System.Drawing.Size(141, 32);
            this.cbIsPensioner.TabIndex = 76;
            this.cbIsPensioner.Text = "IsPensioner";
            this.cbIsPensioner.UseVisualStyleBackColor = true;
            // 
            // cbIsDisabled
            // 
            this.cbIsDisabled.AutoSize = true;
            this.cbIsDisabled.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbIsDisabled.Location = new System.Drawing.Point(131, 281);
            this.cbIsDisabled.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbIsDisabled.Name = "cbIsDisabled";
            this.cbIsDisabled.Size = new System.Drawing.Size(131, 32);
            this.cbIsDisabled.TabIndex = 77;
            this.cbIsDisabled.Text = "IsDisabled";
            this.cbIsDisabled.UseVisualStyleBackColor = true;
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 448);
            this.Controls.Add(this.cbIsDisabled);
            this.Controls.Add(this.cbIsPensioner);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblTelk);
            this.Controls.Add(this.txtTalkDecisionNum);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbIEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.dgvTicket);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTicket";
            this.Text = "frmTicket";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvTicket;
        private Button btnEdit;
        private Label lbIEndDate;
        private Label lblStartDate;
        private Button btnDelete;
        private Button btncreate;
        private Label lblIsPensioner;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblTelk;
        private Label lblIsDisabled;
        private TextBox txtTalkDecisionNum;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private CheckBox cbIsPensioner;
        private CheckBox cbIsDisabled;
    }
}