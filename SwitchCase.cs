using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace Switch_case;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        Console.Write("Enter day : ");
        int day =  Convert.ToInt32(Console.ReadLine());
        
        //Display 

        switch(day)
        {
            case 1 : 
            {
                Console.Write("Thứ 2 ");
                break;
            }
            case 2 :
            {
                Console.Write("thứ 3");
                break;
            }
            case 3 :
            {
                Console.Write("thứ 4");
                break;
            }
            case 4 :
            {
                Console.Write("thứ 5");
                break;
            
            }
            case 5 :
            {
                Console.Write("thứ 6");
                break;
            
            } 
            case 6 :
            {
                Console.Write("thứ 7");
                break;
            
            }
            case 7 : 
            {
                Console.Write("CN");
                break;
            
            }
            default:
            {
                Console.WriteLine("số bạn nhập ko hợp lệ");
                break;
            }
        
        }
    }
} 