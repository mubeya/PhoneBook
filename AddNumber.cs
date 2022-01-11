using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class AddNumber
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public void Add()
        {
            Console.WriteLine("Lütfen isim soyisim giriniz : ");
            Name = Console.ReadLine();

            Console.WriteLine("Lütfen telefon numarası giriniz : ");
            Number = Console.ReadLine();

            ListNumber list = new ListNumber();
            list.numbers.Add(Name, Number);

            Console.WriteLine("Kişi rehbere kaydedilmiştir....\n");

        }

    }

   
}

