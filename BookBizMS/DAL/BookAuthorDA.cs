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
    public static class BookAuthorDA
    {
        private static string filePath = Application.StartupPath + @"\Data\BookAuthor.dat";
        private static string fileTemp = Application.StartupPath + @"\Data\Temp.dat";

        public static void ListBookAuthors(ListView listViewBookAuthors)
        {
            StreamReader sReader = new StreamReader(filePath);
            listViewBookAuthors.Items.Clear();

            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);              

                listViewBookAuthors.Items.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static void AddBookAuthor(BookAuthor bookAuthor)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(bookAuthor.BookID + "," + bookAuthor.AuthorID);
            sWriter.Close();

            MessageBox.Show("Relationship is added!");
        }

        public static List<int> SearchAuthorIDByBookID(int bookID)
        {
            List<int> authorIDList = new List<int>();
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (bookID == Convert.ToInt32(fields[0]))
                {
                    authorIDList.Add(Convert.ToInt32(fields[1]));                   
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return authorIDList;
        }

        public static List<int> SearchBookIDByAuthorID(int authorID)
        {
            List<int> bookIDList = new List<int>();
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();


            while (line != null)
            {
                string[] fields = line.Split(',');
                if (authorID == Convert.ToInt32(fields[0]))
                {
                    bookIDList.Add(Convert.ToInt32(fields[1]));
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return bookIDList;
        }

        public static void SearchByBookID(int bookID, ListView listViewBookAuthor)
        {


            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewBookAuthor.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (bookID == Convert.ToInt32(fields[0]))
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    

                    listViewBookAuthor.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();


        }

        public static void SearchByAuthorID(int authorID, ListView listViewBookAuthor)
        {


            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewBookAuthor.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (authorID == Convert.ToInt32(fields[1]))
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                   

                    listViewBookAuthor.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();


        }
    }
}
