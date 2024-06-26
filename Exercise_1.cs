using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace Exercise;

class Program
{
    static void Main(string[] args)
    {
       Console.InputEncoding = Encoding.Unicode;
       Console.OutputEncoding = Encoding.Unicode;
       Console.WriteLine("Nhập giá trị 1 :");
       double Number01 =Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Nhập giá trị 2 :");
       double Number02 =Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Nhập giá trị 3 :");
       double Number03 =Convert.ToDouble(Console.ReadLine()); 
       //tìm kiếm giá trị lớn nhất
       double Maxnumber = Number01;
       if(Number02 > Number01)
       {
        Maxnumber = Number02;
       }
       if(Number03 > Maxnumber)
       {
        Maxnumber =Number03;
       }

       Console.WriteLine($"số lớn nhất là  : {Maxnumber}");
          
    }
}

    