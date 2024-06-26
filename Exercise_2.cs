using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace Exercise_2;

class Program
{
    static void Main(string[] args)
    {
       Console.InputEncoding = Encoding.Unicode;
       Console.OutputEncoding = Encoding.Unicode;
       Console.Write("Nhập cân nặng (kg):");
       double Weight =Convert.ToDouble(Console.ReadLine());
       Console.Write("Nhập chiều cao(cm):");
       double Height =Convert.ToDouble(Console.ReadLine());
       //Chuyển Cm thành M
       double HeightM = Height/100;
       double BMI = Weight / (HeightM*HeightM);
       Console.WriteLine($"chỉ số BMI : {BMI}");
       //So sánh
        if(BMI<18)
        {
            Console.Write("Bạn có thể trạng gầy ");
        }
        else if (BMI>=18 && BMI<=24.9)
        {
            Console.Write("Bạn có thể trạng bình thường");
        }
        else if (BMI>=25 && BMI<=29.9)
        {
            Console.Write("Bạn đang có xu hướng tăng cân");
        }
        else if (BMI>=30 && BMI<=34.9)
        {
            Console.Write("Bạn bị béo phì độ 1");
        }
        else if (BMI>=30 && BMI<=34.9)
        {
            Console.Write("Bạn bị béo phì độ 1");
        }
         else if (BMI>=35 && BMI<=39.9)
        {
            Console.Write("Bạn bị béo phì độ 2");

        }
        else 
        {
            Console.Write("Bạn bị béo phì độ 3");
        }       
    }
}

    