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
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspector)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(182, 191);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 40);
            this.btnEdit.TabIndex = 58;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblInspectorDate
            // 
            this.lblInspectorDate.AutoSize = true;
            this.lblInspectorDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInspectorDate.Location = new System.Drawing.Point(67, 67);
            this.lblInspectorDate.Name = "lblInspectorDate";
            this.lblInspectorDate.Size = new System.Drawing.Size(145, 28);
            this.lblInspectorDate.TabIndex = 56;
            this.lblInspectorDate.Text = "InspectorDate";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(124, 131);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 40);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(239, 131);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(109, 40);
            this.btnCreate.TabIndex = 52;
            this.btnCreate.Text = "Create ";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // dgvInspector
            // 
            this.dgvInspector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInspector.Location = new System.Drawing.Point(522, 67);
            this.dgvInspector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInspector.Name = "dgvInspector";
            this.dgvInspector.RowHeadersWidth = 51;
            this.dgvInspector.RowTemplate.Height = 25;
            this.dgvInspector.Size = new System.Drawing.Size(269, 200);
            this.dgvInspector.TabIndex = 61;
            this.dgvInspector.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInspector_CellClick);
            // 
            // dtpInspectorDate
            // 
            this.dtpInspectorDate.Location = new System.Drawing.Point(227, 68);
            this.dtpInspectorDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpInspectorDate.Name = "dtpInspectorDate";
            this.dtpInspectorDate.Size = new System.Drawing.Size(246, 27);
            this.dtpInspectorDate.TabIndex = 75;
            // 
            // frmInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 308);
            this.Controls.Add(this.dtpInspectorDate);
            this.Controls.Add(this.dgvInspector);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblInspectorDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}