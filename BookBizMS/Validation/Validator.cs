using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBizMS.BLL;
using BookBizMS.DAL;
using BookBizMS.GUI;

namespace BookBizMS.Validation
{

    public static class Validator
    {
        public static bool IsInt(string s)
        {
            string pattern = @"^[0-9]*[1-9][0-9]*$";
            if (s == null)
            {
                MessageBox.Show("can NOT null!");
                return false;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(s, pattern))
            {
                return true;
            }
            MessageBox.Show("Input an integer please!");
            return false;
        }

        public static bool IsValidName(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (IsLetter(s) || (char.IsWhiteSpace(s, i)))
                {
                    MessageBox.Show("Invalid Name,Please enter another name.", "INVALID NAME");
                    
                    return false;
                }

            }
            return true;

        }

        public static bool IsEmail(string s)
        {
            if(s == null)
            {
                MessageBox.Show("Email is null!");
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch
                (s, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                return true;
            }
                MessageBox.Show("Email is Not valid!");
            return false;
        }

        public static bool IsLetter(string s)
        {
            string pattern = @"^[A-Za-z ]+$";
            
            if(System.Text.RegularExpressions.Regex.IsMatch(s, pattern))
            {
                return true;
            }
            MessageBox.Show("Invalid name,please input again!");
            return false;
        }

        public static bool IsUniqueID(List<int> listID, int id)
        {
            foreach (int l in listID)
            {
                if (l == id)
                {
                    MessageBox.Show("Duplicate ID, please enter a unique one.");
                    return false;
                }
            }
            return true;
        }
    }
}
