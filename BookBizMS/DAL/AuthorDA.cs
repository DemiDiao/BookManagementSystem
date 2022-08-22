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
    public static class AuthorDA
    {
        private static string filePath = Application.StartupPath + @"\Data\Author.dat";
        private static string fileTemp = Application.StartupPath + @"\Data\Temp.dat";

        public static void ListAuthors(ListView listViewAuthors)
        {


            StreamReader sReader = new StreamReader(filePath);
            listViewAuthors.Items.Clear();


            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);
                item.SubItems.Add(fields[2]);
                item.SubItems.Add(fields[3]);

                listViewAuthors.Items.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close();

        }


        public static void AddAuthor(Author author)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(author.AuthorID + "," + author.FirstName + "," + author.LastName + "," + author.Email);
            sWriter.Close();
            MessageBox.Show("Author data is added!");

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

        public static void SearchByAuthorID(int authorID, ListView listViewAuthor)
        {


            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewAuthor.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (authorID == Convert.ToInt32(fields[0]))
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);

                    listViewAuthor.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();


        }

        public static void SearchByAuthorIDList(List<int> authorIDList, ListView listViewAuthor)
        {
            List<int> authorID_List = new List<int>();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewAuthor.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                for (int i = 0; i < authorIDList.Count; i++)
                {
                    if (authorIDList[i] == Convert.ToInt32(fields[0]))
                    {
                        ListViewItem item = new ListViewItem(fields[0]);
                        item.SubItems.Add(fields[1]);
                        item.SubItems.Add(fields[2]);
                        item.SubItems.Add(fields[3]);

                        listViewAuthor.Items.Add(item);
                        line = sReader.ReadLine();
                    }
                }
                line = sReader.ReadLine();

                sReader.Close();


            }
        }


             public static void SearchByFirstName(string firstName, ListView listViewAuthor)
             {

                 StreamReader sReader = new StreamReader(filePath);
                 string line = sReader.ReadLine();
                 listViewAuthor.Items.Clear();

                 while (line != null)
                 {
                     string[] fields = line.Split(',');
                     if (firstName == fields[1])
                     {
                         ListViewItem item = new ListViewItem(fields[0]);
                         item.SubItems.Add(fields[1]);
                         item.SubItems.Add(fields[2]);
                         item.SubItems.Add(fields[3]);

                         listViewAuthor.Items.Add(item);
                         line = sReader.ReadLine();
                     }
                     line = sReader.ReadLine();
                 }
                 sReader.Close();

             }

             public static void SearchByLastName(string lastName, ListView listViewAuthor)
             {

                 StreamReader sReader = new StreamReader(filePath);
                 string line = sReader.ReadLine();
                 listViewAuthor.Items.Clear();

                 while (line != null)
                 {
                     string[] fields = line.Split(',');
                     if (lastName == fields[2])
                     {
                         ListViewItem item = new ListViewItem(fields[0]);
                         item.SubItems.Add(fields[1]);
                         item.SubItems.Add(fields[2]);
                         item.SubItems.Add(fields[3]);

                         listViewAuthor.Items.Add(item);
                         line = sReader.ReadLine();
                     }
                     line = sReader.ReadLine();
                 }
                 sReader.Close();

             }

             public static void SearchByEmail(string email, ListView listViewAuthor)
             {

                 StreamReader sReader = new StreamReader(filePath);
                 string line = sReader.ReadLine();
                 listViewAuthor.Items.Clear();

                 while (line != null)
                 {
                     string[] fields = line.Split(',');
                     if (email == fields[3])
                     {
                         ListViewItem item = new ListViewItem(fields[0]);
                         item.SubItems.Add(fields[1]);
                         item.SubItems.Add(fields[2]);
                         item.SubItems.Add(fields[3]);

                         listViewAuthor.Items.Add(item);
                         line = sReader.ReadLine();
                     }
                     line = sReader.ReadLine();
                 }
                 sReader.Close();

             }

        public static void listAuthorsByList (List<int> authorIDList,ListView listViewAuthor) { 
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewAuthor.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                for (int i = 0; i<authorIDList.Count; i++)
                    if (authorIDList[i] == Convert.ToInt32(fields[0]))
                    {
                        ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                        item.SubItems.Add(fields[2]);
                        item.SubItems.Add(fields[3]);
                       

                        listViewAuthor.Items.Add(item);
                        line = sReader.ReadLine();
                    }
                    line = sReader.ReadLine();
            }
            sReader.Close();
        }
        }
    }

