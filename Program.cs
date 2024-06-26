using System.Text;
namespace Lession04;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
       
        Console.WriteLine("xin chảo!");
        Console.Write("");
        
        //Khai Báo tên 
        //Console.WriteLine(" Nhập tên người dùng ");
        //string ImputN=Console.ReadLine();
        //Console.WriteLine(ImputN);

    
        //Khai báo hằng 
        //const double pip =3.13;
        // Khai báo biến bằng các từ khóa var
        //var score = 8; 
        //Console.WriteLine(score.GetType());
        // Lưu trữ dữ liệu => xử lý dữ liệu =? toán tử 
        /* 
            ctrl + / => comment/uncomment
            1.toán tử số học : +,-,*,/,%  => kết quả là một giá trị số 
            2.Toán so sánh : > ,>= , <,<=,== kết quả giá trị bool(true/false)
            3.Toán tử logic : &&(and) , || (or) , !(note) => kket61 hợp nhiều biểu thức logic => giá trị bool 
        */
        // int soDU = 10%4; 
        //string firstname = "Khoa";
        //string lasname = "Nguyễn";
        //string fullname= firstname + " " +lastname ; 
        //string fullname = string.Format("{0} {1}",firstname , lasname);
        //String templates
        //string fullname = $"{firstname}{Lastname}";
       // string statement= $"{5*2} + {8*4} = {10 + 32}";
        //Console.Write("Enter Num 1 = "); 
        //int number_1 = int.Parse(Console.ReadLine());
        //Console.Write("Enter Num 2 = "); 
        //int number_2 = int.Parse(Console.ReadLine());
        //.WriteLine($"{number_1}"{number_2} = [number_1 + number_2]
        bool gender =true;
        bool married = true ;
        string name = "Bình";
        if(gender)
        {
            Console.WriteLine($"Mr.{name}");
        }
        else 
        {
            Console.WriteLine($"Ms.{name}");
        }
    }



}
