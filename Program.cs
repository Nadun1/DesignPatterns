 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintS1(),
                () => PrintS2()
                );
            Console.WriteLine("----------------------------------------------");            

            Parallel.Invoke(
                () => PrintE1(),
                () => PrintE2()
                );
            Console.WriteLine("----------------------------------------------");
            LazyLoading l1 = LazyLoading.GetInsance;
            l1.PrintDetails("This from Lazy1");
            LazyLoading l2 = LazyLoading.GetInsance;
            l1.PrintDetails("This from Lazy2");
            Console.ReadLine();
        }

        private static void PrintE1()
        {
            EagerLoading e2 = EagerLoading.GetInsance;
            e2.PrintDetails("This is from e2 ");
        }

        private static void PrintE2()
        {
            EagerLoading e1 = EagerLoading.GetInsance;
            e1.PrintDetails("This is from e1");
        }

        private static void PrintS2()
        {
            Singleton s2 = Singleton.GetInsance;
            s2.PrintDetails("This is second message");
        }

        private static void PrintS1()
        {
            Singleton s1 = Singleton.GetInsance;
            s1.PrintDetails("This is first message");
        }
    }
}
