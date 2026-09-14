using System;
using System.Data.SqlTypes;
using System.Text;
namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhap so tien VND: ");
            double amountVND = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap ma ngoai te (USD, EUR, JPY): ");
            string currencyCode = Console.ReadLine().Trim().ToUpper(); 

            double convertedAmount = 0;
            bool isValidCurrency = true;

            switch (currencyCode)
            {
                case "USD":
                    convertedAmount = amountVND / 25400;
                    break;
                case "EUR":
                    convertedAmount = amountVND / 27200;
                    break;
                case "JPY":
                    convertedAmount = amountVND / 165;
                    break;
                default:
                    isValidCurrency = false;
                    Console.WriteLine("Ma ngoai te khong hop le!");
                    break;
            }

            if (isValidCurrency)
            {
                Console.WriteLine($"So tien sau quy doi: {convertedAmount:F2} {currencyCode}");
            }

            Console.ReadKey();
        }
    }
}