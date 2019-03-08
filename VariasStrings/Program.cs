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
            string unicodechars = "This is a good sign\u1416\n";
            string normalVerbatim = @"""Hello how are you\n""";
            Console.WriteLine("{0}{1}{2}{3}{4}", welcome, line1, verbatim, unicodechars, normalVerbatim);
        }
    }
}
