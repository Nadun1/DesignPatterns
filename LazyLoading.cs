using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public sealed class LazyLoading
    {
        private static int counter = 0;
        private static readonly Lazy<LazyLoading> instance = new Lazy<LazyLoading>(() => new LazyLoading());

        public static LazyLoading GetInsance
        {
            get
            {
                return instance.Value ; 
            }

        }

        private LazyLoading()
        {
            counter++;
            Console.WriteLine("Counter Val " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
    
}
