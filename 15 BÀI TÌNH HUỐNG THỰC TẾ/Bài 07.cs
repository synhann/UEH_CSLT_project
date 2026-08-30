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
            double tieu_thu = 0;
            decimal chi_phi = 0;
            decimal tien_moi_nguoi = 0;
            decimal skibidi = 0;

            Console.WriteLine("Quãng đường (km):");
            double quang_duong = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mức tiêu hao (L/100km): ");
            double tieu_hao = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Giá xăng (VNĐ/Lít): ");
            decimal gia_xang = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Số người đi: ");
            int nguoi = Convert.ToInt32(Console.ReadLine());

            tieu_thu = (quang_duong / 100) * tieu_hao;
            Console.WriteLine($"Tổng nhiên liệu tiêu thụ: {tieu_thu:F2}");

            chi_phi = Convert.ToDecimal(tieu_thu) * gia_xang;
            Console.WriteLine($"Tổng chi phí xăng dầu: {chi_phi:N0} VNĐ");

            tien_moi_nguoi = chi_phi / nguoi;
            skibidi = Math.Ceiling(tien_moi_nguoi / 1000) * 1000;
            Console.WriteLine($"Chi phí mỗi người: {skibidi:N0} VNĐ");

            Console.ReadKey();

        }

    }
}
