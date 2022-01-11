using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opening opening = new Opening();
            opening.Open();

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                AddNumber addNumber = new AddNumber();
                addNumber.Add();

                Main(null);   //Consoleda devamlı işlem yapabilmek için Main metodunu tekrar çalıştırmamız gerekiyor
            }

            else if (choice == "2")
            {
                DeleteNumber deleteNumber = new DeleteNumber();
                deleteNumber.Delete();

                Main(null);
            }

            else if (choice == "3")
            {
                UpdateNumber updateNumber = new UpdateNumber(); 
                updateNumber.Update();

                Main(null);
            }

            else if (choice == "4")
            {
                ListNumber listNumber = new ListNumber();

                Console.WriteLine("Telefon Rehberi\n******************************\n");
                
                foreach (var item in listNumber.numbers)
                {
                    Console.WriteLine("İsim Soyisim : {0}", item.Key);
                    Console.WriteLine("Telefon Numarası : {0}\n", item.Value);
                }

                Main(null);
            }

            else if (choice == "5")
            {
                SearchNumber searchNumber = new SearchNumber();
                searchNumber.Search();

                Main(null);
            }

            Console.ReadLine();
        }

     }

    class Opening
    {
        public void Open()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin.");
            Console.WriteLine("*************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
        }
    }
}
