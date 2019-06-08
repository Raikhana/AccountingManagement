/*
 * Author - Raikhana Urazbaeva 
 * Form - For user to add and modify a product 
 * June 2019
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Project
{
    public partial class AddProduct : Form
    {
        public ProductClass modifyProducts;
        public ProductClass modifiedProduct { get; set; }
        public ProductClass addproduct = new ProductClass();
        public ProductClass added { get; set; }
        String y = "";
        public AddProduct(String x, ProductClass product)
        {
            modifyProducts = product;
            y = x;
            InitializeComponent();
        }
        DateTime createdProduct;
        DateTime updatedProduct;
        private void AddProduct_Load(object sender, EventArgs e)
        {
            FillComboBoxProduct();
            if (y == "AddProduct")
            {
                btnModifyProduct.Enabled = false;
                btnModifyProduct.BackColor = Color.FromArgb(189, 189, 189);

                txtCreatedProduct.Text = DateTime.Now.ToString("d");
                txtCreatedProduct.ForeColor = Color.Gray;
                txtUpdatedProduct.Text = DateTime.Now.ToString("d");
                txtUpdatedProduct.ForeColor = Color.Gray;
            }
            else if (y == "ModifyProduct")
            {
                FillTextBox();
                btnAddProduct.Enabled = false; 
                btnAddProduct.BackColor = Color.FromArgb(189, 189, 189);
            }
          
        }
        
        private void FillTextBox()
        {
            txtNameProduct.Text = modifyProducts.nameProduct;
            txtDescriptionProduct.Text = modifyProducts.descriptionProduct;
            txtCreatedProduct.Text = modifyProducts.createdProduct.ToString("d" );
            txtUpdatedProduct.Text = modifyProducts.updatedProduct.ToString("d");
            txtCostProduct.Text = Convert.ToString(modifyProducts.costProduct);
            comboBoxStatusProduct.SelectedValue = modifyProducts.idStatusProduct;

        }
        private void FillComboBoxProduct()
        { 
            List<ProductStatusClass> statuses = new List<ProductStatusClass>();
            try
            {
                statuses = Product_statusDBClass.GetProduct_status();
                comboBoxStatusProduct.DataSource = statuses;
                comboBoxStatusProduct.DisplayMember = "status";
                comboBoxStatusProduct.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                addproduct.nameProduct = txtNameProduct.Text;
                addproduct. descriptionProduct = txtDescriptionProduct.Text;

                addproduct.createdProduct = DateTime.Now;
                txtCreatedProduct.Text = createdProduct.ToString("d");

                addproduct.updatedProduct = DateTime.Now; 
                txtUpdatedProduct.Text = updatedProduct.ToString("d");

                addproduct.costProduct = Convert.ToDouble(txtCostProduct.Text);

                addproduct.idStatusProduct = (int)comboBoxStatusProduct.SelectedValue;

                this.added = addproduct;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
      
        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                modifyProducts.nameProduct = txtNameProduct.Text;
                modifyProducts.descriptionProduct = txtDescriptionProduct.Text;
                
                txtCreatedProduct.Text = createdProduct.ToString("d");

                modifyProducts.updatedProduct = DateTime.Now;
                txtUpdatedProduct.Text = updatedProduct.ToString("d");
               

                modifyProducts.costProduct = Convert.ToDouble(txtCostProduct.Text); 

                modifyProducts.idStatusProduct = (int)comboBoxStatusProduct.SelectedValue;

                this.modifiedProduct = modifyProducts;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtNameProduct) &&
                Validator.IsValidName(txtNameProduct) &&
                Validator.IsPresent(txtDescriptionProduct) &&
                Validator.IsDecimal(txtCostProduct)&&
                Validator.IsValidString(txtNameProduct) &&
                Validator.IsValidString(txtDescriptionProduct);
        }

        private void btnCloseProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
