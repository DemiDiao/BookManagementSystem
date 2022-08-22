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
    public partial class EmployeeManage : Form
    {
        public EmployeeManage()
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            MISManage mis = new MISManage();
            mis.Show();
        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            if(Validator.IsInt(textBoxEmployeeID.Text)
                && Validator.IsUniqueID(EmployeeDA.GetListID(), Convert.ToInt32(textBoxEmployeeID.Text))
                && Validator.IsInt(textBox_UserID.Text)
                && Validator.IsUniqueID(EmployeeDA.GetListID(), Convert.ToInt32(textBoxEmployeeID.Text))
                && Validator.IsLetter(textBoxFirstName.Text) && Validator.IsLetter(textBoxLastName.Text)
                && maskedTextBoxPhoneNumber.Text.Length == 14 && Validator.IsEmail(textBoxEmail.Text))
            {           
                Employee employee = new Employee();
                employee.EmployeeID = Convert.ToInt32(textBoxEmployeeID.Text);
                employee.UserID = Convert.ToInt32(textBox_UserID.Text);
                employee.FirstName = textBoxFirstName.Text;
                employee.LastName = textBoxLastName.Text;
                employee.PhoneNumber = maskedTextBoxPhoneNumber.Text;
                employee.Email = textBoxEmail.Text;
                EmployeeDA.AddEmployee(employee);
                ClearAll();
                listEmployees.Items.Clear();
                EmployeeDA.ListEmployees(listEmployees);
           
            }else if(!(Validator.IsLetter(textBoxFirstName.Text) && Validator.IsLetter(textBoxLastName.Text)))
            {
                MessageBox.Show("First name and last name can only be letters！");
            }else if(maskedTextBoxPhoneNumber.Text.Length != 14)
            {
                MessageBox.Show("Length of phone number is not correct！");
            }else if (!Validator.IsEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Email is not correct！");
            }
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

        private void buttonListEmployees_Click(object sender, EventArgs e)
        {
            listEmployees.Items.Clear();
            EmployeeDA.ListEmployees(listEmployees);
        }

        public void ClearAll()
        {
            textBoxEmployeeID.Clear();
            textBox_UserID.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            maskedTextBoxPhoneNumber.Clear();
            textBoxEmail.Clear();
            textBoxInput.Clear();

        }



        private void buttonSearch_Click(object sender, EventArgs e)
        {

            int choice = comboBoxChoice.SelectedIndex;
            switch (choice)
            {
                case -1:
                    {  // IF the user NOT select any search option

                        MessageBox.Show("Please, select at least one Search Option");
                        break;
                    }
                case 0:
                    {
                        if (textBoxInput.Text.Length != 0)
                        {
                            if (Validator.IsInt(textBoxInput.Text))
                            {                            
                            listEmployees.Items.Clear();
                            EmployeeDA.SearchByEmployeeID(Convert.ToInt32(textBoxInput.Text), listEmployees);
                            ClearAll();
                            }
                            else
                            {
                                MessageBox.Show("Inut an Integer please!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Inut the EmployeeID please!");
                        }
                        break;

                    }
                case 1:
                    {
                        if (textBoxInput.Text.Length != 0)
                        {
                            if (Validator.IsInt(textBoxInput.Text))
                            {                          
                            listEmployees.Items.Clear();
                            EmployeeDA.SearchByUserID(Convert.ToInt32(textBoxInput.Text), listEmployees);
                            ClearAll();
                            }else
                            {
                                MessageBox.Show("Inut an Integer please!");
                            }
                        }
                        else
                        {

                            MessageBox.Show("Inut the UserID please!");
                        }
                        break;
                        
                    }
                case 2:
                    {
                        if (textBoxInput.Text.Length != 0)
                        {
                            listEmployees.Items.Clear();
                            EmployeeDA.SearchByFirstName(textBoxInput.Text, listEmployees);
                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("Input the First Name please!");
                        }
                        break;
                    }
                case 3:
                    {
                        if (textBoxInput.Text.Length != 0)
                        {
                            listEmployees.Items.Clear();
                            EmployeeDA.SearchByLastName(textBoxInput.Text, listEmployees);
                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("Input the Last Name please!");
                        }
                        break;
                    }
                case 4:
                    {
                        if (textBoxInput.Text.Length != 0)
                        {
                            listEmployees.Items.Clear();
                            string s = textBoxInput.Text;
                            string phoneNumber = "(" + s.Substring(0, 3) + ") " + s.Substring(3, 3) + "-" + s.Substring(6, 4);
                            EmployeeDA.SearchByPhoneNumber(phoneNumber, listEmployees);
                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("Input the Phone Number please!");
                        }
                        break;
                    }
                case 5:
                    {
                        if (textBoxInput.Text.Length != 0)
                        {
                            listEmployees.Items.Clear();
                            EmployeeDA.SearchByEmail(textBoxInput.Text, listEmployees);
                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("Input the Email please!");
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
                    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUserID_Click(object sender, EventArgs e)
        {

        }

        private void textBox_UserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelInfo_Click(object sender, EventArgs e)
        {

        }

        private void labelPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxChoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxPhoneNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void listEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelEmployeeID_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
