using System;
using System.Text;
namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string welcome = "Hello World!\n";
            string line1 = "How\tare\tyou\n";
            string verbatim = @"It's a great day\u1416\n";
            string unicodechars = "This is a good sign\u1416";
            string normalVerbatim = @"""Hello how are you\n""";
            Console.WriteLine("{0}{1}{2}{3}{4}", welcome, line1, verbatim,
            unicodechars, normalVerbatim);

            //Ex2 Diferent outputs of strings
            int v1 = 1;
            int v2 = 3;
            string personInfo = String.Format("Name is {0} age ={1}", "Ana", 23);
            string placement = String.Format("First is {1} and {0}", v1, v2);
            string adds = $"{v1} mais {v2} = {v1 + v2}";
            Console.WriteLine("\nEx2 Strings");
            Console.WriteLine("{1}{0}", personInfo, placement);
            Console.WriteLine(adds);
            Console.Read();

        }
    }
}
