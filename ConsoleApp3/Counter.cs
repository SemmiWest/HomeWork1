using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Counter
    {
        
        public event EventHandler Inicialization;
        
        
        public  void Inicailizat()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                if (i == 77)
                {
                    Console.WriteLine(i);
                    Inicialization(this, new EventArgs());
                    break;
                }
            }
        }

    } }

       
    
  

  
               
            
            
