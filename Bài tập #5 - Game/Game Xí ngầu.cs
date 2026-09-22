using System;
using System.Text;

namespace GameXiNgau
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double wallet = 1000; // Số tiền khởi tạo

            while (wallet > 0)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("   GAME XÍ NGẦU (TÀI XỈU)");
                Console.WriteLine($"   Số dư hiện tại: {wallet:N0} VNĐ");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Đặt cược & Gieo xí ngầu");
                Console.WriteLine("0. Thoát game");
                Console.Write("Chọn chức năng: ");

                string choice = Console.ReadLine();
                if (choice == "0") break;

                if (choice != "1")
                {
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    Console.ReadKey();
                    continue;
                }

                // Nhập tiền cược
                double bet = 0;
                while (true)
                {
                    Console.Write($"Nhập số tiền cược (1 - {wallet:N0}): ");
                    if (double.TryParse(Console.ReadLine(), out bet) && bet > 0 && bet <= wallet)
                        break;
                    Console.WriteLine("Số tiền cược không hợp lệ!");
                }

                Console.WriteLine("\nChọn cửa đặt:");
                Console.WriteLine("1. Xỉu (Tổng 3 - 10)");
                Console.WriteLine("2. Tài (Tổng 11 - 18)");
                Console.Write("Lựa chọn (1/2): ");
                string betType = Console.ReadLine();

                int d1 = random.Next(1, 7);
                int d2 = random.Next(1, 7);
                int d3 = random.Next(1, 7);
                int total = d1 + d2 + d3;

                Console.WriteLine($"\nKết quả gieo: {d1} - {d2} - {d3} => Tổng: {total}");
                string result = (total >= 11) ? "Tài" : "Xỉu";
                Console.WriteLine($"Kết quả: {result}");

                bool isWin = (betType == "1" && total <= 10) || (betType == "2" && total >= 11);

                if (isWin)
                {
                    Console.WriteLine($"Chúc mừng! Bạn đã thắng +{bet:N0} VNĐ");
                    wallet += bet;
                }
                else
                {
                    Console.WriteLine($"Rất tiếc! Bạn đã thua -{bet:N0} VNĐ");
                    wallet -= bet;
                }

                if (wallet <= 0)
                {
                    Console.WriteLine("Bạn đã hết sạch tiền! Game Over.");
                    break;
                }

                Console.Write("Bạn có muốn tiếp tục chơi không? (Y/N): ");
                if (Console.ReadLine().Trim().ToUpper() != "Y") break;
            }

            Console.WriteLine("Cảm ơn bạn đã chơi game Xí ngầu!");
            Console.ReadKey();
        }
    }
}