using System;
using System.Text;

namespace BaiTap7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("=== BÀI TẬP 7: TÌM SỐ HOÀN HẢO TRONG KHOẢNG ===");

            Console.Write("Nhập số bắt đầu của khoảng (start): ");
            bool checkStart = int.TryParse(Console.ReadLine(), out int start);

            Console.Write("Nhập số kết thúc của khoảng (end): ");
            bool checkEnd = int.TryParse(Console.ReadLine(), out int end);

            if (checkStart && checkEnd && start > 0 && end >= start)
            {
                Console.WriteLine($"Các số hoàn hảo trong khoảng từ {start} đến {end} là:");
                bool found = false;

                for (int num = start; num <= end; num++)
                {
                    if (IsPerfectNumber(num))
                    {
                        Console.WriteLine($"- Số {num}");
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Không tìm thấy số hoàn hảo nào trong khoảng này.");
                }
            }
            else
            {
                Console.WriteLine("Khoảng nhập vào không hợp lệ! (Lưu ý: các số phải > 0 và end >= start)");
            }

            Console.WriteLine("Bấm phím bất kỳ để thoát...");
            Console.ReadKey();
        }
        static bool IsPerfectNumber(int number)
        {
            if (number <= 1) return false;

            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            return sum == number;
        }
    }
}