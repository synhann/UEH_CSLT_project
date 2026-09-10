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
            

            const decimal bac1 = 1806;
            const decimal bac2 = 1866;
            const decimal bac3 = 2167;
            const decimal bac4 = 2729;
            const decimal bac5 = 3050;
            int a = 0;
            int b = 0;
            decimal money = 0;
            decimal thue = 0;
            decimal total = 0;
         
            while (true)
            {
                Console.WriteLine("Nhập chỉ số điện cũ (kWh): ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập chỉ số điện mới (kWh): ");
                b = Convert.ToInt32(Console.ReadLine());

                if (a == b)
                {
                    Console.WriteLine("[LỖI] Hai số giống nhau! Vui lòng nhập lại");
                }
                if (a > b)
                {
                    Console.WriteLine("[LỖI] Chỉ số mới phải lớn hơn chỉ số cũ! Vui lòng nhập lại");
                }
                if (a < b)
                {
                    Console.WriteLine("Đã xác nhận thông tin...");
                    break;
                }

            }
            int tieu_thu = (b - a);
            Console.WriteLine("Số điện tiêu thụ là: " + tieu_thu + "kWh");

            if (tieu_thu <= 50)
            {
                money = tieu_thu * bac1;
            }
            if (51 <= tieu_thu && tieu_thu <= 100)
            {
                money = (50 * bac1) + (tieu_thu - 50) * bac2;
            }
            if (101 <= tieu_thu && tieu_thu <= 200)
            {
                money = (50 * bac1) + (50 * bac2) + (tieu_thu - 100) * bac3;
            }
            if (201 <= tieu_thu && tieu_thu <= 300)
            {
                money = (50 * bac1) + (50 * bac2) + (100 * bac3) + (tieu_thu - 200) * bac4;
            }
            if (301 <= tieu_thu)
            {
                money = (50 * bac1) + (50 * bac2) + (100 * bac3) + (100 * bac4) + (tieu_thu - 300) * bac5;
            }
            Console.WriteLine("Tiền điện chưa thuế là: " + money + " VNĐ");

            thue = money * 8 / 100;
            Console.WriteLine("Thuế VAT 8% là: " + thue + " VNĐ");

            total = thue + money;
            Console.WriteLine("Tổng thanh toán: " + total + " VNĐ");

            Console.ReadKey();

        }

    }
}
