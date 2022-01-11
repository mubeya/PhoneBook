using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class DeleteNumber
    {
        public string DeletedText { get; set; }
        public void Delete()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını veya soyadını giriniz : ");
            DeletedText = Console.ReadLine();

            ListNumber list = new ListNumber();

            for (int i = 0; i < list.numbers.Count; i++)
            {
                if (list.numbers.ElementAt(i).Key.Contains(DeletedText))
                {
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", list.numbers.ElementAt(i).Key);

                    if (Console.ReadLine() == "y")
                    {
                        list.numbers.Remove(list.numbers.ElementAt(i).Key);
                        Console.WriteLine("Kişi telefon rehberinden silinmiştir...\n");
                        break;

                    }
                    else if (Console.ReadLine() == "n")
                    {
                        Console.WriteLine("İşlem iptal edildi.");
                        break;
                    }
                }
            }

            if (list.numbers.ContainsKey(DeletedText))
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("Silme işlemi sonlandırıldı...\n");

                }
                else if (choice == "2")
                {
                    Console.WriteLine("İşlem yeniden başlatılıyor...\n");
                }
            }


            //for (int i = 0; i < list.numbers.Count; i++)
            //{
            //    if (list.numbers.ElementAt(i).Key.Contains(DeletedText))
            //    {
            //        Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", list.numbers.ElementAt(i).Key);

            //        if (Console.ReadLine() == "y")
            //        {
            //            list.numbers.Remove(list.numbers.ElementAt(i).Key);
            //            Console.WriteLine("Kişi telefon rehberinden silinmiştir...\n");

            //        }
            //        else if (Console.ReadLine() == "n")
            //        {
            //            Console.WriteLine("İşlem iptal edildi.");
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            //        Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            //        Console.WriteLine("* Yeniden denemek için      : (2)");

            //        if (Console.ReadLine() == "1")
            //        {
            //            Console.WriteLine("Silme işlemi sonlandırıldı...\n");

            //        }
            //        else if (Console.ReadLine() == "2")
            //        {
            //            Console.WriteLine("Silme işlemi sonlandırıldı...\n");
            //        }
            //    }
            //}
        }
    }
}
