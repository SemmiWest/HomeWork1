using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Doctor
    {
        public string Name { get; set; }
        public string Post { get; set; }
        public string Specialization { get; set; }

        public void Analiz(int status)
        {
            if (status == 1)
            {
                Console.WriteLine("Доктор : Назначил лечение");
            }
            else {
                Console.WriteLine("Доктор : Лечение не нужно");
            } 
                   
        }
        public void GoodBuy() { Console.WriteLine("Доктор :Досвидания"); }

    }

}
