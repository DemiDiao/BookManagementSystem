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
    public static  class BookDA
    {
        private static string filePath = Application.StartupPath + @"\Data\Book.dat";
        private static string fileTemp = Application.StartupPath + @"\Data\Temp.dat";
        private static string filePath2 = Application.StartupPath + @"\Data\BookAuthor.dat";

        public static void ListBooks(ListView listViewBooks)
        {
            StreamReader sReader = new StreamReader(filePath);
            listViewBooks.Items.Clear();

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
                item.SubItems.Add(fields[6]);
                item.SubItems.Add(fields[7]);            
          
                listViewBooks.Items.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close();

        }

        public static void AddBook(Book book)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(book.BookID + "," + book.ISBN + "," + book.BookName + "," + book.Category
                + "," + book.YearPublishied + "," + book.Publisher + "," + book.Price + "," + book.Inventory);
            sWriter.Close();
            MessageBox.Show("New book data is added!");

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
        public static void SearchByBookID(int bookID, ListView listViewBook, ListView listViewAuthor)
        {


            StreamReader sReaderBook = new StreamReader(filePath);
            string lineBook = sReaderBook.ReadLine();
            listViewBook.Items.Clear();

            while (lineBook != null)
            {
                string[] fields = lineBook.Split(',');
                if (bookID == Convert.ToInt32(fields[0]))
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);
                    item.SubItems.Add(fields[6]);
                    item.SubItems.Add(fields[7]);

                    listViewBook.Items.Add(item);
                    lineBook = sReaderBook.ReadLine();
                }
                lineBook = sReaderBook.ReadLine();
            }
            sReaderBook.Close();
        }

           public static List<int> SearchAuthorIDByBookID (int bookID) 
        { 
            StreamReader sReaderBookAuthor = new StreamReader(filePath2);
            string lineBookAuthor = sReaderBookAuthor.ReadLine();
            List<int> authorIDList = new List<int>();
            while (lineBookAuthor != null)
            {
                string[] fields = lineBookAuthor.Split(',');
                if (bookID == Convert.ToInt32(fields[0]))
                {
                    authorIDList.Add(Convert.ToInt32(fields[1]));
                    lineBookAuthor = sReaderBookAuthor.ReadLine();
                }
                lineBookAuthor = sReaderBookAuthor.ReadLine();
            }
            sReaderBookAuthor.Close();
            return authorIDList;
            }

           

        public static void SearchByBookName(string bookName, ListView listViewBook)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewBook.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (bookName == fields[2])
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);
                    item.SubItems.Add(fields[6]);
                    item.SubItems.Add(fields[7]);

                    listViewBook.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();

        }

        public static void SearchByISBNNumber(string isbn, ListView listViewBook)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewBook.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (isbn == fields[1])
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);
                    item.SubItems.Add(fields[6]);
                    item.SubItems.Add(fields[7]);

                    listViewBook.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();

        }

        public static void SearchByPublisher(string publisher, ListView listViewBook)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewBook.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (publisher == fields[5])
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);
                    item.SubItems.Add(fields[6]);
                    item.SubItems.Add(fields[7]);

                    listViewBook.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();

        }

        public static void SearchByAuthorID(int authorID, ListView listViewBook)
        {

            //search bookID from BookAuthor.dat;
            StreamReader sReaderBookAuthor = new StreamReader(filePath2);
            string lineBookAuthor = sReaderBookAuthor.ReadLine();
            listViewBook.Items.Clear();
            List<int> bookIDList = new List<int>();
            while (lineBookAuthor != null)
            {
                string[] fields = lineBookAuthor.Split(',');
                if (authorID == Convert.ToInt32(fields[1]))
                {
                    bookIDList.Add(Convert.ToInt32(fields[0]));                  
                    lineBookAuthor = sReaderBookAuthor.ReadLine();
                }
                lineBookAuthor = sReaderBookAuthor.ReadLine();
            }
            sReaderBookAuthor.Close();


            //search book from the book table.
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewBook.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                for(int i = 0; i < bookIDList.Count; i++)
                if (bookIDList[i] == Convert.ToInt32(fields[0]))
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);
                    item.SubItems.Add(fields[6]);
                    item.SubItems.Add(fields[7]);

                    listViewBook.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();

        }


    }
}
