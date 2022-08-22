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
using BookBizMS.Validation;
using BookBizMS.DAL;
using System.IO;

namespace BookBizMS.GUI
{
    public partial class HomePage : System.Windows.Forms.Form
    {
       
         String userName; 
         String password;
        public HomePage()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            userName = comboBoxUserName.Text.ToString();
            


        }

        private void labelAppName_Click(object sender, EventArgs e)
        {

        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSignin_Click(object sender, EventArgs e)
        {
            if (UserDA.PasswordValid(userName, password))
            {             

                switch (userName)
                {
                    case "MIS Manager":
                        {
                            textBoxPassword.Clear();
                            MessageBox.Show("Sign in successfully! You are going to enter the MIS Manage window!");
                            MISManage mis = new MISManage();
                            mis.Show();
                            this.Hide();
                            break;
                        }
                    case "Sales Manager":
                        {
                            textBoxPassword.Clear();
                            MessageBox.Show("Sign in successfully! You are going to enter the Sales Manage window!");
                            ClientManage sale = new ClientManage();
                            sale.Show();
                            this.Hide();
                            break;
                        }
                    case "Inventory Controller":
                        {
                            textBoxPassword.Clear();
                            MessageBox.Show("Sign in successfully! You are going to enter the Inventory Manage window!");
                            InventoryManage inv = new InventoryManage();
                            inv.Show();
                            this.Hide();
                            break;
                        }
                    case "Order Clerk A":
                        {
                            textBoxPassword.Clear();
                            MessageBox.Show("Sign in successfully! You are going to enter the Order Manage window!");
                            OrderManage ord = new OrderManage();
                            ord.Show();
                            this.Hide();
                            break;
                        }
                    case "Order Clerk B":
                        {
                            textBoxPassword.Clear();
                            MessageBox.Show("Sign in successfully! You are going to enter the Order Manage window!");
                            OrderManage ord = new OrderManage();
                            ord.Show();
                            this.Hide();
                            break;
                        }
                    default:
                        {
                            textBoxPassword.Clear();
                            MessageBox.Show("Error input, please comfirm the information!");
                            break;
                        }
                }

            }
            
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            password = textBoxPassword.Text;
        }

        
            
            

        
    }  
}
