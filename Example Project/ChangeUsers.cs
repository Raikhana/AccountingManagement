/*
 * Author - Raikhana Urazbaeva 
 * Form - For admin to change a user profile 
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
    public partial class Change_users : Form
    {
        UsersClass changeUser;
        public UsersClass changes { get; set; }
        public Change_users(UsersClass user)
        {
            changeUser = user;
            InitializeComponent();
        }
        private void Change_users_Load(object sender, EventArgs e)
        {
            txtChangeUsersFirstName.Text = changeUser.firstNameUsers;
            txtChangeUsersLastName.Text = changeUser.lastNameUsers;
            txtChangeUsersEmail.Text = changeUser.emailUsers;
            txtChangeUsersPhone.Text = changeUser.phoneUsers;
            comboBoxChangeUsersRole.Text = changeUser.roleUsers;
            if (txtChangeUsersPassword.Text != null)
            {
                txtChangeUsersPassword.ForeColor = Color.Black;

                txtChangeUsersPassword.Text = "";
                txtChangeUsersPassword.PasswordChar = '*';
            }
        }

        private void btnChangeUsers_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                changeUser.firstNameUsers = txtChangeUsersFirstName.Text;
                changeUser.lastNameUsers = txtChangeUsersLastName.Text;
                changeUser.emailUsers = txtChangeUsersEmail.Text;
                changeUser.phoneUsers = txtChangeUsersPhone.Text;
                changeUser.roleUsers = comboBoxChangeUsersRole.Text;
                changeUser.updatedUsers = DateTime.Now;
                changeUser.passwordUsers = EncriptString.Encrypt(txtChangeUsersPassword.Text, "testEncript"); //Salt/Key

                this.changes = changeUser;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtChangeUsersFirstName) &&
                Validator.IsPresent(txtChangeUsersLastName) &&
                Validator.IsPresentComboBox(comboBoxChangeUsersRole) &&
                Validator.IsValidString(txtChangeUsersFirstName) &&
                Validator.IsValidString(txtChangeUsersLastName) &&
                Validator.IsValidName(txtChangeUsersFirstName) &&
                Validator.IsValidName(txtChangeUsersLastName ) &&
                Validator.IsValidPassword(txtChangeUsersPassword) &&
                Validator.IsValidEmail(txtChangeUsersEmail) &&
                Validator.IsValidString (txtChangeUsersEmail) &&
                Validator.IsWithinRangeString(txtChangeUsersPhone, 11, 11)&&
                Validator.IsInt32(txtChangeUsersPhone);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
