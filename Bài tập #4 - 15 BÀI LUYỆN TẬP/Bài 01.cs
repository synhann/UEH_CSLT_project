using System;
using System.Data.SqlTypes;
using System.Text;
namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            decimal gia_ve = 0;
            Console.WriteLine("Nhập tuổi của bạn:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập giờ chiếu:");
            int time = Convert.ToInt32(Console.ReadLine());

            if (age < 12 || age > 60)
            {
                gia_ve = 50;
            }
            if (12 < age && age < 60)
            {
                if (time < 17)
                {
                    gia_ve = 80;
                }
                else
                {
                    gia_ve = 110;
                }
            }

            Console.WriteLine($"Giá vé của bạn là: {gia_ve:N3} VNĐ ");

            Console.ReadKey();

        }

    }
}