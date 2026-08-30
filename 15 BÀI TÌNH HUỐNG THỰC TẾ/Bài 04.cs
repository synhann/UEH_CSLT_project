using System;
using System.Data.SqlTypes;
using System.Globalization;
using System.Text;
using System.Threading.Channels;
namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập ngày tháng năm sinh (dd/MM/yyyy): ");
            string birth_raw = Console.ReadLine();

            DateTime birth = DateTime.ParseExact(birth_raw, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime today = DateTime.Today;
            TimeSpan khoang_thoi_gian_chenh_lech = (today - birth);
            double date = khoang_thoi_gian_chenh_lech.TotalDays;
            int tuoi = (int)date / 365;
            Console.WriteLine($"Tuổi hiện tại: {tuoi:F0} tuổi");
            Console.WriteLine("Bạn đã sống tổng cộng: " + date + " ngày");

            DateTime sinh_nhat_ke_tiep = new DateTime(today.Year, birth.Month, birth.Day);
           

            if (sinh_nhat_ke_tiep >= today)
            {
                TimeSpan duration = sinh_nhat_ke_tiep - today;
                double birth_ke_tiep = duration.TotalDays;
                Console.WriteLine("Sinh nhật tiếp theo còn: " + birth_ke_tiep);     
            }
            else 
            {
                DateTime sinh_nhat_ke_tiep1 = sinh_nhat_ke_tiep.AddYears(1);
                TimeSpan duration = sinh_nhat_ke_tiep1 - today;
                double birth_ke_tiep = duration.TotalDays;
                Console.WriteLine("Sinh nhật tiếp theo còn: " + birth_ke_tiep);
            }    

            Console.ReadKey();

        }

    }
}
