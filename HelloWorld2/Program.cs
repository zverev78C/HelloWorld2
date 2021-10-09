using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Program
       
    {/// <summary>
    /// Код который выполняется в первую очередь( точка входа)
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Hello ");    // выводит надпись на экран в конце строки символ ; обязательно
            Console.Write("world ");    // пробелы тоже нужны иначе все в одно слово
            Console.Write("!!!");

            Console.ReadLine();         // не закрывает приложение до нажатия enter

        }
    }
}
