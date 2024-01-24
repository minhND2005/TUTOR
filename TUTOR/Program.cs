using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TUTOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Console.WriteLine("Mời bạn nhập điểm :");
            //double diem = double.Parse(Console.ReadLine());
            //if(diem >=5 & diem <7)
            //{
            //    Console.WriteLine("Iphone8");
            //}
            //else if(diem >= 7 & diem < 9)
            //{
            //    Console.WriteLine("Iphone XS MAX");
            //}
            //else if (diem >= 9  & diem <= 10)
            //{
            //     Console.WriteLine("Iphone 15");
            //}
            //else
            //{
            //    Console.WriteLine("Mat 672k");
            //}
            //double diem;
            //Console.WriteLine("Mời bạn nhập điểm :");
            //diem = double.Parse(Console.ReadLine());    



            //string kq = diem > 5 ? "chúc mừng bạn qua môn " : "Tạch";
            //Console.WriteLine(kq);
            //Console.ReadKey();
            //int nsBanthan = 2005, giotinhBanthan = 1;
            //int nsNguoi , gioitinhNguoi;
            //string ten;
            //Console.WriteLine("mOI BNA NHAP TEN:");
            //ten= Console.ReadLine();
            //Console.WriteLine("Moi bna nhap nam sinh:");
            //nsNguoi= int.Parse(Console.ReadLine());
            //Console.WriteLine("Moi ban nhap gioi tinh:");
            //gioitinhNguoi = int.Parse(Console.ReadLine());
            //string chao = ((nsNguoi < nsBanthan) && gioitinhNguoi ==1) ? "Anh" :
            //    ((nsNguoi < nsBanthan) && gioitinhNguoi == 0)? "chi":
            //    ((nsNguoi > nsBanthan) && gioitinhNguoi == 1)? "Em trai": 
            //    ((nsNguoi > nsBanthan) && gioitinhNguoi == 0)? "Em gai" :
            //    "Ban";

            //Console.WriteLine( "Chao " + chao +" " + ten);


            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("Toi se qua mon");
            //}

            //int i = 0;  

            //while (i < 5)
            //{
            //    Console.WriteLine("Toi se qua mon");
            //    i++;
            //}

            //int i = 1;
            //int j = 2;
            //do
            //{
            //    Console.WriteLine("Bang cuu chuong :" + i);
            //    do
            //    {
            //        Console.WriteLine($"{i} x {j} = {i*j}");
            //        j++;
            //    } while (j < 11);
            //    j = 1;
            //    i++;
            //} while (i < 10);
            int[] arrNumber = { 1, 2, 3, 4, 5, 6 };
            //foreach (int i in arrNumber)
            //{
            //    Console.WriteLine(i);
            //}
            for (int i = 0; i < arrNumber.Length; i++)
            {
                Console.WriteLine(arrNumber[i]);
            }
           
          

          

        }
    }
}
