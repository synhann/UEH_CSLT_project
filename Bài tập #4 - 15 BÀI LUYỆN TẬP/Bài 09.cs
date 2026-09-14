using System;
using System.Data.SqlTypes;
using System.Text;
namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhap diem GPA (he 4.0): ");
            double gpa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem ren luyen DRL (he 100): ");
            int drl = Convert.ToInt32(Console.ReadLine());

            if (gpa >= 3.6 && drl >= 90)
            {
                Console.WriteLine("Ket qua: Hoc bong Xuat sac (Muc 100%)");
            }
            else if (gpa >= 3.2 && drl >= 80)
            {
                if (gpa < 3.6 && drl < 90)
                {
                    Console.WriteLine("Ket qua: Hoc bong Kha/Gioi (Muc 50%) (Do GPA < 3.6 va DRL < 90)");
                }
                else if (gpa < 3.6)
                {
                    Console.WriteLine("Ket qua: Hoc bong Kha/Gioi (Muc 50%) (Do GPA < 3.6)");
                }
                else
                {
                    Console.WriteLine("Ket qua: Hoc bong Kha/Gioi (Muc 50%) (Do DRL < 90)");
                }
            }
            else
            {
                Console.WriteLine("Ket qua: Khong dat hoc bong");
            }

            Console.ReadKey();
        }
    }
}