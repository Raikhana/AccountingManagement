/*
 * Author - Raikhana Urazbaeva 
 * Form - For admin to create and manage a user profile 
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
    public partial class CreateAdmin : Form
    {
        public UsersClass createdAdmin = new UsersClass();
        public UsersClass creativity { get; set; }
        public CreateAdmin()
        {
            InitializeComponent();
        }
        private void CreateAdmin_Load(object sender, EventArgs e)
        {
            if (txtCreateAdminPassword.Text != null)
            {
                txtCreateAdminPassword.ForeColor = Color.Black;
                txtCreateAdminPassword.Text = "";
                txtCreateAdminPassword.PasswordChar = '*';
                txtCreateAdminPassword.Text = createdAdmin.passwordUsers;
            }
            if (txtCreateAdminPassword1.Text != null)
            {
                txtCreateAdminPassword1.ForeColor = Color.Black;
                txtCreateAdminPassword1.Text = "";
                txtCreateAdminPassword1.PasswordChar = '*';
                txtCreateAdminPassword1.Text = createdAdmin.passwordUsers;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtCreateAdminPassword.Text == txtCreateAdminPassword1.Text)
            {
                createdAdmin.passwordUsers = txtCreateAdminPassword.Text;
            }
            else
            {
                txtCreateAdminPassword.Clear();
                txtCreateAdminPassword1.Clear();
            }

            if (IsValidData())
            {
                createdAdmin.firstNameUsers = txtCreateAdminFirstName.Text;
                createdAdmin.lastNameUsers = txtCreateAdminLastName.Text;
                createdAdmin.emailUsers = txtCreateAdminEmail.Text;
                createdAdmin.phoneUsers = txtCreateAdminPhone.Text;
                    
                createdAdmin.passwordUsers = EncriptString.Encrypt(txtCreateAdminPassword.Text, "testEncript"); //Salt/Key
                createdAdmin.roleUsers = "admin";
                createdAdmin.updatedUsers = DateTime.Today;
                createdAdmin.createdUsers = DateTime.Today;
                createdAdmin.approvedUsers = "1";

                this.creativity = createdAdmin;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtCreateAdminFirstName) &&
                Validator.IsPresent(txtCreateAdminLastName) &&
                Validator.IsValidString(txtCreateAdminFirstName) &&
                Validator.IsValidString(txtCreateAdminLastName) &&
                Validator.IsValidName(txtCreateAdminFirstName) &&
                Validator.IsValidName(txtCreateAdminLastName) &&
                Validator.IsValidPassword(txtCreateAdminPassword) &&
                Validator.IsValidEmail(txtCreateAdminEmail) &&
                Validator.IsValidString(txtCreateAdminEmail) &&
                Validator.IsWithinRangeString(txtCreateAdminPhone, 11, 11)&&
                Validator.IsInt32(txtCreateAdminPhone);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
