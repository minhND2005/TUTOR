using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DEMO
{
    internal class SinhVien
    {
        //* Demo Tính đóng gói : che dáu dữ liệu ko cho bên ngoài tác đọng vào 
        //* thuoc tinh 
        //* private tất cả các thuộc tính 
        //* Cong thức : Phạm vi truy cập <Kiểu dữ liệu> <Tên biến>
        // sinh viên có thuộc tính MSV HỌ tên, năm sinh, điểm
        private string masv;
        private string hoten;
        private int namsinh;
        private double diem;
        // 2 contructor : hàm tạo
        //- trùng tên vs tên class
        // 2.1 contructor ko có tham số /
        // ctor + tab = khuyến khích
        public SinhVien()
        {

        }
        // 2.2 contructor có tham số 
        // bôi đen tất cả các thuộc tính => chuột phải => click action ... =>gerate 
        // ctrl . => generate contructor 
        public SinhVien(string masv, string hoten, int namsinh, double diem)
        {
            this.Masv = masv;
            this.Hoten = hoten;
            this.Namsinh = namsinh;
            this.Diem = diem;
        }
        // 3.3 tạo properties các thuộc tính đang bị private ko thể truy cập đc
        // bôi đen các thuộc tính => click chuột phải =>quick action => encapsulate 
        // get = dùng để lấy dữ liệu 
        // set = dùng đê gắn dữ liệu
        public string Masv { get => masv; set => masv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public int Namsinh { get => namsinh; set => namsinh = value; }
        public double Diem { get => diem; set => diem = value; }
       // 4. phương thức in thông tin  ()
       public void InThongTin() 
        {
            Console.WriteLine($"Sinh viên : " +
                $"Mã Sinh Viên 

        }


    }
}
