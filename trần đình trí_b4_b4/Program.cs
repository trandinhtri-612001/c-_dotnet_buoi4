
//4. Hãy viết chương trình nhập vào mảng 2 chiều hình chữ nhật, 
//tìm phần tử x (x nhập từ bàn phím) có nằm trong mảng trên không? In ra vị trí của 
//phần tử nếu nằm trong mảng.
using System;

public class Program
{
	public static void Main(string[] args)
        {
            int [,] m1 = new int[100,100];
            int row, col;
            Console.WriteLine("nhap vao so hang cua mang");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap vao so cot cua mang");
            col= Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("nhap vao phan tu cua mang");

for(int i=0;i<row;i++){
        for(int j =0;j<col;j++){
                Console.Write("nhap phan tu thu m1["+i+","+j+"] = ");
                m1[i,j] = Convert.ToInt32(Console.ReadLine());
        }
}

int s;
int t=0;

Console.WriteLine("nhap vao phan tu can tim");
            s= Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<row;i++){
        for(int j =0;j<col;j++){
                if(s == m1[i,j]){
                       t=1;
                       Console.WriteLine("phan tru co trong mang va nam o vi tri m1["+i+","+j+"]"); 
                }
        }
}

if(t==0){
    Console.WriteLine("phan tu khong co trong mang");     

}
        }
}