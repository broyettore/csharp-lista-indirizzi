using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi.Classes
{
    public class Address
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string Province { get; private set; }
        public string ZIP { get; private set; }

        public Address(string name, string surname, string street, string city, string province, string zip)
        {
            Name = name;
            Surname = surname;
            Street = street;
            City = city;
            Province = province;
            ZIP = zip;
        }

        public override string ToString()
        {
            return $"*Address* \n\t Name: {Name} \n\t Surname: {Surname} \n\t Street: {Street} \n\t City: {City} \n\t Province: {Province} \n\t ZIP: {ZIP} \n\t";
        }
    }
}
