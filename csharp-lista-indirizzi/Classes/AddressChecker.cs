using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi.Classes
{
    public static class AddressChecker
    {
        public static Address checkAddress(string address)
        {
            string[] splitAddress = address.Split(",");

            // Checks if the address has the right format since there are 6 columns
            if (splitAddress.Length != 6)
            {
                throw new ArgumentException($"Invalid address format: {address}");
            }

            // loops through each text field to check if it's empty
            foreach (string element in splitAddress)
            {
                if (element.Length == 0)
                {
                    throw new ArgumentException($"Data missing: {address}");
                }
            }

            string name = splitAddress[0];
            string surname = splitAddress[1];
            string street = splitAddress[2];
            string city = splitAddress[3];
            string province = splitAddress[4];
            string zip = splitAddress[5];



            return new(name, surname, street, city, province, zip); // return a new address

        }
    }
}
