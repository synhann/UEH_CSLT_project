using System.Text;
using System.Text;

namespace BaiTap6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("=== BÀI TẬP 6: DÃY SỐ HARMONIC ===");
            Console.Write("Nhập số lượng số hạng (n): ");

            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                double sum = 0.0;

                Console.WriteLine($"Các số hạng của dãy Harmonic từ 1 đến {n}:");
                for (int i = 1; i <= n; i++)
                {
                    if (i < n)
                    {
                        Console.Write($"1/{i} + ");
                    }
                    else
                    {
                        Console.Write($"1/{i}");
                    }
                    sum += 1.0 / i;
                }

                Console.WriteLine($"Tổng của chuỗi Harmonic = {sum:F4}");
            }
            else
            {
                Console.WriteLine("Vui lòng nhập n là một số nguyên dương lớn hơn 0!");
            }

            Console.WriteLine("Bấm phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}