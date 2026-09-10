using System;
using System.Data.SqlTypes;
using System.Text;
namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập role của bạn: ");
            string role = Console.ReadLine();

            switch (role)
            {
                case "ADMIN":
                    Console.WriteLine("[THÔNG BÁO: Toàn quyền quản trị hệ thống.");
                    break;
                case "MANAGER":
                    Console.WriteLine("[THÔNG BÁO: Quyền quản lý nhân sự và xem báo cáo.");
                    break;
                case "EMPLOYEE":
                    Console.WriteLine("[THÔNG BÁO: Quyền tạo và chỉnh sửa hồ sơ cá nhân.");
                    break;
                case "GUEST":
                    Console.WriteLine("[THÔNG BÁO: Chỉ có quyền xem thông tin công khai.");
                    break;
            }    

            Console.ReadKey();

        }

    }
}
