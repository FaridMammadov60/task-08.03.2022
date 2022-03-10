using System;
using System.Text;


namespace ConsoleTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding =Encoding.Unicode;
            Console.InputEncoding =Encoding.Unicode;

        L2:
            try
            {
            L1: Console.Write("1-12 aralığında bir rəqəm daxil edin: ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a > 12 || a < 1)
                {
                    Console.WriteLine("Yazılmış rəqəm verilmiş rəqəmlər aralığında deyil.");
                    goto L1;
                }
                switch (a)
                {
                    case 1:
                    case 2:
                    case 12:
                        Console.WriteLine("Qış fəsli");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("Yaz fəsli");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Yay fəsli");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("Payız fəsli");
                        break;
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Rəqəm daxil edilməyib");
                goto L2;
            }
        }
    }
}
