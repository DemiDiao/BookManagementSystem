using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBizMS.BLL;
using BookBizMS.DAL;
using BookBizMS.Validation;

namespace BookBizMS.GUI
{
    public partial class UserManage : Form
    {
        public UserManage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            MISManage mis = new MISManage();
            mis.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int choice = comboBoxChoice.SelectedIndex;

            switch (choice)
            {
                case -1: // IF the user NOT select any search option

                    MessageBox.Show("Please, select at least one Search Option");
                    break;

                case 0:

                    if (textBoxInput.Text.Length != 0)
                    {
                        if (Validator.IsInt(textBoxInput.Text))
                        {
                            listUser.Items.Clear();
                            UserDA.SearchByID(Convert.ToInt32(textBoxInput.Text), listUser);
                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("Inut an Integer please!");
                        }
                    }
                    else
                    {

                        MessageBox.Show("Inut the UserID please!");
                    }
                    break;

                case 1:
                    

                    if (textBoxInput.Text.Length != 0)
                    {
                        listUser.Items.Clear();
                        UserDA.SearchByName(textBoxInput.Text, listUser);
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Input the User Name please!");
                    }
                    break;



                default:   // IF the user NOT select an option on the  search combo box
                    break;
            }
        }

        private void UserManage_Load(object sender, EventArgs e)
        {

        }

        private void buttonListUser_Click(object sender, EventArgs e)
        {
            listUser.Items.Clear();
            UserDA.ListUsers(listUser);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure to exit the application?", "Confirmation",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void ClearAll()
        { 
            textBoxUserID.Clear();
            textBoxUserName.Clear();
            textBoxPassword.Clear();
            textBoxInput.Clear();

        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            if (Validator.IsInt(textBoxUserID.Text) 
                && Validator.IsUniqueID(UserDA.GetListID(), Convert.ToInt32(textBoxUserID.Text))
                && Validator.IsLetter(textBoxUserName.Text)
                && textBoxPassword.Text.Length != 0)
            {          
                User user = new User();
                user.UserID = Convert.ToInt32(textBoxUserID.Text);
                user.UserName=textBoxUserName.Text;
                user.Password=textBoxPassword.Text;
            
                UserDA.AddUser(user);
                ClearAll();
                listUser.Items.Clear();
                UserDA.ListUsers(listUser);


            }
            else if (!Validator.IsInt(textBoxUserID.Text))
            {
                MessageBox.Show("Inut an Integer for UserID please!");
            }else if(!Validator.IsLetter(textBoxUserName.Text))
            {
                MessageBox.Show("User name can only be letters!");
            }else if(textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Inut a password please!");
            }
        }
    }
}
