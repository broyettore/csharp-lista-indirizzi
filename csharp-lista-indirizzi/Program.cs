using csharp_lista_indirizzi.Classes;

namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Addresses List
            List<Address> Addresslist = new List<Address>();
            string filePath = "C:\\Users\\broye\\Desktop\\C#-basics\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\my-addresses.csv";


            // Opens the file at this path
            StreamReader file = File.OpenText(filePath);
            int tracker = 0;

            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                tracker++;

                if (tracker > 1)
                {
                    try
                    {
                        Address checkedAddress = AddressChecker.checkAddress(line);
                        Addresslist.Add(checkedAddress);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            file.Close();



            StreamWriter createFile = File.CreateText("C:\\Users\\broye\\Desktop\\C#-basics\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\newAddressList.txt");

            //Prints in console every address in the addressList
            for (int i = 0; i < Addresslist.Count; i++)
            {
                Console.WriteLine($"{i + 1} {Addresslist[i]}");
                createFile.WriteLine($"{i + 1}. {Addresslist[i]}");
            }

            createFile.Close();
        }
    }
}