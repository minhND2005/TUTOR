using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace buoi2
{
    internal class Program
    {
        //    có 2 kiểu trả về 
        //        - ko trả về : void.
        //        - kiểu trả về:
        //          + kiểu đơn : int , double, float.
        //          + tập giá trị : array , list 
        //          + kiểu đối tượng ( Class),.....
        //    tên phương thức : tên động từ viết thường + tên.
        //    dánh sách tham số : có thể cso hoặc ko.
        //    

        static void Main(string[] args)
        {
            //meThodvoid mv = new meThodvoid();
            //mv.Tinhtong3so();
        

            //Console.WriteLine("cong co tham so");
            //mv.Tinhtong(1,1,1);
            //Console.WriteLine("cong co chuoi");
            //mv.Tinhtong(1,1,"c");

            methodtrave mtv = new methodtrave();
            Console.WriteLine("KQ tra ve");
            int a = mtv.TinhTong(2, 3);
            Console.WriteLine(mtv.TinhTong(1,2));
            Console.WriteLine(a);
           
        }
    }
    
}
