using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pacient
    {
        public string Name { get; set; }
        public string Pol { get; set; }
        public string Age { get; set; }

        public int Status(int value)  {
            /*Random rnd = new Random();
            int value = rnd.Next(0, 1);*/
            if (value == 1) { Console.WriteLine("Пациент : Жалоба"); }
            else { Console.WriteLine("Пациент : Жалоб нет"); }
            return value;
            

        }

        public void BuyMedicaments() {
            Console.WriteLine("Пациент : Поход в аптеку");
        }

    }
}
