// 6 Sử dụng kiểu cấu trúc khai báo điểm A(xa, ya); B(xb, yb).
// Nhập và tính độ dài đoạn thẳng AB


using System;

struct Diem {
    public int xa, ya;
    public int xb,yb;
};  

public class DOANTHANG {
   public static void Main(string[] args) {
    Diem diem = new Diem();
      Console.WriteLine("nhap toa do cua diem a");
      diem.xa = Convert.ToInt32(Console.ReadLine());
       diem.ya = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("nhap toa do cua diem b");
        diem.xb = Convert.ToInt32(Console.ReadLine());
         diem.yb = Convert.ToInt32(Console.ReadLine());

        double dd =0 ;
         dd += (double)Math.Sqrt((diem.xb-diem.xa)*(diem.xb-diem.xa)+(diem.yb- diem.ya)*(diem.yb-diem.ya));

          Console.WriteLine("doan thanh ab co do dai la :"+ dd);

   }
}