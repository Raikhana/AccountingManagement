/*
 * Author - Raikhana Urazbaeva 
 * Form - For admin to add, modify, delete and manage users 
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();  // hide column
            listView1.Columns[8].Width = 0;
            listView1.ColumnWidthChanging += listView1_ColumnWidthChanging;
        }
        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                e.NewWidth = 0;
                e.Cancel = true;
            }
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            FillListView();
        }
       
        private void FillListView()
        {
            listView1.Columns[0].ListView.Font = new Font(listView1.Columns[0].ListView.Font, FontStyle.Bold);
            listView1.Items.Clear();
            List<UsersClass> users = new List<UsersClass>();
            users = UsersDB_Class.GetUsers();

            foreach (UsersClass user in users)
            {
                if (user.approvedUsers == "0")
                {
                    user.approvedUsers = "waiting";
                }
                else
                {
                    user.approvedUsers = "approved";
                }
                string[] row = {
                                    user.firstNameUsers,
                                    user.lastNameUsers,
                                    user.phoneUsers,
                                    user.emailUsers,
                                    user.approvedUsers,
                                    user.createdUsers.ToString("d"),
                                    user.updatedUsers.ToString("d"),
                                    user.roleUsers,
                                    user.passwordUsers,
                                    user.userID.ToString()
                                };

                    ListViewItem listUser = new ListViewItem(row);
                    listUser.Font = new Font(listUser.Font, FontStyle.Regular);
                    listView1.Items.Add(listUser);
                }
               
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string firstNameUsers = item.SubItems[0].Text;
                string lastNameUsers = item.SubItems[1].Text;
                string phoneUsers = item.SubItems[2].Text;
                string emailUsers = item.SubItems[3].Text;
                string approvedUsers = item.SubItems[4].Text;
                string createdUsers = item.SubItems[5].Text;
                string updatedUsers = item.SubItems[6].Text;
                string roleUsers = item.SubItems[7].Text;
                string passwordUsers = item.SubItems[8].Text;
                string userID = item.SubItems[9].Text;
            }
        }

        private void ApproveUsers_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int userID = Convert.ToInt32(item.SubItems[9].Text);
                bool result = UsersDB_Class.ApproveUsers(userID);
                if (result)
                {
                    FillListView();
                    MessageBox.Show("User approved");
                } else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Please select an user in a list");
            }
        }

        private void btnChangeUsers_Click(object sender, EventArgs e)
        {
            UsersClass userChange = new UsersClass();
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                userChange.firstNameUsers = item.SubItems[0].Text;
                userChange.lastNameUsers = item.SubItems[1].Text;
                userChange.phoneUsers = item.SubItems[2].Text;
                userChange.emailUsers = item.SubItems[3].Text;
                userChange.createdUsers = Convert.ToDateTime(item.SubItems[5].Text);
                userChange.updatedUsers = Convert.ToDateTime(item.SubItems[6].Text);
                userChange.roleUsers = item.SubItems[7].Text;
                userChange.passwordUsers = item.SubItems[8].Text;
                userChange.userID = Convert.ToInt32(item.SubItems[9].Text);

                Change_users updateUser = new Change_users(userChange);
                var result = updateUser.ShowDialog();
                if (result == DialogResult.OK)
                {
                    UsersClass changedUser = updateUser.changes;
                    bool returnedResult = UsersDB_Class.ChangeUsers(userChange);
                    if (returnedResult)
                    {
                        FillListView();
                        MessageBox.Show("User changed");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an user in a list ");
            }
        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
            DialogResult result1 = MessageBox.Show("Delete " + "User" + "?",
            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                    ListViewItem item = listView1.SelectedItems[0];
                    int userID = Convert.ToInt32(item.SubItems[9].Text);
                    bool result = UsersDB_Class.DeleteUsers(userID);
                    if (result)
                    {
                        FillListView();
                        MessageBox.Show("User deleted");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an user in a list ");
            }
        }

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            CreateAdmin createAdmin = new CreateAdmin();
            var result = createAdmin.ShowDialog();
            if (result == DialogResult.OK)
            {
                UsersClass createdAdmin = createAdmin.creativity;
                bool returnedResult = UsersDB_Class.CreateAdmin(createdAdmin);
                if (returnedResult)
                {
                    FillListView();
                    MessageBox.Show("Admin created");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm form1 = new MainForm();
            form1.Show();
        }
    }
}
