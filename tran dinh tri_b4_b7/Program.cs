//7. Viết chương trình tạo một struct sinh viên bao gồm : mã sinh viên, họ tên,
// năm sinh, điểm trung bình tích lũy

//Nhập vào n sinh viên từ bàn phím, sau đó in ra danh sách sinh viên đã nhập, 
//hiển thị thông tin của sinh viên có điểm trung bình tích lũy lớn nhất

using System;

namespace sinhvien
{
    struct SinhVien{
 public  string msv;
 public string ht;
 public int ns;
 public float tb;
    
}; 
 class Program
  {
    static void Main(string[] args)
    {
        int n;
        Console.Write("nhap so sinh vien");
        n=Convert.ToInt32(Console.ReadLine());

SinhVien[] sv = new SinhVien[n];
Console.WriteLine("nhap thong tin sinh vien");
           for(int i=0;i<n;i++){
            Console.WriteLine("nhap thong tin sinh vien, msv, ht, ns, tb  thu" + i+1);
            sv[i].msv = Console.ReadLine();
            sv[i].ht = Console.ReadLine();
            sv[i].ns = Convert.ToInt32(Console.ReadLine());
            sv[i].tb = float.Parse(Console.ReadLine());
           }

Console.WriteLine("danh sách thong tin sinh vien da nhap");
           for(int i=0;i<n;i++){
            Console.WriteLine("sv thu " +i +1);
Console.WriteLine("msv = " +sv[i].msv);
Console.WriteLine("ht = " +sv[i].ht);
Console.WriteLine("ns = "+sv[i].ns);
Console.WriteLine("diem tb = "+sv[i].tb);;

           }
        int vt=0;
        SinhVien max = sv[0];
        for(int i=0;i<n;i++){
            if(max.tb <sv[i].tb){
                vt = i;
            }
        }
Console.WriteLine("thong tin sinh vien cos diem trung binh cao nhat");
Console.WriteLine("sv thu " +vt);
Console.WriteLine("msv = " +sv[vt].msv);
Console.WriteLine("ht = " +sv[vt].ht);
Console.WriteLine("ns = "+sv[vt].ns);
Console.WriteLine("diem tb = "+sv[vt].tb);
    }
  }
}