namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    partial class frmInspector
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblInspectorDate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvInspector = new System.Windows.Forms.DataGridView();
            this.dtpInspectorDate = new System.Windows.Forms.DateTimePicker();
            this.cmbVessels = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspector)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DimGray;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.Aqua;
            this.btnEdit.Location = new System.Drawing.Point(155, 191);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 30);
            this.btnEdit.TabIndex = 58;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // lblInspectorDate
            // 
            this.lblInspectorDate.AutoSize = true;
            this.lblInspectorDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInspectorDate.ForeColor = System.Drawing.Color.Aqua;
            this.lblInspectorDate.Location = new System.Drawing.Point(59, 50);
            this.lblInspectorDate.Name = "lblInspectorDate";
            this.lblInspectorDate.Size = new System.Drawing.Size(117, 21);
            this.lblInspectorDate.TabIndex = 56;
            this.lblInspectorDate.Text = "InspectorDate";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.Aqua;
            this.btnDelete.Location = new System.Drawing.Point(104, 146);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 30);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DimGray;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.ForeColor = System.Drawing.Color.Aqua;
            this.btnCreate.Location = new System.Drawing.Point(205, 146);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(95, 30);
            this.btnCreate.TabIndex = 52;
            this.btnCreate.Text = "Create ";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // dgvInspector
            // 
            this.dgvInspector.BackgroundColor = System.Drawing.Color.Aqua;
            this.dgvInspector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInspector.Location = new System.Drawing.Point(381, 91);
            this.dgvInspector.Name = "dgvInspector";
            this.dgvInspector.RowHeadersWidth = 51;
            this.dgvInspector.RowTemplate.Height = 25;
            this.dgvInspector.Size = new System.Drawing.Size(308, 150);
            this.dgvInspector.TabIndex = 61;
            // 
            // dtpInspectorDate
            // 
            this.dtpInspectorDate.CalendarForeColor = System.Drawing.Color.Aqua;
            this.dtpInspectorDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpInspectorDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpInspectorDate.CalendarTitleForeColor = System.Drawing.Color.Aqua;
            this.dtpInspectorDate.CalendarTrailingForeColor = System.Drawing.Color.Aqua;
            this.dtpInspectorDate.Location = new System.Drawing.Point(199, 51);
            this.dtpInspectorDate.Name = "dtpInspectorDate";
            this.dtpInspectorDate.Size = new System.Drawing.Size(216, 23);
            this.dtpInspectorDate.TabIndex = 75;
            // 
            // cmbVessels
            // 
            this.cmbVessels.BackColor = System.Drawing.Color.Gray;
            this.cmbVessels.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbVessels.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbVessels.ForeColor = System.Drawing.Color.Aqua;
            this.cmbVessels.FormattingEnabled = true;
            this.cmbVessels.Location = new System.Drawing.Point(146, 91);
            this.cmbVessels.Name = "cmbVessels";
            this.cmbVessels.Size = new System.Drawing.Size(121, 23);
            this.cmbVessels.TabIndex = 76;
            this.cmbVessels.Text = "Vessels";
            // 
            // frmInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(729, 273);
            this.Controls.Add(this.cmbVessels);
            this.Controls.Add(this.dtpInspectorDate);
            this.Controls.Add(this.dgvInspector);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblInspectorDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Name = "frmInspector";
            this.Text = "frmInspector";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEdit;
        private Label lblInspectorDate;
        private Button btnDelete;
        private Button btnCreate;
        private DataGridView dgvInspector;
        private DateTimePicker dtpInspectorDate;
        private ComboBox cmbVessels;
    }
}