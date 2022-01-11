using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class SearchNumber
    {
        public void Search()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine(" **********************************************\n");

            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            ListNumber list = new ListNumber();
            string searchText;
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Aranacak isim veya soyismi giriniz:");
                searchText = Console.ReadLine();

                for (int i = 0; i < list.numbers.Count; i++)
                {
                    if (list.numbers.ElementAt(i).Key.Contains(searchText))
                    {
                        Console.WriteLine("Arama Sonuçlarınız\n******************************\n");
                        Console.WriteLine("İsim Soyisim : {0}", list.numbers.ElementAt(i).Key);
                        Console.WriteLine("Telefon Numarası : {0}\n-\n", list.numbers.ElementAt(i).Value);
                    }
                }
                if (!list.numbers.ContainsKey(searchText))
                {
                    Console.WriteLine("Arama sonuçlarınıza uygun kayıt bulunamadı...\n");
                }

            }
            else if (choice == "2")
            {
                Console.Write("Aranacak telefon numarasını giriniz:");
                searchText = Console.ReadLine();

                for (int i = 0; i < list.numbers.Count; i++)
                {
                    if (list.numbers.ElementAt(i).Value.Contains(searchText))
                    {
                        Console.WriteLine("Arama Sonuçlarınız\n******************************\n");
                        Console.WriteLine("İsim Soyisim : {0}", list.numbers.ElementAt(i).Key);
                        Console.WriteLine("Telefon Numarası : {0}\n-\n", list.numbers.ElementAt(i).Value);
                    }
                }
                if (!list.numbers.ContainsValue(searchText))
                {
                    Console.WriteLine("Arama sonuçlarınıza uygun kayıt bulunamadı...\n");
                   
                }
            }
        }
    }
}