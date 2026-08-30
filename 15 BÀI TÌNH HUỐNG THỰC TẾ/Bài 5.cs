using System;
using System.Text;
using System.Threading.Tasks.Sources;
namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double score_avg = 0;
 
            Console.WriteLine("Nhập điểm số thang 10 môn Lập trình C#:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập điểm số thang 10 môn Toán rời rạc:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập điểm số thang 10 môn Tiếng Anh:");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ ");
            double c1 = Convert.ToDouble(Console.ReadLine());

            score_avg = ((a * a1) + (b * b1) + (c * c1)) / (a1 + b1 + c1);
            Console.WriteLine($"Điểm TB Thang 10: {score_avg:F2} ");

            if (8.5 <= score_avg && score_avg <= 10)
            {
                Console.WriteLine("Điểm chữ quy đổi: A");
                Console.WriteLine($"Điểm GPA thang 4: {(double)scr_GPA.A:F1}");
                Console.WriteLine("Xếp loại học lực: Xuất sắc / Giỏi");
            }
            if (7.0 <= score_avg && score_avg <= 8.4)
            {
                Console.WriteLine("Điểm chữ quy đổi: B");
                Console.WriteLine($"Điểm GPA thang 4: {(double)scr_GPA.B:F1}");
                Console.WriteLine("Xếp loại học lực: Khá");
            }
            if (5.5 <= score_avg && score_avg <= 6.9)
            {
                Console.WriteLine("Điểm chữ quy đổi: C");
                Console.WriteLine($"Điểm GPA thang 4: {(double)scr_GPA.C:F1}");
                Console.WriteLine("Xếp loại học lực: Trung Bình");
            }
            if (4.0 <= score_avg && score_avg <= 5.4)
            {
                Console.WriteLine("Điểm chữ quy đổi: D");
                Console.WriteLine($"Điểm GPA thang 4: {(double)scr_GPA.D:F1}");
                Console.WriteLine("Xếp loại học lực: Yếu");
            }
            if (score_avg <= 4.0)
            {
                Console.WriteLine("Điểm chữ quy đổi: F");
                Console.WriteLine($"Điểm GPA thang 4: {(double)scr_GPA.F:F1}");
                Console.WriteLine("Xếp loại học lực: Kém (Trượt)");
            }

            Console.ReadKey();
        }
    }
    enum scr_GPA
    {
        A = 4, 
        B = 3, 
        C = 2, 
        D = 1, 
        F = 0
    }
}