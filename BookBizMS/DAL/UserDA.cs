using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBizMS.BLL;
using BookBizMS.Validation;
using System.Windows.Forms;
using System.IO;
using BookBizMS.GUI;

namespace BookBizMS.DAL
{
    public static class UserDA
    {
        private static string filePath = Application.StartupPath + @"\Data\User.dat";
        private static string fileTemp = Application.StartupPath + @"\Data\Temp.dat";
        
        public static void ListUsers(ListView listViewUser)
        {
            
                
                StreamReader sReader = new StreamReader(filePath);
                listViewUser.Items.Clear();
                

                string line = sReader.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    
                    listViewUser.Items.Add(item);
                    line = sReader.ReadLine(); 
                }
                sReader.Close();
            
        }

        public static List<User> ListUser()
        {

            List<User> listUser = new List<User>();
            StreamReader sReader = new StreamReader(filePath);
            


            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                User user = new User();
                user.UserID = Convert.ToInt32(fields[0]);
                user.UserName = fields[1];
                user.Password = fields[2];

                listUser.Add(user);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return listUser;
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

        public static void SearchByID(int userID, ListView listViewUser)
        {
           

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewUser.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (userID == Convert.ToInt32(fields[0]))
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    listViewUser.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine(); 
            }
            sReader.Close();
           
        }

        public static void SearchByName(string userName, ListView listViewUser)
        {
            

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (userName == fields[1])
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    listViewUser.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine(); 
            }

            sReader.Close();
           
        }
     
        public static void AddUser(User user)
        {
            StreamWriter sWriter = new StreamWriter(filePath,true);
            sWriter.WriteLine(user.UserID + "," + user.UserName + "," + user.Password);
            sWriter.Close();
            MessageBox.Show("User data is added!");

        }

        public static bool PasswordValid(string userName, string password)
        {
            //User user = new User();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                if (userName == fields[1])
                {
                   if(password == fields[2])
                    {
                        sReader.Close();
                        return true;

                    }
                    else {
                        
                        MessageBox.Show("Wrong password!");
                        
                        sReader.Close();
                        return false; }                 
                }
                line = sReader.ReadLine(); 
            }
            MessageBox.Show("Wrong user name!");
            sReader.Close();
            return false;
        }

    }
    
}
