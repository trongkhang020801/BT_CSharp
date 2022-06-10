using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    
    internal class Program
    {
   
     // Câu 1. Viết phương thức in ra tổng, hiệu, tích, thương của 2 số đc nhập vào bàn phím cho trước.
    static void Tong_Hieu_Tich_Thuong(Double a_31, Double b_31)
    {
        Console.WriteLine("Tong cua 2 so vua nhap: "+(a_31+b_31));
        Console.WriteLine("Hieu cua 2 so vua nhap: "+(a_31-b_31));
        Console.WriteLine("Tich cua 2 so vua nhap: "+(a_31*b_31));
        Console.WriteLine("Thuong cua 2 so vua nhap: "+(a_31/b_31));
    }

    // Câu 3. Viết phương thức đổi số thập phân thành số nhị phân từ một số thập phân nhập vào từ bàn phím.
    static void ThapPhan(int dec_31)
    {
        long bina_31 =0;
        int p_31=0;
        while (dec_31 >0)
        {
        bina_31 += (dec_31 % 2) * Convert.ToInt32(Math.Pow(10,p_31));
        ++p_31;
        dec_31 /=2;
        }
    
    Console.WriteLine("Bin = "+bina_31);
    }

    // Câu 4. Viết phương thức in ra các thông tin của bản thân (họ tên, lớp, mã sv)
    static void ThongTin()
    {
        Console.WriteLine("Ho va ten: Nguyen Trong Khang");
        Console.WriteLine("Lop hoc phan: 221LTC02");
        Console.WriteLine("Lop sinh hoat: 19T1");
        Console.WriteLine("Ma sinh vien: 1911505310131");
    }
        static void Main(string[] args)
        {
             // gọi phương thức câu 1.
            Console.WriteLine("Nhap 2 so tu ban phím: "); 
            Console.WriteLine("Nhập so thu 1= "); double a_31 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập so thu 2= "); double b_31 = Double.Parse(Console.ReadLine());
            Tong_Hieu_Tich_Thuong(a_31,b_31);

            // gọi phương thức câu 3.
            Console.WriteLine("Nhap vao so thap phan: "); int dec_31 = Convert.ToInt32(Console.ReadLine());
            ThapPhan(dec_31);

            // gọi phương thức câu 4
            Console.WriteLine("Thông tin sinh vien: ");
            ThongTin();
        }
    }
}


