
// Sử dụng ứng dụng Console hãy viết chương trình nhập vào một số gồm 4 chữ số,
// tính tổng 4 chữ số này nếu chia cho 10 dư 9 thì kết luận ”Bạn có biển số đẹp”, 
//ngược lại, kết luận ”Bạn có biển số chưa đẹp”.

using System;

namespace MyApplication
{
  class Program
  {


    static void Main(string[] args)
    {
      
 string a;
 Console.WriteLine("mowi nhap so gom 4 chu so");
 a = Console.ReadLine();
 int k = 0;
 char[] arr = new char[a.Length];
 for(int i = 0;i<arr.Length;i++){
     arr = a.ToCharArray(0,arr.Length);
 }

      for(int i = 0;i<arr.Length;i++){
     k += Convert.ToInt32(arr[i].ToString());
     
 }   
     if(k%10 == 9){
         Console.WriteLine("ban cos bien so dep");
     }else{
         Console.WriteLine("ban cos bien chua so dep");
     }
    }
  }
}
