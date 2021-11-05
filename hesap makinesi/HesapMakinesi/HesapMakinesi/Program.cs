using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[>] 1. SAYI:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("[>] İŞLEM SEÇİNİZ: (+) (-) (*) (/)");
            string islem = Console.ReadLine();

            Console.WriteLine("[>] 2. SAYI:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if(islem == "+")
            {
                Console.WriteLine(sayi1 + " + " + sayi2 + " = " + (sayi1+sayi2));
            }
            else if (islem == "-")
            {
                Console.WriteLine(sayi1 + " - " + sayi2 + " = " + (sayi1 - sayi2));
            }
            else if (islem == "*")
            {
                Console.WriteLine(sayi1 + " * " + sayi2 + " = " + (sayi1 * sayi2));
            }
            else if (islem == "/")
            {
                if(sayi2 != 0)
                {
                    Console.WriteLine(sayi1 + " / " + sayi2 + " = " + ((double)sayi1 / (double)sayi2));
                }
                else if (sayi2 == 0)
                {
                    Console.WriteLine(sayi1 + " / 0 =  Tanımsız");
                }
            }
            else if(islem != "+" && islem != "-" && islem != "*" && islem != "/")
            {
                Console.WriteLine("[>] Geçersiz işlem girdiğiniz için işlem yapılamadı.");
            }
        }
    }
}
