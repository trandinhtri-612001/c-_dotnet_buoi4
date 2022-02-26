//1. Sử dụng ứng dụng Console hãy viết chương trình giải phương trình bậc hai ax2 + bx + c = 0.


using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        float a,b,c;
        Console.WriteLine("nhap hej so a ,b,c :");
        a= Convert.ToInt32(Console.ReadLine());
        b= Convert.ToInt32(Console.ReadLine());
        c= Convert.ToInt32(Console.ReadLine());
        if(a==0){
          if(b==0){
            Console.WriteLine("phuong trinh vo nghiem");

          }else{
            Console.WriteLine("phuwong trinh co nghiem: x= "+ (-c/b)  );
          }
        }


        float dt = b*b - 4*a*c;
        float x1,x2;
        if(dt>0){
          x1 = (float) ((-b +Math.Sqrt(dt))/(2*a));
          x2 =(float) ((-b - Math.Sqrt(dt))/(2*a));
          Console.WriteLine("pt co hai nghiem x1= "+x1 + ":x2 = "+x2);
        }else if(dt ==0 ){
          x1 = (float) (-b/(2*a));
             Console.WriteLine("pt co  nghiem x1=x2 "+x1 );
        }else{
          Console.WriteLine("pt vo nghiem");
        }


    }
  }
}