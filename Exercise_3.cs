using System;
using System.Text;
using Microsoft.VisualBasic;
namespace Exercise_3;
class Program

 {  
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        Console.Write("Nhập số a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập số b = ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập số c = ");
        double c = Convert.ToDouble(Console.ReadLine());
        //Hiễn thị dãy số 
        Console.WriteLine($"{a}x2 + {b}x + {c} = 0");
        //Tính Delta 
        double delta = b*b - 4*a*c;
        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($" Phương trình có hai nghiệm phân biệt : x1 = {x1} , x2 = {x2} ");
        }
        else if (delta == 0)
        {
            double x = -b / (2*a);
            Console.WriteLine($" Phương trình có một nghiệm kép : x");
        }
        else 
        {
            Console.WriteLine(" Phương trình vô nghiệm");
        }
    }
 }
