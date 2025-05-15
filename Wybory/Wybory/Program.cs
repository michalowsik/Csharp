using System;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;

namespace Wybory
{
    #region 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile masz lat?");
            string userInput = Console.ReadLine();

            int age = int.Parse(userInput);
            bool User18plus = age >= 18;
            if (User18plus)
            {
                Console.WriteLine("Możesz głosować");
            }

            else
            {
                Console.WriteLine("Nie jesteś jeszcze uprawniony do głosowania!");
            }
            Console.WriteLine("Bye bye");
        }

    }
    #endregion

}
