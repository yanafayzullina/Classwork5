using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5file
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("2.Адская кухня");
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine().ToLower().Replace('а', '@').Replace('е', '*').Replace('ё', '*').Replace('и', '*').Replace('о', '*').Replace('э', '@').Replace('ю', '*').Replace('я', '*').Replace('у', '@').Replace('ы', '*');
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
