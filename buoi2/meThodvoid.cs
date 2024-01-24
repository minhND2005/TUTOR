using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi2
{
    internal class meThodvoid
    {
        public void TinhTong()
        {
            int a, b;
            Console.WriteLine("Moi ban nhap a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi bna nhap b :");
            b = int.Parse(Console.ReadLine());
            int tong = a + b;
            Console.WriteLine(tong);
            Console.WriteLine(a+ b);
        }
        public  void Tinhtong3so() /*phuong thuc tinh co gtri*/
        {
            Console.WriteLine();    
        }
        public void Tinhtong (int a, int b, string c)  /*cong chuoi*/
        {
            Console.WriteLine (a+ b + c);
        }
    }
}
