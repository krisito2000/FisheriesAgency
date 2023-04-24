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
            this.txtInspectorDate = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.dgvInspector = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspector)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(87, 158);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 30);
            this.btnEdit.TabIndex = 58;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblInspectorDate
            // 
            this.lblInspectorDate.AutoSize = true;
            this.lblInspectorDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInspectorDate.Location = new System.Drawing.Point(90, 55);
            this.lblInspectorDate.Name = "lblInspectorDate";
            this.lblInspectorDate.Size = new System.Drawing.Size(117, 21);
            this.lblInspectorDate.TabIndex = 56;
            this.lblInspectorDate.Text = "InspectorDate";
            // 
            // txtInspectorDate
            // 
            this.txtInspectorDate.Location = new System.Drawing.Point(235, 57);
            this.txtInspectorDate.Name = "txtInspectorDate";
            this.txtInspectorDate.Size = new System.Drawing.Size(106, 23);
            this.txtInspectorDate.TabIndex = 54;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(90, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 30);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(191, 110);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(95, 30);
            this.btncreate.TabIndex = 52;
            this.btncreate.Text = "Create ";
            this.btncreate.UseVisualStyleBackColor = true;
            // 
            // dgvInspector
            // 
            this.dgvInspector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInspector.Location = new System.Drawing.Point(452, 269);
            this.dgvInspector.Name = "dgvInspector";
            this.dgvInspector.RowTemplate.Height = 25;
            this.dgvInspector.Size = new System.Drawing.Size(240, 150);
            this.dgvInspector.TabIndex = 61;
            // 
            // frmInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvInspector);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblInspectorDate);
            this.Controls.Add(this.txtInspectorDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btncreate);
            this.Name = "frmInspector";
            this.Text = "frmInspector";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEdit;
        private Label lblInspectorDate;
        private TextBox txtInspectorDate;
        private Button btnDelete;
        private Button btncreate;
        private DataGridView dgvInspector;
    }
}