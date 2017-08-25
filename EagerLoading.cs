using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public sealed class EagerLoading
    {
        private static int counter = 0;
        private static readonly EagerLoading instance = new EagerLoading();

        public static EagerLoading GetInsance
        {
            get
            {
                return instance;
            }

        }

        private EagerLoading()
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
