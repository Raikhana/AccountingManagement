namespace Example_Project
{
    partial class DisplayProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayProducts));
            this.lstDisplayProduct = new System.Windows.Forms.ListView();
            this.columnProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCostOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstDisplayProduct
            // 
            this.lstDisplayProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProduct,
            this.columnDescription,
            this.columnCostOrder,
            this.columnAmount});
            this.lstDisplayProduct.FullRowSelect = true;
            this.lstDisplayProduct.Location = new System.Drawing.Point(12, 12);
            this.lstDisplayProduct.Name = "lstDisplayProduct";
            this.lstDisplayProduct.Size = new System.Drawing.Size(517, 131);
            this.lstDisplayProduct.TabIndex = 5;
            this.lstDisplayProduct.UseCompatibleStateImageBehavior = false;
            this.lstDisplayProduct.View = System.Windows.Forms.View.Details;
            // 
            // columnProduct
            // 
            this.columnProduct.Text = "Product";
            this.columnProduct.Width = 130;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            this.columnDescription.Width = 170;
            // 
            // columnCostOrder
            // 
            this.columnCostOrder.Text = "Cost";
            this.columnCostOrder.Width = 100;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Amount";
            this.columnAmount.Width = 100;
            // 
            // DisplayProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 155);
            this.Controls.Add(this.lstDisplayProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayProducts";
            this.Text = "Display Products";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DisplayProducts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstDisplayProduct;
        private System.Windows.Forms.ColumnHeader columnProduct;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader columnCostOrder;
        private System.Windows.Forms.ColumnHeader columnAmount;
    }
}