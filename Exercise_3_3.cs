using System;
using System.Collections;
using System.Text;
using Microsoft.VisualBasic;
namespace Exercise_3_3;
class Program

 {  
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        Console.Write("Nhập điểm số = ");
        double Point = Convert.ToDouble(Console.ReadLine());
        switch(Point >=10 && Point<=9)
        {
            case true :
            Console.WriteLine("Học sinh Xuất con bà nó sắc ");
            break;
        }
            

        
    }
 }