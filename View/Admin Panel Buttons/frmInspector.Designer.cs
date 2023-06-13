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
            btnEdit = new Button();
            lblInspectorDate = new Label();
            btnDelete = new Button();
            btnCreate = new Button();
            dgvInspector = new DataGridView();
            dtpInspectorDate = new DateTimePicker();
            cmbVessels = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvInspector).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DimGray;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Aqua;
            btnEdit.Location = new Point(143, 195);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 30);
            btnEdit.TabIndex = 58;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblInspectorDate
            // 
            lblInspectorDate.AutoSize = true;
            lblInspectorDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInspectorDate.ForeColor = Color.Aqua;
            lblInspectorDate.Location = new Point(38, 40);
            lblInspectorDate.Name = "lblInspectorDate";
            lblInspectorDate.Size = new Size(117, 21);
            lblInspectorDate.TabIndex = 56;
            lblInspectorDate.Text = "InspectorDate";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DimGray;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Aqua;
            btnDelete.Location = new Point(92, 150);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 53;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DimGray;
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.Aqua;
            btnCreate.Location = new Point(193, 150);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(95, 30);
            btnCreate.TabIndex = 52;
            btnCreate.Text = "Create ";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvInspector
            // 
            dgvInspector.BackgroundColor = Color.Aqua;
            dgvInspector.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInspector.Location = new Point(349, 90);
            dgvInspector.Name = "dgvInspector";
            dgvInspector.RowHeadersWidth = 51;
            dgvInspector.RowTemplate.Height = 25;
            dgvInspector.Size = new Size(338, 150);
            dgvInspector.TabIndex = 61;
            dgvInspector.CellClick += dgvInspector_CellClick;
            // 
            // dtpInspectorDate
            // 
            dtpInspectorDate.CalendarForeColor = Color.Aqua;
            dtpInspectorDate.CalendarMonthBackground = Color.FromArgb(64, 64, 64);
            dtpInspectorDate.CalendarTitleBackColor = Color.FromArgb(64, 64, 64);
            dtpInspectorDate.CalendarTitleForeColor = Color.Aqua;
            dtpInspectorDate.CalendarTrailingForeColor = Color.Aqua;
            dtpInspectorDate.Location = new Point(178, 41);
            dtpInspectorDate.Name = "dtpInspectorDate";
            dtpInspectorDate.Size = new Size(216, 23);
            dtpInspectorDate.TabIndex = 75;
            // 
            // cmbVessels
            // 
            cmbVessels.BackColor = Color.Gray;
            cmbVessels.FlatStyle = FlatStyle.Popup;
            cmbVessels.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbVessels.ForeColor = Color.Aqua;
            cmbVessels.FormattingEnabled = true;
            cmbVessels.Location = new Point(133, 100);
            cmbVessels.Name = "cmbVessels";
            cmbVessels.Size = new Size(121, 23);
            cmbVessels.TabIndex = 76;
            cmbVessels.Text = "Vessels";
            cmbVessels.DropDown += cmbVessels_DropDown;
            // 
            // frmInspector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(729, 273);
            Controls.Add(cmbVessels);
            Controls.Add(dtpInspectorDate);
            Controls.Add(dgvInspector);
            Controls.Add(btnEdit);
            Controls.Add(lblInspectorDate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Name = "frmInspector";
            Text = "Inspectors";
            ((System.ComponentModel.ISupportInitialize)dgvInspector).EndInit();
            ResumeLayout(false);
            PerformLayout();
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