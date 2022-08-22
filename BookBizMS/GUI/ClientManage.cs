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
    public partial class ClientManage : Form
    {
        public ClientManage()
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

        private void buttonListEmployeess_Click(object sender, EventArgs e)
        {
            listClients.Items.Clear();
            ClientDA.ListClients(listClients);
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.homePage.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int choice = comboBoxChoice.SelectedIndex;

            switch (choice)
            {
                case -1: // IF  NOT select any search option

                    MessageBox.Show("Please, select at least one Search Option");
                    break;

                case 0:
                    if (textBoxInput.Text.Length != 0)
                    {
                        if (Validator.IsInt(textBoxInput.Text))
                        {
                            listClients.Items.Clear();
                            ClientDA.SearchByClientID(Convert.ToInt32(textBoxInput.Text), listClients);
                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("Inut an Integer please!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inut the ClientID please!");
                    }
                    break;

                case 1:
                    if (textBoxInput.Text.Length != 0)
                    {
                        listClients.Items.Clear();
                        ClientDA.SearchByClientName(textBoxInput.Text, listClients);
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
                        listClients.Items.Clear();
                        ClientDA.SearchByStreetNumber(Convert.ToInt32(textBoxInput.Text), listClients);
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Input the Street Number please!");
                    }
                    break;
                case 3:
                    if (textBoxInput.Text.Length != 0)
                    {
                        listClients.Items.Clear();
                        ClientDA.SearchByStreetName(textBoxInput.Text, listClients);
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Input the Street Name please!");
                    }
                    break;
                case 4:
                    if (textBoxInput.Text.Length != 0)
                    {
                        listClients.Items.Clear();
                        ClientDA.SearchByCity(textBoxInput.Text, listClients);
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Input the Street Name please!");
                    }
                    break;

                case 5:
                    if (textBoxInput.Text.Length != 0)
                    {
                        listClients.Items.Clear();
                        ClientDA.SearchByPostalCode(textBoxInput.Text, listClients);
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Input the Postal Code please!");
                    }
                    break;

                case 6:
                    if (textBoxInput.Text.Length != 0)
                    {
                        listClients.Items.Clear();
                        ClientDA.SearchByPhoneNumber(textBoxInput.Text, listClients);
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Input the Phone Number please!");
                    }
                    break;

                case 7:
                    if (textBoxInput.Text.Length != 0)
                    {
                        listClients.Items.Clear();
                        ClientDA.SearchByFaxNumber(textBoxInput.Text, listClients);
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Input the Fax Number please!");
                    }
                    break;
                case 8:
                    if (Validator.IsEmail(textBoxInput.Text))
                    {
                        listClients.Items.Clear();
                        ClientDA.SearchByEmail(textBoxInput.Text, listClients);
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Input the correct email please!");
                    }
                    break;

                case 9:
                    if (textBoxInput.Text.Length != 0)
                    {
                        listClients.Items.Clear();
                        ClientDA.SearchByCreditLimit(Convert.ToDouble(textBoxInput.Text), listClients);
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Input the correct Credit Limit please!");
                    }
                    break;



                default:   // IF the user NOT select an option on the  search combo box
                    break;
            }
        }
        public void ClearAll()
        {
            textBoxClientID.Clear();
            textBoxClientName.Clear();
            textBoxStreetNumber.Clear();
            textBoxStreetName.Clear();
            textBoxCity.Clear();
            textBoxPostalCode.Clear();
            maskedTextBoxPhoneNumber.Clear();
            maskedTextBoxFaxNumber.Clear();
            textBoxEmail.Clear();
            maskedTextBoxCreditLimit.Clear();
            textBoxInput.Clear();

        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            if (Validator.IsInt(textBoxClientID.Text)
                && Validator.IsUniqueID(ClientDA.GetListID(), Convert.ToInt32(textBoxClientID.Text))
                && Validator.IsInt(textBoxStreetNumber.Text)             
                && Validator.IsLetter(textBoxClientName.Text) && Validator.IsLetter(textBoxStreetName.Text)
                && maskedTextBoxPhoneNumber.Text.Length == 14 && maskedTextBoxFaxNumber.Text.Length == 14
                && Validator.IsEmail(textBoxEmail.Text) && textBoxPostalCode.Text.Length == 6)
            {
                Client client = new Client();
                client.ClientID = Convert.ToInt32(textBoxClientID.Text);
                client.ClientName = textBoxClientName.Text;
                client.StreetNumber = Convert.ToInt32(textBoxStreetNumber.Text);
                client.StreetName = textBoxStreetName.Text;
                client.City = textBoxCity.Text;
                client.PostalCode = textBoxPostalCode.Text;
                client.PhoneNumber = maskedTextBoxPhoneNumber.Text;
                client.FaxNumber = maskedTextBoxFaxNumber.Text;
                client.Email = textBoxEmail.Text;
                client.CreditLimit = Convert.ToDouble(maskedTextBoxCreditLimit.Text);

                ClientDA.AddClient(client);
                ClearAll();
                listClients.Items.Clear();
                ClientDA.ListClients(listClients);
            }
            else if (!Validator.IsInt(textBoxClientID.Text))
            {
                MessageBox.Show("Input an Integer for ClienteID  please！");
            }
            else if (!Validator.IsLetter(textBoxClientName.Text))
            {
                MessageBox.Show("Client name can only be letters！");
            }
            else if (!Validator.IsInt(textBoxStreetNumber.Text))
            {
                MessageBox.Show("Input an Integer for Street Number please！");
            }
            else if (!Validator.IsLetter(textBoxStreetName.Text))
            {
                MessageBox.Show("Street name can only be letters！");
            }
            else if (textBoxPostalCode.Text.Length != 6)
            {
                MessageBox.Show("Length of postal code is not correct！");
            }
            else if (!(maskedTextBoxPhoneNumber.Text.Length == 14 && maskedTextBoxFaxNumber.Text.Length == 14))
            {
                MessageBox.Show("Length of phone number is not correct！");
            }
            else if (!Validator.IsEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Email is not correct！");
            }
        }
    }

}   


