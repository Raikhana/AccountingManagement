/*
 * Author - Raikhana Urazbaeva 
 * Form - for employees to start an application and use for navigation and authentication
 * June 2019
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Project 
{
    public partial class MainForm : Form
    {
        private int originalWidth = 240;
        private int originalHeight = 640;
        public int about = 0;
        public int login = 0;
        public int singUp = 0;
        public int admin = 0;
        public int help = 0;
        public UsersClass createdProfile = new UsersClass();
        public UsersClass creativityProfile { get; set; }
        public MainForm()
        {
            InitializeComponent();

            pictureBoxAbout.Image = new Bitmap(pictureBoxAbout.Width, pictureBoxAbout.Height);
            pictureBoxLogin.Image = new Bitmap(pictureBoxLogin.Width, pictureBoxLogin.Height);
            pictureBoxSingUp.Image = new Bitmap(pictureBoxSingUp.Width, pictureBoxSingUp.Height);
            pictureBoxAdmin.Image = new Bitmap(pictureBoxAdmin.Width, pictureBoxAdmin.Height);
            pictureBoxHelp.Image = new Bitmap(pictureBoxHelp.Width, pictureBoxHelp.Height);
            pictureBoxClose.Image = new Bitmap(pictureBoxClose.Width, pictureBoxClose.Height);
        }
        private string newcolor = "White";

        public static string Title { get; set; } = "Entry Error";
        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureBoxAbout.BackColor = Color.FromArgb(33, 150, 243);
            pictureBoxLogin.BackColor = Color.FromArgb(33, 150, 243);
            pictureBoxSingUp.BackColor = Color.FromArgb(33, 150, 243);
            pictureBoxAdmin.BackColor = Color.FromArgb(33, 150, 243);
            pictureBoxHelp.BackColor = Color.FromArgb(33, 150, 243);
            pictureBoxClose.BackColor = Color.FromArgb(33, 150, 243);

            tabPageAbout.Visible = false;
            tabPageLogin.Visible = false;
            tabPageAdmin.Visible = false;
            tabPageSingUp.Visible = false;
            tabPageHelp.Visible = false;
            label1.Visible = false;
            this.Size = new Size(240, 640);
        }

        public void SmallForm()
        {
            pictureBoxAbout.BackColor = Color.FromArgb(33, 150, 243);
            pictureBoxLogin.BackColor = Color.FromArgb(33, 150, 243);
            pictureBoxSingUp.BackColor = Color.FromArgb(33, 150, 243);
            pictureBoxAdmin.BackColor = Color.FromArgb(33, 150, 243);
            pictureBoxHelp.BackColor = Color.FromArgb(33, 150, 243);
            pictureBoxClose.BackColor = Color.FromArgb(33, 150, 243);

            tabPageAbout.Visible = false;
            tabPageLogin.Visible = false;
            tabPageAdmin.Visible = false;
            tabPageSingUp.Visible = false;
            tabPageHelp.Visible = false;
            label1.Visible = false;
            this.Size = new Size(240, 640);
        }

        private const string pathAbout = (@"..\..\texts\New Text Document.txt");
        private const string pathAbout2 = (@"..\..\texts\New Text Document (2).txt");
        private const string pathAbout3 = (@"..\..\texts\New Text Document (3).txt");
        private void btnAbout_Click(object sender, EventArgs e)
        {
            ColorPressed();

            if (about == 0)
            {
                this.Width = 840;
                this.Height = 640;
                about = 1;
                login = 0;
                singUp = 0;
                admin = 0;
                help = 0;
                btnAbout.BackColor = Color.FromArgb(255, 196, 0);
            }
            else
            {
                this.Width = originalWidth;
                this.Height = originalHeight;
                about = 0;
            }

            tabControl1.SelectTab(tabPageAbout);
            label1.Visible = true;
            tabControl1.SelectTab(tabPageAbout);
            label15.Text = File.ReadAllText(pathAbout);
            label16.Text = File.ReadAllText(pathAbout2);
            label17.Text = File.ReadAllText(pathAbout3);
        }

        private void ColorPressed()
        {
            btnAbout.BackColor = Color.FromArgb(33, 150, 243);
            btnLogin.BackColor = Color.FromArgb(33, 150, 243);
            btnSignUp.BackColor = Color.FromArgb(33, 150, 243);
            btnAdmin.BackColor = Color.FromArgb(33, 150, 243);
            btnHelp.BackColor = Color.FromArgb(33, 150, 243);
            btnClose.BackColor = Color.FromArgb(33, 150, 243);
        }

        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxAbout.BackColor = Color.FromArgb(33, 150, 243);
            pictureBoxAbout.Refresh();
        }

        private void btnAbout_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxAbout.BackColor = Color.FromArgb(255, 196, 0);
            pictureBoxAbout.Refresh();
        }

        private void pictureBoxAbout_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Bitmap bmp = new Bitmap(@"..\..\icons\posterous-spaces-2-32.png"))
            {
                picture(g, bmp);
            }
        }

        private void picture(Graphics g, Bitmap bmp)
        {
            Bitmap resized = new Bitmap(bmp, new Size(32,32));
            // Set the image attribute's color mappings
            ColorMap[] colorMap = new ColorMap[1];
            colorMap[0] = new ColorMap();
            colorMap[0].OldColor = Color.Black;
            colorMap[0].NewColor = Color.FromName(newcolor);
            ImageAttributes attr = new ImageAttributes();
            attr.SetRemapTable(colorMap);
            // Draw using the color map
            Rectangle rect = new Rectangle(0, 0, resized.Width, resized.Height);
            g.DrawImage(resized, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ColorPressed();

            if (login == 0)
            {
                this.Width = 840;
                this.Height = 640;
                login = 1;
                about = 0;
                singUp = 0;
                admin = 0;
                help = 0;
                btnLogin.BackColor = Color.FromArgb(255, 196, 0);
            }
            else
            {
                this.Width = originalWidth;
                this.Height = originalHeight;
                login = 0;
            }
            tabControl1.SelectTab(tabPageLogin);

            txtEmailLogin.Text = "Enter email";
            txtEmailLogin.ForeColor = Color.Gray;
            txtPasswordLodin.PasswordChar = '\0'; // Reset stars in password
            txtPasswordLodin.Text = "Enter password";
            txtPasswordLodin.ForeColor = Color.Gray;
        }

        private void txtEmailLogin_Enter(object sender, EventArgs e)
        {
            txtEmailLogin.Text = null;
            txtEmailLogin.ForeColor = Color.Black;

            txtEmailLogin.Text = "";
        }

        private void txtPasswordLodin_Enter(object sender, EventArgs e)
        {
            txtPasswordLodin.Text = null;
            txtPasswordLodin.ForeColor = Color.Black;

            txtPasswordLodin.Text = "";
            txtPasswordLodin.PasswordChar = '*';
        }

        private void btnLoginLogin_Click(object sender, EventArgs e)  
        {
            if (IsValidData())
            {
                UsersClass user;
                user = UsersDB_Class.GetUser(txtEmailLogin.Text);
                if (user == null)
                {
                    MessageBox.Show("Email incorrect!", Title);
                    txtEmailLogin.Clear();
                    txtEmailLogin.Focus();
                }
                else
                {
                    int user_id = user.userID;
                    // Дешифровка пароля из базы данных и сравнивание с введенным паролем из текстбокса
                    string textboxPassword = EncriptString.Decrypt(user.passwordUsers, "testEncript");
                    if (txtPasswordLodin.Text == textboxPassword)
                    {
                        Users modifFormUsers = new Users(user_id);
                        modifFormUsers.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password incorrect!", Title);
                        txtPasswordLodin.Clear();
                        txtPasswordLodin.Focus();
                    }
                }
            }
        }
        private void btnForgotLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact the administrator",
            "The Question",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxLogin.BackColor = Color.FromArgb(33, 150, 243);
            pictureBoxLogin.Refresh();
        }

        private void btnLogin_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxLogin.BackColor = Color.FromArgb(255, 196, 0);
            pictureBoxLogin.Refresh();
        }

        private void pictureBoxLogin_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Bitmap bmp = new Bitmap(@"..\..\icons\posterous-spaces-2-32.png"))
            {
                Bitmap resized = new Bitmap(bmp, new Size(32,32));
                // Set the image attribute's color mappings
                ColorMap[] colorMap = new ColorMap[1];
                colorMap[0] = new ColorMap();
                colorMap[0].OldColor = Color.Black;
                colorMap[0].NewColor = Color.FromName(newcolor);
                ImageAttributes attr = new ImageAttributes();
                attr.SetRemapTable(colorMap);
                // Draw using the color map
                Rectangle rect = new Rectangle(0, 0, resized.Width, resized.Height);
                g.DrawImage(resized, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);
            }
        }
        UsersClass user = new UsersClass();
        private void btnSignUp_Click(object sender, EventArgs e)     
        {
            ColorPressed();

            if (singUp == 0)
            {
                this.Width = 840;
                this.Height = 640;
                singUp = 1;
                about = 0;
                login = 0;
                admin = 0;
                help = 0;
                btnSignUp.BackColor = Color.FromArgb(255, 196, 0);
            }
            else
            {
                this.Width = originalWidth;
                this.Height = originalHeight;
                singUp = 0;
            }
            tabControl1.SelectTab(tabPageSingUp);
            txtSingUpClear();
            txtSingUpPassword.Text = "";
            txtSingUpPassword.PasswordChar = '*';
            txtSingUpConfirm.Text = "";
            txtSingUpConfirm.PasswordChar = '*';
            
        }


        private void btnSingUpForm_Click(object sender, EventArgs e)
        {
            if (txtSingUpPassword.Text == txtSingUpConfirm.Text)
            {
                createdProfile.passwordUsers = txtSingUpPassword.Text;
                if (IsValidDataSingUp())
                {
                    createdProfile.firstNameUsers = txtSingUpFirstName.Text;
                    createdProfile.lastNameUsers = txtSingUpLastName.Text;
                    createdProfile.emailUsers = txtSingUpEmail.Text;
                    createdProfile.phoneUsers = txtSingUpPhone.Text;
                    createdProfile.passwordUsers = EncriptString.Encrypt(txtSingUpPassword.Text, "testEncript");
                    createdProfile.roleUsers = "user";
                    createdProfile.updatedUsers = DateTime.Today;
                    createdProfile.createdUsers = DateTime.Today;
                    createdProfile.approvedUsers = "0";

                    this.creativityProfile = createdProfile;
                    UsersDB_Class.CreateProfile(createdProfile);
                    MessageBox.Show("Please wait for approval.");

                    txtSingUpClear();
                }
            }
            else
            {
                MessageBox.Show("Password and confirm password do not match", Title);
                txtSingUpPassword.Clear();
                txtSingUpConfirm.Clear();
            }
        }

        private void txtSingUpClear()
        {
            txtSingUpFirstName.Clear();
            txtSingUpLastName.Clear();
            txtSingUpEmail.Clear();
            txtSingUpPhone.Clear();
            txtSingUpPassword.Clear();
            txtSingUpConfirm.Clear();
        }

        private bool IsValidDataSingUp()
        {
            return
                Validator.IsWithinRangeString(txtSingUpPhone, 11, 11) &&
                Validator.IsInt32(txtSingUpPhone) &&
                Validator.IsPresent(txtSingUpFirstName) &&
                Validator.IsPresent(txtSingUpLastName) &&
                Validator.IsValidString(txtSingUpFirstName) &&
                Validator.IsValidString(txtSingUpLastName) &&
                Validator.IsValidName(txtSingUpFirstName) &&
                Validator.IsValidName(txtSingUpLastName) &&
                Validator.IsValidPassword(txtSingUpPassword) &&
                Validator.IsValidEmail(txtSingUpEmail);
        }

        private void btnSignUp_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSingUp.BackColor = Color.FromArgb(33, 150, 243);
            pictureBoxSingUp.Refresh();
        }

        private void btnSignUp_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSingUp.BackColor = Color.FromArgb(255, 196, 0);
            pictureBoxSingUp.Refresh();
        }

        private void pictureBoxSingUp_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Bitmap bmp = new Bitmap(@"..\..\icons\posterous-spaces-2-32.png"))
            {
                Bitmap resized = new Bitmap(bmp, new Size(32,32));
                // Set the image attribute's color mappings
                ColorMap[] colorMap = new ColorMap[1];
                colorMap[0] = new ColorMap();
                colorMap[0].OldColor = Color.Black;
                colorMap[0].NewColor = Color.FromName(newcolor);
                ImageAttributes attr = new ImageAttributes();
                attr.SetRemapTable(colorMap);
                // Draw using the color map
                Rectangle rect = new Rectangle(0, 0, resized.Width, resized.Height);
                g.DrawImage(resized, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)   
        {
            ColorPressed();

            if (admin == 0)
            {
                this.Width = 840;
                this.Height = 640;
                admin = 1;
                about = 0;
                login = 0;
                singUp = 0;
                help = 0;
                btnAdmin.BackColor = Color.FromArgb(255, 196, 0);
            }
            else
            {
                this.Width = originalWidth;
                this.Height = originalHeight;
                admin = 0;
            }
            tabControl1.SelectTab(tabPageAdmin);
           
            txtPasswordAdmin.Text = "Enter password";
            txtPasswordAdmin.ForeColor = Color.Gray;
            txtPasswordAdmin.PasswordChar = '\0'; // Reset stars in password
            txtEmailAdmin.Text = "Enter email";
            txtEmailAdmin.ForeColor = Color.Gray;                  
        }
        

        private void txtEmailAdmin_Enter(object sender, EventArgs e)
        {
            txtEmailAdmin.Text = null;
            txtEmailAdmin.ForeColor = Color.Black;
            txtEmailAdmin.Text = "";
        }

        private void txtPasswordAdmin_Enter(object sender, EventArgs e)
        {
            txtPasswordAdmin.Text = null;
            txtPasswordAdmin.ForeColor = Color.Black;
            txtPasswordAdmin.Text = "";
            txtPasswordAdmin.PasswordChar = '*';
        }
        

        private void btnLoginAdmin_Click(object sender, EventArgs e)    /////////////
        {
            if (IsValidDataAdmin())
            {
                UsersClass admin;
                admin = UsersDB_Class.GetAdmin(txtEmailAdmin.Text);
                if (admin == null)
                {
                    MessageBox.Show("Email incorrect!", Title);
                    txtEmailAdmin.Clear();
                    txtEmailAdmin.Focus();
                }
                else
                {
                    string textboxPassword = EncriptString.Decrypt(admin.passwordUsers, "testEncript");
                    if (txtPasswordAdmin.Text == textboxPassword)
                    {
                        Admin modifFormAdmin = new Admin();
                        modifFormAdmin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password incorrect!", Title);
                        txtPasswordAdmin.Clear();
                        txtPasswordAdmin.Focus();
                    }
                }
            }
        }

        private void btnForgotAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact the administrator",
           "The Question",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
        }

        private void btnAdmin_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxAdmin.BackColor = Color.FromArgb(33, 150, 243);
            pictureBoxAdmin.Refresh();
        }

        private void btnAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxAdmin.BackColor = Color.FromArgb(255, 196, 0);
            pictureBoxAdmin.Refresh();
        }

        private void pictureBoxAdmin_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Bitmap bmp = new Bitmap(@"..\..\icons\posterous-spaces-2-32.png"))
            {
                Bitmap resized = new Bitmap(bmp, new Size(32,32));
                // Set the image attribute's color mappings
                ColorMap[] colorMap = new ColorMap[1];
                colorMap[0] = new ColorMap();
                colorMap[0].OldColor = Color.Black;
                colorMap[0].NewColor = Color.FromName(newcolor);
                ImageAttributes attr = new ImageAttributes();
                attr.SetRemapTable(colorMap);
                // Draw using the color map
                Rectangle rect = new Rectangle(0, 0, resized.Width, resized.Height);
                g.DrawImage(resized, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);
            }
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            ColorPressed();

            if (help == 0)
            {
                this.Width = 840;
                this.Height = 640;
                help = 1;
                about = 0;
                login = 0;
                singUp = 0;
                admin = 0;
                btnHelp.BackColor = Color.FromArgb(255, 196, 0);
            }
            else
            {
                this.Width = originalWidth;
                this.Height = originalHeight;
                help = 0;
            }
            tabControl1.SelectTab(tabPageHelp);
        }

        private void btnHelp_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxHelp.BackColor = Color.FromArgb(33, 150, 243);
            pictureBoxHelp.Refresh();
        }

        private void btnHelp_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxHelp.BackColor = Color.FromArgb(255, 196, 0);
            pictureBoxHelp.Refresh();
        }

        private void pictureBoxHelp_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Bitmap bmp = new Bitmap(@"..\..\icons\posterous-spaces-2-32.png"))
            {
                Bitmap resized = new Bitmap(bmp, new Size(32, 32));
                // Set the image attribute's color mappings
                ColorMap[] colorMap = new ColorMap[1];
                colorMap[0] = new ColorMap();
                colorMap[0].OldColor = Color.Black;
                colorMap[0].NewColor = Color.FromName(newcolor);
                ImageAttributes attr = new ImageAttributes();
                attr.SetRemapTable(colorMap);
                // Draw using the color map
                Rectangle rect = new Rectangle(0, 0, resized.Width, resized.Height);
                g.DrawImage(resized, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)    
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to close this window?", "Small form", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                SmallForm();
            }
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClose.BackColor = Color.FromArgb(33, 150, 243);
            pictureBoxClose.Refresh();
        }

        private void btnClose_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxClose.BackColor = Color.FromArgb(255, 196, 0);
            pictureBoxClose.Refresh();
        }

        private void pictureBoxClose_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Bitmap bmp = new Bitmap(@"..\..\icons\posterous-spaces-2-32.png"))
            {
                Bitmap resized = new Bitmap(bmp, new Size(32, 32));
                // Set the image attribute's color mappings
                ColorMap[] colorMap = new ColorMap[1];
                colorMap[0] = new ColorMap();
                colorMap[0].OldColor = Color.Black;
                colorMap[0].NewColor = Color.FromName(newcolor);
                ImageAttributes attr = new ImageAttributes();
                attr.SetRemapTable(colorMap);
                // Draw using the color map
                Rectangle rect = new Rectangle(0, 0, resized.Width, resized.Height);
                g.DrawImage(resized, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);
            }
        }
        private bool IsValidData()
        {
            return
                Validator.IsValidEmail(txtEmailLogin) &&
                Validator.IsValidString(txtEmailLogin);
        }
        private bool IsValidDataAdmin()
        {
            return
                Validator.IsValidEmail(txtEmailAdmin) &&
                Validator.IsValidString(txtEmailAdmin);
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabControl1.TabPages[e.Index];
            Color col = e.Index == 0 ? Color.FromArgb(33, 150, 243) : Color.FromArgb(33, 150, 243);
            e.Graphics.FillRectangle(new SolidBrush(col), e.Bounds);

            Rectangle paddedBounds = e.Bounds;
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            paddedBounds.Offset(1, yOffset);
            TextRenderer.DrawText(e.Graphics, page.Text, Font, paddedBounds, page.ForeColor);
        }

        private void tabPageAbout_Click(object sender, EventArgs e)
        {

        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            Map map = new Map();
            map.Show();
        }
    }
}
