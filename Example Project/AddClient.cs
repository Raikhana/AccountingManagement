/*
 * Author - Raikhana Urazbaeva 
 * Form - For user to add and manage a client profile 
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
    public partial class AddClient : Form
    {
        public ClientClass addclient = new ClientClass();
        public ClientClass added { get; set; }
       
        public AddClient()
        {
            InitializeComponent();
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                addclient.firstNameClient = txtFirstNameClient.Text;
                addclient. lastNameClient = txtLastNameClient.Text;
                addclient. addressClient = txtAddressClient.Text;
                addclient. companyClient = txtCompanyClient.Text;
                addclient. phoneClient = txtPhoneClient.Text;
                addclient. postalCodeClient = txtPostalCodeClient.Text;
                addclient.paymentClient = comboBoxPayment.Text;
                addclient.emailClient = txtEmailClient.Text;
                addclient. createdClient = DateTime.Today;
                addclient. updatedClient = DateTime.Today;
                addclient.cityClient = txtCityClient.Text;
                addclient.countryClient = txtCountryClient.Text;

                this.added = addclient;
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

                Validator.IsValidEmail(txtEmailClient)&&
                Validator.IsValidString(txtEmailClient) &&

                Validator.IsInt32(txtPhoneClient) &&
                Validator.IsWithinRangeString(txtPhoneClient, 11, 11) &&

                Validator.IsPresentComboBox(comboBoxPayment)&&

                Validator.IsPresent(txtPostalCodeClient) &&
                Validator.IsValidPostalCode(txtPostalCodeClient);
               
        }
        private void btnCloseCLIENT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm form1 = new MainForm();
            form1.Show();
        }
    }
}
