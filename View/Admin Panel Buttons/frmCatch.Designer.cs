namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    partial class frmCatch
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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.dgvCatch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(149, 253);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 40);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.Location = new System.Drawing.Point(90, 124);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(95, 28);
            this.lblQuantity.TabIndex = 36;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeight.Location = new System.Drawing.Point(85, 62);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(80, 28);
            this.lblWeight.TabIndex = 35;
            this.lblWeight.Text = "Weight";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(191, 122);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 27);
            this.txtQuantity.TabIndex = 34;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(191, 59);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(121, 27);
            this.txtWeight.TabIndex = 33;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(88, 196);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 40);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(206, 196);
            this.btncreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(109, 40);
            this.btncreate.TabIndex = 31;
            this.btncreate.Text = "Create ";
            this.btncreate.UseVisualStyleBackColor = true;
            // 
            // dgvCatch
            // 
            this.dgvCatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatch.Location = new System.Drawing.Point(460, 62);
            this.dgvCatch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCatch.Name = "dgvCatch";
            this.dgvCatch.RowHeadersWidth = 51;
            this.dgvCatch.RowTemplate.Height = 25;
            this.dgvCatch.Size = new System.Drawing.Size(322, 200);
            this.dgvCatch.TabIndex = 38;
            this.dgvCatch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatch_CellClick);
            // 
            // frmCatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 373);
            this.Controls.Add(this.dgvCatch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btncreate);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCatch";
            this.Text = "frmCatch";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEdit;
        private Label lblQuantity;
        private Label lblWeight;
        private TextBox txtQuantity;
        private TextBox txtWeight;
        private Button btnDelete;
        private Button btncreate;
        private DataGridView dgvCatch;
    }
}