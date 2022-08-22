using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBizMS.BLL;
using BookBizMS.Validation;
using System.Windows.Forms;
using System.IO;

namespace BookBizMS.DAL
{
    public static class ClientDA
    {
        private static string filePath = Application.StartupPath + @"\Data\Client.dat";
        private static string fileTemp = Application.StartupPath + @"\Data\Temp.dat";

        /*       public static List<Client> ListClient()
               {

                   List<Client> listClient = new List<Client>();
                   StreamReader sReader = new StreamReader(filePath);

                   string line = sReader.ReadLine();
                   while (line != null)
                   {
                       string[] fields = line.Split(',');
                       Client client = new Client();
                       client.ClientID = Convert.ToInt32(fields[0]);
                       client.ClientName = fields[1];
                       client.StreetNumber = Convert.ToInt32(fields[2]);
                       client.StreetName = fields[3];
                       client.City = fields[4];
                       client.PostalCode = fields[5];
                       client.PhoneNumber = fields[6];
                       client.FaxNumber = fields[7];
                       client.Email = fields[8];
                       client.CreditLimit = Convert.ToDouble(fields[9]);


                       listClient.Add(client);
                       line = sReader.ReadLine();
                   }
                   sReader.Close();
                   return listClient;
               }
        */
        public static void ListClients(ListView listViewClient)
        {
            StreamReader sReader = new StreamReader(filePath);
            listViewClient.Items.Clear();

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
                item.SubItems.Add(fields[8]);
                item.SubItems.Add(fields[9]);

                listViewClient.Items.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static void AddClient(Client client)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(client.ClientID + "," + client.ClientName + ","
                + client.StreetNumber + "," + client.StreetName + "," + client.City
                + "," + client.PostalCode + "," + client.PhoneNumber + ","
                + client.FaxNumber + "," + client.Email + "," + client.CreditLimit);
            sWriter.Close();
            MessageBox.Show("Client data is added!");
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



        public static void SearchByClientID(int clientID, ListView listViewClient)
        {
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewClient.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (clientID == Convert.ToInt32(fields[0]))
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);
                    item.SubItems.Add(fields[6]);
                    item.SubItems.Add(fields[7]);
                    item.SubItems.Add(fields[8]);
                    item.SubItems.Add(fields[9]);

                    listViewClient.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static void SearchByClientName(string clientName, ListView listViewClient)
        {
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewClient.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (clientName == fields[1])
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);
                    item.SubItems.Add(fields[6]);
                    item.SubItems.Add(fields[7]);
                    item.SubItems.Add(fields[8]);
                    item.SubItems.Add(fields[9]);

                    listViewClient.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static void SearchByStreetNumber(int streetNumber, ListView listViewClient)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewClient.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (streetNumber == Convert.ToInt32(fields[2]))
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);
                    item.SubItems.Add(fields[6]);
                    item.SubItems.Add(fields[7]);
                    item.SubItems.Add(fields[8]);
                    item.SubItems.Add(fields[9]);

                    listViewClient.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();

        }

        public static void SearchByStreetName(string streetName, ListView listViewClient)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewClient.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (streetName == fields[3])
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);
                    item.SubItems.Add(fields[6]);
                    item.SubItems.Add(fields[7]);
                    item.SubItems.Add(fields[8]);
                    item.SubItems.Add(fields[9]);

                    listViewClient.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static void SearchByCity(string city, ListView listViewClient)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewClient.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (city == fields[4])
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);
                    item.SubItems.Add(fields[6]);
                    item.SubItems.Add(fields[7]);
                    item.SubItems.Add(fields[8]);
                    item.SubItems.Add(fields[9]);

                    listViewClient.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static void SearchByPostalCode(string postalCode, ListView listViewClient)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewClient.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (postalCode == fields[5])
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);
                    item.SubItems.Add(fields[6]);
                    item.SubItems.Add(fields[7]);
                    item.SubItems.Add(fields[8]);
                    item.SubItems.Add(fields[9]);

                    listViewClient.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static void SearchByPhoneNumber(string phoneNumber, ListView listViewClient)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewClient.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (phoneNumber == fields[6])
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);
                    item.SubItems.Add(fields[6]);
                    item.SubItems.Add(fields[7]);
                    item.SubItems.Add(fields[8]);
                    item.SubItems.Add(fields[9]);

                    listViewClient.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static void SearchByFaxNumber(string faxNumber, ListView listViewClient)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewClient.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (faxNumber == fields[7])
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);
                    item.SubItems.Add(fields[6]);
                    item.SubItems.Add(fields[7]);
                    item.SubItems.Add(fields[8]);
                    item.SubItems.Add(fields[9]);

                    listViewClient.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static void SearchByEmail(string email, ListView listViewClient)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewClient.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (email == fields[8])
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);
                    item.SubItems.Add(fields[6]);
                    item.SubItems.Add(fields[7]);
                    item.SubItems.Add(fields[8]);
                    item.SubItems.Add(fields[9]);

                    listViewClient.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static void SearchByCreditLimit(double creditLimit, ListView listViewClient)
        {

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            listViewClient.Items.Clear();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (creditLimit == Convert.ToDouble(fields[9]))
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    item.SubItems.Add(fields[2]);
                    item.SubItems.Add(fields[3]);
                    item.SubItems.Add(fields[4]);
                    item.SubItems.Add(fields[5]);
                    item.SubItems.Add(fields[6]);
                    item.SubItems.Add(fields[7]);
                    item.SubItems.Add(fields[8]);
                    item.SubItems.Add(fields[9]);

                    listViewClient.Items.Add(item);
                    line = sReader.ReadLine();
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
        }
    }
}
