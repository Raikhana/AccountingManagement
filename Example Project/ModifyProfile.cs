/*
 * Author - Raikhana Urazbaeva 
 * Form - For user to modify and manage their own user profile 
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
    public partial class ModifyProfile : Form
    {
        public UsersClass modify { get; set; }
        public int user_id;
        public ModifyProfile(int userID)
        {
            user_id = userID;
            InitializeComponent();
        }
        UsersClass user = new UsersClass();
        private void ModifyProfile_Load(object sender, EventArgs e)
        {
            user = UsersDB_Class.GetUserByID(user_id.ToString());
            txtModifyProfileFirstName.Text = user.firstNameUsers;
            txtModifyProfileLastName.Text = user.lastNameUsers;
            txtModifyProfileEmail.Text = user.emailUsers;
            txtModifyProfilePhone.Text = user.phoneUsers;
            if (txtModifyProfilePassword.Text != null)
            {
                txtModifyProfilePassword.ForeColor = Color.Black;
                txtModifyProfilePassword.Text = "";
                txtModifyProfilePassword.PasswordChar = '*';
            }
            if (txtModifyProfileConfirm.Text != null)
            {
                txtModifyProfileConfirm.ForeColor = Color.Black;
                txtModifyProfileConfirm.Text = "";
                txtModifyProfileConfirm.PasswordChar = '*';
            }
          
        }
        private void btnModifyProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtModifyProfilePassword.Text == txtModifyProfileConfirm.Text)
                {
                    user.passwordUsers = txtModifyProfilePassword.Text;
                }
                else
                {
                    txtModifyProfilePassword.Clear();
                    txtModifyProfileConfirm.Clear();
                }
                if (IsValidData())
                {
                    user.firstNameUsers = txtModifyProfileFirstName.Text;
                    user.lastNameUsers = txtModifyProfileLastName.Text;
                    user.emailUsers = txtModifyProfileEmail.Text;
                    user. phoneUsers = txtModifyProfilePhone.Text;
                    user.passwordUsers = EncriptString.Encrypt(txtModifyProfilePassword.Text, "testEncript"); //Salt/Key

                    this.modify = user;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }
        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtModifyProfileFirstName) &&
                Validator.IsPresent(txtModifyProfileLastName) &&
                Validator.IsValidString(txtModifyProfileFirstName) &&
                Validator.IsValidString(txtModifyProfileLastName) &&
                Validator.IsValidName(txtModifyProfileFirstName) &&
                Validator.IsValidName(txtModifyProfileLastName) &&
                Validator.IsValidPassword(txtModifyProfilePassword) &&
                Validator.IsValidEmail(txtModifyProfileEmail) &&
                Validator.IsValidString(txtModifyProfileEmail) &&
                Validator.IsWithinRangeString(txtModifyProfilePhone, 11, 11) &&
                Validator.IsInt32(txtModifyProfilePhone);
        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
