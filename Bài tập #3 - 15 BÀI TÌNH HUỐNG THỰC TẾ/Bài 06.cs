using System;
using System.ComponentModel.Design;
using System.Text;
using System.Xml.Linq;
namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập họ tên thô:");
            string raw = Console.ReadLine();
            string result1 = raw.Trim();
            string[] result3 = result1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < result3.Length; i++)
            {
                if (result3[i].Length > 0)
                {
                    string word = result3[i].ToLower();
                    result3[i] = char.ToUpper(word[0]) + word.Substring(1);
                }
            }

            string result4 = string.Join(" ", result3);
            Console.WriteLine("Họ và tên chuẩn hóa là: " + result4);

            if (result3.Length == 2)
            {
                Console.WriteLine("Họ: " + result3[0] + " Tên đệm: Không Tên: " + result3[1]);
                string ski2 = result3[1] + "." + result3[0];
                Console.WriteLine("Username tạo tự động: " + ski2);
                Console.WriteLine("Email cấp phát: " + ski2 + "@company.edu.vn");
            }
            else if (result3.Length == 3)
            {
                Console.WriteLine("Họ: " + result3[0] + "| Tên đệm: " + result3[1] + "| Tên: " + result3[2]);
                string ski3 = result3[2] + "." + result3[0] + result3[1];
                Console.WriteLine("Username tạo tự động: " + ski3);
                Console.WriteLine("Email cấp phát: " + ski3 + "@company.edu.vn");
            }
            else if (result3.Length == 4)
            {
                Console.WriteLine("Họ: " + result3[0] + " Tên đệm: " + result3[1] + result3[2] + " Tên: " + result3[3]);
                string ski4 = result3[3] + "." + result3[0] + result3[1] + result3[2];
                Console.WriteLine("Username tạo tự động: " + ski4);
                Console.WriteLine("Email cấp phát: " + ski4 + "@company.edu.vn");
            }
            else if (result3.Length == 5)
            {
                Console.WriteLine("Họ: " + result3[0] + " Tên đệm: " + result3[1] + result3[2] + result3[3] + " Tên: " + result3[4]);
                string ski5 = result3[4] + "." + result3[0] + result3[1] + result3[2] + result3[3];
                Console.WriteLine("Username tạo tự động: " + ski5);
                Console.WriteLine("Email cấp phát: " + ski5 + "@company.edu.vn");
            }


            Console.ReadKey();

        }



    }
}
