using System;
using System.Data.SqlTypes;
using System.Text;
namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số dư tài khoản của bạn:");
            decimal so_du = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Nhập số tiền muốn rút: ");
            decimal tien_rut = Convert.ToDecimal(Console.ReadLine());
            decimal dk = tien_rut % 50000;
            if (tien_rut != 0)
            {
                if (dk == 0)
                {
                    if (dk != 5000000)
                    {
                        if (tien_rut <= so_du)
                        {
                            so_du -= tien_rut;
                            Console.WriteLine($"Giao dịch thành công. Số dư còn lại: {so_du:N0} VNĐ");
                        }
                        else
                        {
                            Console.WriteLine(" Số tiền rút không vượt quá số dư hiện tại. \r\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Hạn mức rút tối đa 5,000,000 VNĐ / lần. ");
                    }
                }
                else
                {
                    Console.WriteLine("Số tiền rút phải là bội số của 50,000 VNĐ.");
                }    
            }
            else
            {
                Console.WriteLine("Số tiền rút phải lớn hơn 0.");
            }


Console.ReadKey();

        }

    }
}