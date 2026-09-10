using System;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using System.Text;
namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập số tiền VNĐ: ");
            decimal money = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            string type = Console.ReadLine();
            Console.WriteLine("Đã xác nhận thông tin!");

            decimal phi_dich_vu = (0.005m * money);
            decimal so_tien_tinh_doi = money - phi_dich_vu;

            switch (type)
            {
                case "1":
                    decimal so_tien_nhan_duoc1 = (so_tien_tinh_doi / (int)CurrencyType.USD);
                    Console.WriteLine($"phí dịch vụ (0.5%): {phi_dich_vu:N0} VNĐ");
                    Console.WriteLine($"Số tiền VNĐ tính đổi: {so_tien_tinh_doi:N0} VNĐ");
                    Console.WriteLine($"Số tiền USD nhận được: {so_tien_nhan_duoc1:N2} USD");
                    break;
                case "2":
                    decimal so_tien_nhan_duoc2 = (so_tien_tinh_doi / (int)CurrencyType.EUR);
                    Console.WriteLine($"phí dịch vụ (0.5%): {phi_dich_vu:N0} VNĐ");
                    Console.WriteLine($"Số tiền VNĐ tính đổi: {so_tien_tinh_doi:N0} VNĐ");
                    Console.WriteLine($"Số tiền EUR nhận được: {so_tien_nhan_duoc2:N2} EUR");
                    break;
                case "3":
                    decimal so_tien_nhan_duoc3 = (so_tien_tinh_doi / (int)CurrencyType.JPY);
                    Console.WriteLine($"phí dịch vụ (0.5%): {phi_dich_vu:N0} VNĐ");
                    Console.WriteLine($"Số tiền VNĐ tính đổi: {so_tien_tinh_doi:N0} VNĐ");
                    Console.WriteLine($"Số tiền JPY nhận được: {so_tien_nhan_duoc3:N2} JPY");
                    break;
                case "4":
                    decimal so_tien_nhan_duoc4 = (so_tien_tinh_doi / (int)CurrencyType.GBP);
                    Console.WriteLine($"phí dịch vụ (0.5%): {phi_dich_vu:N0} VNĐ");
                    Console.WriteLine($"Số tiền VNĐ tính đổi: {so_tien_tinh_doi:N0} VNĐ");
                    Console.WriteLine($"Số tiền USD nhận được: {so_tien_nhan_duoc4:N2} GBP");
                    break;
            }

            Console.ReadKey();
        }
    }
    enum CurrencyType
    {
        USD = 25400,
        EUR = 27200,
        JPY = 165,
        GBP = 32100
    }
}

