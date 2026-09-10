using System;
using System.Data.SqlTypes;
using System.Text;
namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double BMI = 0;
            double cao = 0;
            double nang = 0;
            double min = 0;
            double max = 0;

            while (true)
            {
                Console.WriteLine("Nhập chiều cao của bạn (m): ");
                cao = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nhập cân nặng của bạn (kg): ");
                nang = Convert.ToDouble(Console.ReadLine());

                if (cao <= 0 || nang <= 0)
                {
                    Console.WriteLine("[LỖI] Vui lòng kiểm tra lại thông tin");
                }
                else
                {
                    Console.WriteLine("Đã xác nhận thông tin...");
                    break;
                }

            }

            BMI = nang / (cao * cao);
            Console.WriteLine($"Chỉ số BMI của bạn là: {BMI:F2} ");
            
            if (BMI < 18.5)
            {
                Console.WriteLine("Phân loại sức khỏe: Gay (Thiếu cân)");
            }
            if (BMI >= 18.5 && BMI < 23.0 )
            {
                Console.WriteLine("Phân loại sức khỏe: Bình Thường (Lý tưởng)");
            }
            if (BMI >= 23.0 && BMI < 25.0)
            {
                Console.WriteLine("Phân loại sức khỏe: Thừa cân (Tiền béo phì)");
            }
            if (BMI > 25.0)
            {
                Console.WriteLine("Phân loại sức khỏe: Béo phì");
            }

            min = 18.5 * cao * cao;
            max = 22.9 * cao * cao;
            Console.WriteLine($"khuyên dùng: Cân nặng lý tưởng của bạn nên từ {min:F2} kg đến {max:F2} kg");

            Console.ReadKey();
        }
    }
}
