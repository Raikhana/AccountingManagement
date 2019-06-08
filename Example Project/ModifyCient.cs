/*
 * Author - Raikhana Urazbaeva 
 * Form - For user to modify and manage a client profile 
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
    public partial class ModifyCient : Form
    {

        public ClientClass addclient = new ClientClass();
        public ClientClass modified { get; set; }
        public ModifyCient(ClientClass client)
        {
            addclient = client;
            InitializeComponent();
        }
        private void ModifyCient_Load(object sender, EventArgs e)
        {
            txtFirstNameClient.Text = addclient.firstNameClient;
            txtLastNameClient.Text = addclient.lastNameClient;
            txtAddressClient.Text = addclient.addressClient;
            txtCompanyClient.Text = addclient.companyClient;
            txtPhoneClient.Text = addclient.phoneClient;
            txtPostalCodeClient.Text = addclient.postalCodeClient;
            comboBoxPaymentModify.Text = addclient.paymentClient;
            txtEmailClient.Text = addclient.emailClient;
            addclient.updatedClient = DateTime.Today;
            txtCityClient.Text = addclient.cityClient;
            txtCountryClient.Text = addclient.countryClient;
        }
        private void Modify_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                addclient.firstNameClient = txtFirstNameClient.Text;
                addclient.lastNameClient = txtLastNameClient.Text;
                addclient.addressClient = txtAddressClient.Text;
                addclient.companyClient = txtCompanyClient.Text;
                addclient.phoneClient = txtPhoneClient.Text;
                addclient.postalCodeClient = txtPostalCodeClient.Text;
                addclient.paymentClient = comboBoxPaymentModify.Text;
                addclient.emailClient = txtEmailClient.Text;
                addclient.updatedClient = DateTime.Today;
                addclient.cityClient = txtCityClient.Text;
                addclient.countryClient = txtCountryClient.Text;

                this.modified = addclient;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtFirstNameClient) &&
                Validator.IsPresent(txtLastNameClient) &&
                Validator.IsValidString(txtFirstNameClient) &&
                Validator.IsValidString(txtLastNameClient) &&
                Validator.IsValidName(txtFirstNameClient) &&
                Validator.IsValidName(txtLastNameClient) &&
                Validator.IsPresent(txtAddressClient) &&
                Validator.IsValidString(txtAddressClient) &&
                Validator.IsPresent(txtCountryClient) &&
                Validator.IsValidString(txtCountryClient) &&
                Validator.IsPresent(txtCompanyClient) &&
                Validator.IsValidString(txtCompanyClient) &&
                Validator.IsPresent(txtCityClient) &&
                Validator.IsValidString(txtCityClient) &&
                Validator.IsValidEmail(txtEmailClient) &&
                Validator.IsValidString(txtEmailClient) &&
                Validator.IsInt32(txtPhoneClient) &&
                Validator.IsWithinRangeString(txtPhoneClient, 11,  11) &&
                Validator.IsPresent(txtPostalCodeClient) &&
                Validator.IsPresentComboBox(comboBoxPaymentModify)&&
                Validator.IsValidPostalCode(txtPostalCodeClient);
        }

        private void btnCloseCLIENT_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
    }
}
