namespace WindowsFormsApplication1
{
    partial class ViewExpenditureFrom
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
            this.grdExpenditures = new System.Windows.Forms.DataGridView();
            this.btnAddExpenditure = new System.Windows.Forms.MenuStrip();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenditures)).BeginInit();
            this.btnAddExpenditure.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdExpenditures
            // 
            this.grdExpenditures.AllowUserToAddRows = false;
            this.grdExpenditures.AllowUserToDeleteRows = false;
            this.grdExpenditures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExpenditures.Location = new System.Drawing.Point(3, 36);
            this.grdExpenditures.Name = "grdExpenditures";
            this.grdExpenditures.ReadOnly = true;
            this.grdExpenditures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdExpenditures.Size = new System.Drawing.Size(618, 358);
            this.grdExpenditures.TabIndex = 0;
            // 
            // btnAddExpenditure
            // 
            this.btnAddExpenditure.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem});
            this.btnAddExpenditure.Location = new System.Drawing.Point(0, 0);
            this.btnAddExpenditure.Name = "btnAddExpenditure";
            this.btnAddExpenditure.Size = new System.Drawing.Size(621, 24);
            this.btnAddExpenditure.TabIndex = 1;
            this.btnAddExpenditure.Text = "Addnew";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.addNewToolStripMenuItem.Text = "Add new";
            // 
            // ViewExpenditureFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 368);
            this.Controls.Add(this.grdExpenditures);
            this.Controls.Add(this.btnAddExpenditure);
            this.Name = "ViewExpenditureFrom";
            this.Text = "ViewExpenditureFrom";
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenditures)).EndInit();
            this.btnAddExpenditure.ResumeLayout(false);
            this.btnAddExpenditure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdExpenditures;
        private System.Windows.Forms.MenuStrip btnAddExpenditure;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
    }
}