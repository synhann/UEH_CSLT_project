using System;
using System.Data.SqlTypes;
using System.Text;
namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập loại xe: ");
            string xe = Console.ReadLine();
            Console.Write("Nhập thời gian gửi: ");
            int time = Convert.ToInt32(Console.ReadLine());

            switch (xe)
            {
                case "BIKE":
                    if (time == 1)
                    {
                        Console.WriteLine("Phí gửi xe Đạp (Ban ngày): 5,000 VNĐ");
                    }
                    else
                    {
                        Console.WriteLine("Phí gửi xe Đạp (Ban đêm): 10,000 VNĐ");
                    }    
                    break;
                case "CAR":
                    if (time == 1)
                    {
                        Console.WriteLine("Phí gửi xe Ô tô (Ban ngày): 30,000 VNĐ");
                    }
                    else
                    {
                        Console.WriteLine("Phí gửi xe Ô tô (Ban đêm): 60,000 VNĐ");
                    }
                    break;
            }    

            Console.ReadKey();
        }
    }
}