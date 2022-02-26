//2. Sử dụng ứng dụng Console hãy viết chương trình nhập vào một tháng, một năm hiển thị
// số ngày tương ứng của tháng đó.
using System;


namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int th, n;
      int sn=0;
      Console.WriteLine("nhap thang va nam ");
      th = Convert.ToInt32(Console.ReadLine());
      n = Convert.ToInt32(Console.ReadLine());
      if(th >=1 && th <=12){
          switch(th){
              case 1:
              sn =30;
              break;
              case 2:
              if(n %400 == 0 || (n %4 == 0 &&n %100 != 0)){
                  sn = 29;
              }else{
                  sn  =28;
              }
              break;
              case 3:
              sn =30;
              break;
              case 4:
              sn =30;
              break;
              case 5:
              sn =30;
              break;
              case 6:
              sn =30;
              break;
              case 7:
              sn =30;
              break;
              case 8:
              sn =30;
              break;
              case 9:
              sn =30;
              break;
              case 10:
              sn =30;
              break;
              case 11:
              sn =30;
              break;
              case 12:
              sn =31;
              break;
              


          }
          Console.WriteLine("thang" + th + "co so ngay la " + sn);

      }else{
          Console.WriteLine("so ngay hoac so thang khong hop le");
      }
Console.ReadLine();




    }
  }
}