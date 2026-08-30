using System;
using System.Text;
namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Mã OTP nhận được (839201):");
            DateTime CreationTime = DateTime.Now;
            int dubai = Convert.ToInt32(Console.ReadLine());
            if (dubai == 839201)
            {
                DateTime alibaba = DateTime.Now;
                TimeSpan alamove = CreationTime - alibaba;
                if (alamove.TotalSeconds <= 10)
                {
                    Console.WriteLine("THÀNH CÔNG -Giao dịch đã được phê duyệt.");
                }
                else
                {
                    Console.WriteLine("Mã OTP của bạn đã hết hạn.");
                }

            }
            else
            {
                Console.WriteLine("Định dạng không hợp lệ hoặc mã bị sai.");
            }    

            Console.ReadKey();
        }

    }
}