using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BookBizMS.GUI;
using BookBizMS.BLL;


namespace BookBizMS.DAL
{
    public static class EmployeeDA
    {
        private static string filePath = Application.StartupPath + @"\Data\employee.dat";
        private static string fileTemp = Application.StartupPath + @"\Data\Temp.dat";
        public static void ListEmployees(ListView listViewEmployees)
        {


            StreamReader sReader = new StreamReader(filePath);
            listViewEmployees.Items.Clear();


            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);
                item.SubItems.Add(fields[2]);
                item.SubItems.Add(fields[3]);
                item.SubItems.Add(fields[4]);
                item.SubItems.Add(fields[5]);

                listViewEmployees.Items.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close();

        }

        public static List<Employee> ListEmployees()
        {

            List<Employee> employees = new List<Employee>();
            StreamReader sReader = new StreamReader(filePath);
            


            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                Employee employee = new Employee();
                employee.EmployeeID = Convert.ToInt32(fields[0]);
                employee.UserID = Convert.ToInt32(fields[1]);
                employee.FirstName = fields[2];               
                employee.LastName = fields[3];
                employee.PhoneNumber = fields[4];
                employee.Email = fields[5];

                employees.Add(employee);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return employees;
        }


        public static void AddEmployee(Employee employee)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(employee.EmployeeID + "," + employee.UserID + "," + employee.FirstName + "," + employee.LastName + "," + employee.PhoneNumber + "," + employee.Email);
            sWriter.Close();
            MessageBox.Show("Employee data is added!");

        }

        public static List<int> GetListID()
        {
            List<int> listID = new List<int>();
            StreamReader sReader = new StreamReader(filePath);


            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                listID.Add(Convert.ToInt32(fields[0]));

                line = sReader.ReadLine();
            }
            sReader.Close();
            return listID;
        }

        public static void SearchByEmployeeID(int employeeID, ListView listViewEmployee)
        {


            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewEmployee.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (employeeID == Convert.ToInt32(fields[0]))
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);

                    listViewEmployee.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();


        }

        public static void SearchByUserID(int userID, ListView listViewEmployee)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewEmployee.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (userID == Convert.ToInt32(fields[0]))
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);

                    listViewEmployee.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();

        }

        public static void SearchByFirstName(string firstName, ListView listViewEmployee)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewEmployee.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (firstName == fields[2])
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);

                    listViewEmployee.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();

        }

        public static void SearchByLastName(string lastName, ListView listViewEmployee)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewEmployee.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (lastName == fields[3])
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);

                    listViewEmployee.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();

        }

        public static void SearchByPhoneNumber(string phoneNumber, ListView listViewEmployee)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewEmployee.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (phoneNumber == fields[4])
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);

                    listViewEmployee.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();

        }

        public static void SearchByEmail(string email, ListView listViewEmployee)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewEmployee.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (email == fields[5])
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);

                    listViewEmployee.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();

        }
    }
}
