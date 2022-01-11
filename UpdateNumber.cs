using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class UpdateNumber
    {
        public void Update()
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string UpdateText = Console.ReadLine();

            ListNumber list = new ListNumber();


            for (int i = 0; i < list.numbers.Count; i++)
            {
                if (list.numbers.ElementAt(i).Key.Contains(UpdateText))
                {
                    Console.WriteLine("{0} isimli kişinin telefon numarası: {1}\n", list.numbers.ElementAt(i).Key , list.numbers.ElementAt(i).Value);

                    Console.Write("Yeni numarayı giriniz : ");
                    string newUpdateText = Console.ReadLine();

                    list.numbers[list.numbers.ElementAt(i).Key] = newUpdateText;   //value update in dictionary list

                    Console.WriteLine("Numara güncellenmiştir...\n");
                    break;
                }
            }

            if(!list.numbers.ContainsKey(UpdateText))
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("Güncelleme işlemi sonlandırıldı...\n");

                }
                else if (choice == "2")
                {
                    Console.WriteLine("Yeni işlem başlatılıyor... \n");
                }
            }
        }
    }
}
