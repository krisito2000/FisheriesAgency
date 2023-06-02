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
            btnEdit.Location = new Point(155, 191);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 30);
            btnEdit.TabIndex = 58;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblInspectorDate
            // 
            lblInspectorDate.AutoSize = true;
            lblInspectorDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInspectorDate.Location = new Point(59, 50);
            lblInspectorDate.Name = "lblInspectorDate";
            lblInspectorDate.Size = new Size(117, 21);
            lblInspectorDate.TabIndex = 56;
            lblInspectorDate.Text = "InspectorDate";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(104, 146);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 53;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(205, 146);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(95, 30);
            btnCreate.TabIndex = 52;
            btnCreate.Text = "Create ";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvInspector
            // 
            dgvInspector.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInspector.Location = new Point(381, 91);
            dgvInspector.Name = "dgvInspector";
            dgvInspector.RowHeadersWidth = 51;
            dgvInspector.RowTemplate.Height = 25;
            dgvInspector.Size = new Size(308, 150);
            dgvInspector.TabIndex = 61;
            dgvInspector.CellClick += dgvInspector_CellClick;
            // 
            // dtpInspectorDate
            // 
            dtpInspectorDate.Location = new Point(199, 51);
            dtpInspectorDate.Name = "dtpInspectorDate";
            dtpInspectorDate.Size = new Size(216, 23);
            dtpInspectorDate.TabIndex = 75;
            // 
            // cmbVessels
            // 
            cmbVessels.FormattingEnabled = true;
            cmbVessels.Location = new Point(146, 91);
            cmbVessels.Name = "cmbVessels";
            cmbVessels.Size = new Size(121, 23);
            cmbVessels.TabIndex = 76;
            cmbVessels.Text = "Vessels";
            cmbVessels.SelectedIndexChanged += cmbVessels_SelectedIndexChanged;
            // 
            // frmInspector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 273);
            Controls.Add(cmbVessels);
            Controls.Add(dtpInspectorDate);
            Controls.Add(dgvInspector);
            Controls.Add(btnEdit);
            Controls.Add(lblInspectorDate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Name = "frmInspector";
            Text = "frmInspector";
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