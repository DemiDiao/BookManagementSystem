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
    public static class OrderDA
    {
        private static string filePath = Application.StartupPath + @"\Data\Order.dat";
        private static string fileTemp = Application.StartupPath + @"\Data\Temp.dat";
        public static void ListOrders(ListView listViewOrders)
        {

            StreamReader sReader = new StreamReader(filePath);
            listViewOrders.Items.Clear();


            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);
                item.SubItems.Add(fields[2]);
                item.SubItems.Add(fields[3]);

                listViewOrders.Items.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close();

        }

        public static void AddOrder(Order order)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(order.OrderID + "," + order.ClientName+ "," + order.BookName + "," + order.Quantity);
            sWriter.Close();
            MessageBox.Show("Order data is added!");

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


        public static void SearchByOrderID(int OrderID, ListView listViewOrder)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewOrder.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (OrderID == Convert.ToInt32(fields[0]))
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);

                    listViewOrder.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static void SearchByClientName(string ClientName, ListView listViewOrder)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewOrder.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (ClientName == fields[1])
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);

                    listViewOrder.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static void SearchByBookName(string BookName, ListView listViewOrder)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewOrder.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (BookName == fields[2])
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);

                    listViewOrder.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static void SearchByQuantity(int quantity, ListView listViewOrder)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewOrder.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (quantity == Convert.ToInt32(fields[3]))
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);

                    listViewOrder.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
        }
    }
}
