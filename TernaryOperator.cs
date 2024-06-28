using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
namespace TernaryOperator;
class TO

 {  
    static void Main(string[] args)
    {
        bool gender =true; 
        bool married =true; 
        string firstName = "Bình"; 
    
    //Console.Write(string result =  gender ? $"Mr.{firstName}": married ? $"Mrs. {firstName}" : $"Ms. {firstName}");
    Console.Write($"{(gender ? "Mr" : married ? "Mrs":"Ms")}.{firstName}");
    }
    //? : ternary operator 
    


 }