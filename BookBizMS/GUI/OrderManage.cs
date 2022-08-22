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
using System.IO;

namespace BookBizMS.GUI
{
    public partial class OrderManage : Form
    {
        public OrderManage()
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.homePage.Show();
        }

        private void buttonListUser_Click(object sender, EventArgs e)
        {
            listOrders.Items.Clear();
            OrderDA.ListOrders(listOrders);
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (Validator.IsInt(textBoxOrderID.Text) 
                && Validator.IsUniqueID(OrderDA.GetListID(), Convert.ToInt32(textBoxOrderID.Text))
                && Validator.IsLetter(textBoxClientName.Text)
                && Validator.IsInt(textBoxQuantity.Text) && textBoxBookName.Text != null)
            {
                Order order = new Order();
                order.OrderID = Convert.ToInt32(textBoxOrderID.Text);
                order.ClientName = textBoxClientName.Text;
                order.BookName = textBoxBookName.Text;
                order.Quantity = Convert.ToInt32(textBoxQuantity.Text);

                OrderDA.AddOrder(order);
                ClearAll();
                listOrders.Items.Clear();
                OrderDA.ListOrders(listOrders);


            }
            else if (!Validator.IsInt(textBoxOrderID.Text))
            {
                MessageBox.Show("Inut an Integer for OrderID please!");
            }
            
            
            else if ((textBoxBookName.Text == null))
            {
                MessageBox.Show("Book name can not be empty!");
            }
            
            
        }

        public void ClearAll()
        {
            textBoxOrderID.Clear();
            textBoxClientName.Clear();
            textBoxBookName.Clear();
            textBoxQuantity.Clear();
            textBoxInput.Clear();

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
                            listOrders.Items.Clear();
                            OrderDA.SearchByOrderID(Convert.ToInt32(textBoxInput.Text), listOrders);
                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("Inut an Integer please!");
                        }
                    }
                    else
                    {

                        MessageBox.Show("Inut the OrderID please!");
                    }
                    break;

                case 1:


                    if (textBoxInput.Text.Length != 0)
                    {
                        listOrders.Items.Clear();
                        OrderDA.SearchByClientName(textBoxInput.Text, listOrders);
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Input the Client Name please!");
                    }
                    break;

                case 2:


                    if (textBoxInput.Text.Length != 0)
                    {
                        listOrders.Items.Clear();
                        OrderDA.SearchByBookName(textBoxInput.Text, listOrders);
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Input the Book Name please!");
                    }
                    break;

                case 3:


                    if (textBoxInput.Text.Length != 0)
                    {
                        listOrders.Items.Clear();
                        OrderDA.SearchByQuantity(Convert.ToInt32(textBoxInput.Text), listOrders);
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Input the quantity please!");
                    }
                    break;


                default:   // IF the user NOT select an option on the  search combo box
                    break;
            }
        }

        private void listOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
