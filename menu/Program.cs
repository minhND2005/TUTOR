using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.WriteLine("To be continue");
        }
        static void Menu()
        {
            int luachon;
            do
            {
                Console.WriteLine("--------------Menu--------------");
                Console.WriteLine("------------1 Bai 1-------------");
                Console.WriteLine("------------2 Bai 1-------------");
                Console.WriteLine("------------3 Bai 1-------------");
                Console.Write("Xin moi ban nhap:");
                luachon = int.Parse(Console.ReadLine());

                switch (luachon)
                {
                    case 1:
                        Console.WriteLine("Bai 1");
                        break;
                    case 2:
                        Console.WriteLine("Bai 2");
                        break;
                    case 3:
                        Console.WriteLine("Bai 3");
                        break;
                    case 0:

                        Console.WriteLine("Thoat");
                        break;
                    default:
                        Console.WriteLine("Moi ban nhap lai");
                        break;
                }

            } while (luachon != 0);
        }
    }
}
