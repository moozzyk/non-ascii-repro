using System;
using System.IO;
using System.Text;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string text = "H�ll� W�rld!";

            foreach (var c in text)
            {
                Console.Write("{0:x} ", (int)c);
            }

            Console.WriteLine();
        }
    }
}
