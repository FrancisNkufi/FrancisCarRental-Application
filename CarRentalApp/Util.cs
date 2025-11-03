using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    internal class Util
    {
        public static bool FormIsOpen(string formName)
        {
           var OpenForms = Application.OpenForms.Cast<Form>();
           var isFormOpen = OpenForms.Any(q => q.Name == formName);
              return isFormOpen;
        }
        public static string HashPassword(string passWord)
        {
            SHA256 sha = SHA256.Create();
            //Convert the input string to a byte array and compute the hash.                
            byte[] data = Encoding.UTF8.GetBytes(passWord);

            // Create a new stringbuilder to collect the bytes and create a string
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public static string DefaultHashPassword()
        {
            SHA256 sha = SHA256.Create();
            //Convert the input string to a byte array and compute the hash.                
            byte[] data = Encoding.UTF8.GetBytes("Password@123");

            // Create a new stringbuilder to collect the bytes and create a string
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
