using System;
using System.Data.SqlTypes;
using System.Text;
namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Trạng thái: ");
            string a = Console.ReadLine();

            switch (a)
            {
                case "1":
                    Console.WriteLine("[Trạng thái]: Chờ xác nhận thanh toán. ");
                    break;
                case "2":
                    Console.WriteLine("[Trạng thái]: Đang đóng gói và bàn giao đơn vị vận chuyển. ");
                    break;
                case "3":
                    Console.WriteLine("[Trạng thái]: Đơn hàng đang trên đường giao đến bạn. ");
                    break;
                case "4":
                    Console.WriteLine("[Trạng thái]: Đơn hàng đã hoàn thành. Cảm ơn bạn! ");
                    break;
                case "5":
                    Console.WriteLine("[Trạng thái]: Đơn hàng đã hủy. Xuất phiếu hoàn tiền. ");
                    break;
            }

            Console.ReadKey();

        }

    }
}