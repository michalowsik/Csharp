using System;
using System.Text;

namespace StringBudowa

{ 
class Program
    {
        static void Main(string[] args)
        {
            string mess1;
            mess1 = "some value";
            Console.WriteLine(mess1);

            string mess2 = null;
            Console.WriteLine(mess2);


            string mess3 = string.Empty;

            string text = "On mówi \"Cześć\"";
            Console.WriteLine(text);
            string windowLocation = "c:\\windows";
            Console.WriteLine(windowLocation);

            string fontsFolder = @"c:\windows\fonts";
            Console.WriteLine(fontsFolder);

            string concatenated = string.Concat(text, " do ", "mnie");
            string concatenated2 = text + " do " + "mnie";
            Console.WriteLine(concatenated);
            Console.WriteLine(concatenated2);

            string interpolated = $"{text} do mnie";
            Console.WriteLine(interpolated);
            StringBuilder sb = new StringBuilder("To");
            sb.Append("jest");
            sb.Append("długi");
            sb.Append("tekst");

            string result = sb.ToString();
            Console.WriteLine(result);
        }

    }
}
