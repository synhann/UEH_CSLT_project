using System;
using System.Data.SqlTypes;
using System.Text;
namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double BMI = 0;
            double cao = 0;
            double nang = 0;

            while (true)
            {
                Console.Write("Nhập chiều cao của bạn (m): ");
                cao = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhập cân nặng của bạn (kg): ");
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

            if (BMI < 18.5)
            {
                Console.WriteLine($"BMI: {BMI:F2} - Đánh giá: Thầy gầy - Nên bổ sung dinh dưỡng");
            }
            if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine($"BMI: {BMI:F2} - Đánh giá: Cân đối - Tiếp tục duy trì.");
            }
            if (BMI >= 25.0 && BMI < 30)
            {
                Console.WriteLine($"BMI: {BMI:F2} - Đánh giá: Thừa cân - Nên tăng cường luyện tập.");
            }
            if (BMI > 30)
            {
                Console.WriteLine($"BMI: {BMI:F2} - Đánh giá: Béo phì - Cần sự tư vấn từ bác sĩ.");
            }

            Console.ReadKey();
        }
    }
}