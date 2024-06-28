using System;
using System.Text;
using Microsoft.VisualBasic;
namespace Exercise_3_2;
class Program

 {  
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        Console.Write("Nhập điểm số = ");
        double Point = Convert.ToDouble(Console.ReadLine());
        if (Point<=10 && Point>=9)
        {
            Console.WriteLine("Học sinh Xuất con bà nó sắc ");
        }
        else if (Point<=9 && Point>=8)
        {
            Console.WriteLine("Học sinh Giỏi");
        }
        else if (Point<=8 && Point>=7)
        {
            Console.WriteLine("Học sinh Khá");
        }
        else if (Point<=7 && Point>=5)
        {
            Console.WriteLine("Học sinh TB");
        }
        else if (Point<=5 && Point>=0)
        {
             Console.WriteLine("Học sinh kém");
        }
        else 
            Console.WriteLine("Sai so lieu");
    }
 }