using System;
using System.Data.SqlTypes;
using System.Text;
namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Số Km: ");
            int km = Convert.ToInt32(Console.ReadLine());

            decimal tien = 0;
            decimal discount = 0;
            decimal cuoicung = 0;

            if (km <= 1)
            {
                tien = 15000;
            }
            if (km <= 10)
            {
                tien = 15000 + ((km - 1) * 12000); 
            }
            if (km >= 11)
            {
                tien = 15000 + (9 * 12000) + ((km - 10) * 10000);
            }
            if (km > 30)
            {
                discount = tien * 10 / 100;
            }

            cuoicung = tien - discount;

            Console.WriteLine($"Tổng tiền trước giảm: {tien} VNĐ");
            Console.WriteLine($"Khuyến mãi (10%): -{discount} VNĐ");
            Console.WriteLine($"Thành tiền: {cuoicung} VNĐ");

            Console.ReadKey();

        }

    }
}