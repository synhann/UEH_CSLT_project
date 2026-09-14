using System;
using System.Data.SqlTypes;
using System.Text;
namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Phím bấm: ");
            string a = Console.ReadLine();

            switch (a)
            {
                case "1":
                    Console.WriteLine("[Tổng đài]: Đang kết nối với tổng dài viên tư vấn thẻ. ");
                    break;
                case "2":
                    Console.WriteLine("[Tổng đài]: Đang tra cứu số dư. ");
                    break;
                case "3":
                    Console.WriteLine("[Tổng đài]: Yêu cầu khóa thẻ khẩn cấp đã được ghi nhận. ");
                    break;
                case "4":
                    Console.WriteLine("[Tổng đài]: Đang kêt nối hệ thống tra cứu tỷ giá ngoại tệ. ");
                    break;
                case "0":
                    Console.WriteLine("[Tổng đài]: Yêu cầu quay lại menu chính đã được ghi nhận. ");
                    break;
            }

            Console.ReadKey();

        }

    }
}