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
            this.btnEdit.Location = new System.Drawing.Point(109, 214);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 30);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.Location = new System.Drawing.Point(114, 91);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(77, 21);
            this.lblQuantity.TabIndex = 36;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeight.Location = new System.Drawing.Point(109, 44);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(66, 21);
            this.lblWeight.TabIndex = 35;
            this.lblWeight.Text = "Weight";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(202, 89);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(106, 23);
            this.txtQuantity.TabIndex = 34;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(202, 42);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(106, 23);
            this.txtWeight.TabIndex = 33;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(109, 166);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 30);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(213, 166);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(95, 30);
            this.btncreate.TabIndex = 31;
            this.btncreate.Text = "Create ";
            this.btncreate.UseVisualStyleBackColor = true;
            // 
            // dgvCatch
            // 
            this.dgvCatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatch.Location = new System.Drawing.Point(497, 276);
            this.dgvCatch.Name = "dgvCatch";
            this.dgvCatch.RowTemplate.Height = 25;
            this.dgvCatch.Size = new System.Drawing.Size(240, 150);
            this.dgvCatch.TabIndex = 38;
            // 
            // frmCatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCatch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btncreate);
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