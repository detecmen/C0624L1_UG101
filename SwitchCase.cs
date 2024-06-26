using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace Switch_case;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter month: ");
        int month = Convert.ToInt32(Console.ReadLine());
        switch(month)
        {
            case 1 : 
            {
                Console.Write("31 days");
                break;
            }
            case 2 :
            {
                Console.Write("28 or 29 days");
                break;
            }
            case 3 :
            {
                Console.Write("31 days");
                break;
            }
            case 4 :
            {
                Console.Write("30 days");
                break;
            }
            case 5 :
            {
                Console.Write("31 days");
                break;
            }
            case 6 :
            {
                Console.Write("30 days");
                break;
            }
            case 7 :
            {
                Console.Write("31 days");
                break;
            }
            case 8 :
            {
                Console.Write("31 days");
                break;
            }
            case 9 :
            {
                Console.Write("31 days");
                break;
            }
            }
            default
        }
    }
}