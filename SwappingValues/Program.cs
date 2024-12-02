using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            string name = "Синица";
            string surname = "Евгений";
            string swapValue;

            Console.WriteLine($" Имя: {name}  Фамилия: {surname} ");

            swapValue = name;
            name = surname;
            surname = swapValue;

            Console.WriteLine($" Имя: {name}  Фамилия: {surname} ");
        }
    }
}
