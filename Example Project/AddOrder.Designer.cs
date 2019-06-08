namespace Example_Project
{
    partial class AddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.txtAmountOrders = new System.Windows.Forms.TextBox();
            this.comboBoxOrderProduct = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstAddedOrder = new System.Windows.Forms.ListView();
            this.columnNameProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescriptionProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCreatedProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUpdatedProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCostProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIdsStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddListOfProduct = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstOrder = new System.Windows.Forms.ListView();
            this.columnProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCostOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteItemShopLIST = new System.Windows.Forms.Button();
            this.btnCloseAddOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Location = new System.Drawing.Point(142, 718);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(130, 50);
            this.btnAddOrder.TabIndex = 6;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // txtAmountOrders
            // 
            this.txtAmountOrders.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountOrders.Location = new System.Drawing.Point(21, 324);
            this.txtAmountOrders.Multiline = true;
            this.txtAmountOrders.Name = "txtAmountOrders";
            this.txtAmountOrders.Size = new System.Drawing.Size(77, 50);
            this.txtAmountOrders.TabIndex = 1;
            this.txtAmountOrders.Tag = "Amount";
            // 
            // comboBoxOrderProduct
            // 
            this.comboBoxOrderProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrderProduct.FormattingEnabled = true;
            this.comboBoxOrderProduct.Items.AddRange(new object[] {
            "Create a string array in CSharp",
            "Create a string by copying from another in CSharp",
            "Create string from char array in CSharp"});
            this.comboBoxOrderProduct.Location = new System.Drawing.Point(20, 738);
            this.comboBoxOrderProduct.Name = "comboBoxOrderProduct";
            this.comboBoxOrderProduct.Size = new System.Drawing.Size(100, 27);
            this.comboBoxOrderProduct.TabIndex = 42;
            this.comboBoxOrderProduct.Tag = "Product";
            this.comboBoxOrderProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderProduct_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 43;
            this.label6.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 713);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 44;
            this.label7.Text = " Client list";
            // 
            // lstAddedOrder
            // 
            this.lstAddedOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameProduct,
            this.columnDescriptionProduct,
            this.columnCreatedProduct,
            this.columnUpdatedProduct,
            this.columnCostProduct,
            this.columnStatus,
            this.columnIdsStatus,
            this.columnID});
            this.lstAddedOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAddedOrder.FullRowSelect = true;
            this.lstAddedOrder.GridLines = true;
            this.lstAddedOrder.HideSelection = false;
            this.lstAddedOrder.Location = new System.Drawing.Point(19, 37);
            this.lstAddedOrder.Name = "lstAddedOrder";
            this.lstAddedOrder.Size = new System.Drawing.Size(900, 260);
            this.lstAddedOrder.TabIndex = 2;
            this.lstAddedOrder.UseCompatibleStateImageBehavior = false;
            this.lstAddedOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnNameProduct
            // 
            this.columnNameProduct.Text = "Name";
            this.columnNameProduct.Width = 90;
            // 
            // columnDescriptionProduct
            // 
            this.columnDescriptionProduct.Text = "Description";
            this.columnDescriptionProduct.Width = 170;
            // 
            // columnCreatedProduct
            // 
            this.columnCreatedProduct.Text = "Created";
            this.columnCreatedProduct.Width = 120;
            // 
            // columnUpdatedProduct
            // 
            this.columnUpdatedProduct.Text = "Updated";
            this.columnUpdatedProduct.Width = 130;
            // 
            // columnCostProduct
            // 
            this.columnCostProduct.Text = "Cost";
            this.columnCostProduct.Width = 90;
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Status";
            this.columnStatus.Width = 90;
            // 
            // columnIdsStatus
            // 
            this.columnIdsStatus.Text = "ID Status";
            this.columnIdsStatus.Width = 90;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 90;
            // 
            // btnAddListOfProduct
            // 
            this.btnAddListOfProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddListOfProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddListOfProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddListOfProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddListOfProduct.Location = new System.Drawing.Point(115, 324);
            this.btnAddListOfProduct.Name = "btnAddListOfProduct";
            this.btnAddListOfProduct.Size = new System.Drawing.Size(130, 50);
            this.btnAddListOfProduct.TabIndex = 3;
            this.btnAddListOfProduct.Text = "Add";
            this.btnAddListOfProduct.UseVisualStyleBackColor = false;
            this.btnAddListOfProduct.Click += new System.EventHandler(this.btnAddListOfProduct_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(18, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 18);
            this.label8.TabIndex = 52;
            this.label8.Text = "lLst of products";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(17, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Shopping List";
            // 
            // lstOrder
            // 
            this.lstOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProduct,
            this.columnAmount,
            this.columnCostOrder,
            this.columnSubtotal,
            this.columnProductID});
            this.lstOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrder.FullRowSelect = true;
            this.lstOrder.GridLines = true;
            this.lstOrder.Location = new System.Drawing.Point(19, 435);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(900, 260);
            this.lstOrder.TabIndex = 4;
            this.lstOrder.UseCompatibleStateImageBehavior = false;
            this.lstOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnProduct
            // 
            this.columnProduct.Text = "Product";
            this.columnProduct.Width = 160;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Amount";
            this.columnAmount.Width = 160;
            // 
            // columnCostOrder
            // 
            this.columnCostOrder.Text = "Cost";
            this.columnCostOrder.Width = 160;
            // 
            // columnSubtotal
            // 
            this.columnSubtotal.Text = "Subtotal";
            this.columnSubtotal.Width = 160;
            // 
            // columnProductID
            // 
            this.columnProductID.Text = "Product ID";
            this.columnProductID.Width = 160;
            // 
            // btnDeleteItemShopLIST
            // 
            this.btnDeleteItemShopLIST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDeleteItemShopLIST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItemShopLIST.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItemShopLIST.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItemShopLIST.Location = new System.Drawing.Point(292, 718);
            this.btnDeleteItemShopLIST.Name = "btnDeleteItemShopLIST";
            this.btnDeleteItemShopLIST.Size = new System.Drawing.Size(130, 50);
            this.btnDeleteItemShopLIST.TabIndex = 5;
            this.btnDeleteItemShopLIST.Text = "Delete";
            this.btnDeleteItemShopLIST.UseVisualStyleBackColor = false;
            this.btnDeleteItemShopLIST.Click += new System.EventHandler(this.btnDeleteItemShopLIST_Click);
            // 
            // btnCloseAddOrder
            // 
            this.btnCloseAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnCloseAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAddOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnCloseAddOrder.Location = new System.Drawing.Point(442, 718);
            this.btnCloseAddOrder.Name = "btnCloseAddOrder";
            this.btnCloseAddOrder.Size = new System.Drawing.Size(130, 50);
            this.btnCloseAddOrder.TabIndex = 54;
            this.btnCloseAddOrder.Text = "Close";
            this.btnCloseAddOrder.UseVisualStyleBackColor = false;
            this.btnCloseAddOrder.Click += new System.EventHandler(this.btnCloseAddOrder_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 800);
            this.Controls.Add(this.btnCloseAddOrder);
            this.Controls.Add(this.btnDeleteItemShopLIST);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddListOfProduct);
            this.Controls.Add(this.lstAddedOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxOrderProduct);
            this.Controls.Add(this.txtAmountOrders);
            this.Controls.Add(this.btnAddOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddOrder";
            this.Text = " Add Order";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.TextBox txtAmountOrders;
        private System.Windows.Forms.ComboBox comboBoxOrderProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lstAddedOrder;
        public System.Windows.Forms.ColumnHeader columnNameProduct;
        private System.Windows.Forms.ColumnHeader columnDescriptionProduct;
        private System.Windows.Forms.ColumnHeader columnCreatedProduct;
        private System.Windows.Forms.ColumnHeader columnUpdatedProduct;
        private System.Windows.Forms.ColumnHeader columnCostProduct;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.ColumnHeader columnIdsStatus;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.Button btnAddListOfProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lstOrder;
        private System.Windows.Forms.ColumnHeader columnCostOrder;
        private System.Windows.Forms.ColumnHeader columnProduct;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.Button btnDeleteItemShopLIST;
        private System.Windows.Forms.ColumnHeader columnSubtotal;
        private System.Windows.Forms.ColumnHeader columnProductID;
        private System.Windows.Forms.Button btnCloseAddOrder;
    }
}