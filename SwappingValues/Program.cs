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
            string buffer;

            Console.WriteLine($" Имя: {name}  Фамилия: {surname} ");

            buffer = name;
            name = surname;
            surname = buffer;

            Console.WriteLine($" Имя: {name}  Фамилия: {surname} ");
        }
    }
}
