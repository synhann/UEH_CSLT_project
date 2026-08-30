using System;
using System.Text;
namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            decimal goku = 0;
            decimal thu_nhap_chiu_thue = 0;

            Console.WriteLine("Lương Gross:");
            decimal luong = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Số người phụ thuộc:");
            int nguoi = Convert.ToInt32(Console.ReadLine());

            goku = 0.105m * luong;
            Console.WriteLine(goku);
            Console.WriteLine($"Giảm trừ bảo hiểm: {goku:N0}");

            thu_nhap_chiu_thue = luong - goku - 11000000 - (nguoi * 4400000);
            if (thu_nhap_chiu_thue <= 0)
            {
                thu_nhap_chiu_thue = 0;
            }
            Console.WriteLine($"Thu nhập chịu thuế: {thu_nhap_chiu_thue:N0}");

            decimal thueTNCN = TinhThueLuyTien(thu_nhap_chiu_thue);
            Console.WriteLine($"Thuế TNCN phải nộp: {thueTNCN:N0}");
            decimal luongNet = luong - goku - thueTNCN;
            Console.WriteLine($"LƯƠNG NET THỰC NHẬN: {luongNet:N0}");
            Console.ReadKey();
        }

        public static decimal TinhThueLuyTien(decimal tnct)
        {
            if (tnct <= 0) return 0;

            decimal thue = 0;

            if (tnct > 5000000m)
            {
                thue += 5000000m * 0.05m;
            }
            else
            {
                return thue + (tnct * 0.05m);
            }

            if (tnct > 10000000m)
            {
                thue += 5000000m * 0.10m;
            }
            else
            {
                return thue + ((tnct - 5000000m) * 0.10m);
            }

            if (tnct > 18000000m)
            {
                thue += 8000000m * 0.15m;
            }
            else
            {
                return thue + ((tnct - 10000000m) * 0.15m);
            }

            if (tnct > 32000000m)
            {
                thue += 14000000m * 0.20m;
            }
            else
            {
                return thue + ((tnct - 18000000m) * 0.20m);
            }

            if (tnct > 52000000m)
            {
                thue += 20000000m * 0.25m;
            }
            else
            {
                return thue + ((tnct - 32000000m) * 0.25m);
            }

            if (tnct > 80000000m)
            {
                thue += 28000000m * 0.30m;

                thue += (tnct - 80000000m) * 0.35m;
            }
            else
            {
                return thue + ((tnct - 52000000m) * 0.30m);
            }

            return thue;
        }
    }
}