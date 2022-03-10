using System;
using System.Text;

namespace ConsoleTaskAyAdi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
         L1:   Console.Write("Ayı daxil edin: ");
            string a = Console.ReadLine();
            string b = a.ToUpper();
            switch (b)
            {
                case "YANVAR":
                case "FEVRAL":
                case "DEKABR":
                    Console.WriteLine("Qış");
                    break;
                case "MART":
                case "APREL":
                case "MAY":
                    Console.WriteLine("Yaz");
                    break;
                case "İYUN":
                case "İYUL":
                case "AVQUST":
                    Console.WriteLine("Yay");
                    break;
                case "SENTYABR":
                case "OKTYABR":
                case "NOYABR":
                    Console.WriteLine("Payız");
                    break;
                default:
                    Console.WriteLine("Ay düzgün daxil edilməmişdir.");
                    goto L1;
                    break;
                    
            }
            
          
            

        }
    }
}
