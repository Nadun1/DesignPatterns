using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lazy Singleton
namespace DesignPatterns
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance= null;
        private static object obj = new object() ; 
       
        public static Singleton GetInsance
        {
            get 
             {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }                               
                return instance; 
            }
             
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Val " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message );
        }
    }
}
