//Viết chương trình nhập vào một mảng 1 chiều in ra màn hỉnh các số là số chính phương của mảng
// (yêu cầu xây dựng hàm kiểm tra số chính phương)


using System;
 
namespace bai5_sochinhphuong
{
    class Program
    {
        static bool kt(int n){
            double s = Math.Sqrt(n);
            if(s*s ==n ){
                return true;
            }else{
                return false;
            }

        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("nhap so phan tu trong mang");
            n = Convert.ToInt32(Console.ReadLine());
Console.Write("nhap  phan tu trong mang");
 int [] a = new int[n];
 for(int i=0;i<n;i++){
a[i] = Convert.ToInt32(Console.ReadLine());
 }
Console.WriteLine("cac so chinh phuong trong mang la");
 for(int i=0;i<n;i++){
if(kt(a[i])){
    Console.WriteLine(a[i]);
}
 }
            
    }
}
}