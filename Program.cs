using System;
using System.IO;
using System.Text;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string text = "Hëllö Wörld!";
            var encoding = Encoding.GetEncoding("iso-8859-1");
            File.WriteAllText("out.txt", text, encoding);
            var contents = File.ReadAllText("out.txt", encoding);
            Console.WriteLine(contents == text);
        }
    }
}
