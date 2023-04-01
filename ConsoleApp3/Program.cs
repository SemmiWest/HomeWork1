using System.Reflection;

namespace ConsoleApp3
{
    internal class Program
        
    {
        public static void OnInicialization(object sender, EventArgs e)
        {
            Handler1.Write();
            Handler2.Write();
        }
        public delegate void EvetHandler();
        
        static void Main(string[] args)
        {
            
            Counter counter = new Counter();
            counter.Inicialization += OnInicialization;
            counter.Inicailizat();

        }

    }
}