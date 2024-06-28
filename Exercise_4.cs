using System;
using System.Text;
using Microsoft.VisualBasic;
namespace Exercise_4;
class Program

 {  
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
       
        double a = 4.5;
        int b = 5;
        double c = a+b;
        Console.WriteLine($"số c là : {c}");
    }
 }
       