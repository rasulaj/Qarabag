using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string astr, bstr;
            bool c;

            do
            {
                Console.WriteLine("1ci ededi daxil edin");
                astr = Console.ReadLine();
                c = int.TryParse(astr, out a);
            }
            while (!c);



            do
            { Console.WriteLine("2ci ededi daxil edin");
                bstr = Console.ReadLine();
                c = int.TryParse(bstr, out b);
            }
            while (!c);

            int result = a * b;
            Console.WriteLine(result);



        }
    }
}
