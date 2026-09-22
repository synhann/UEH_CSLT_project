using System.Text;
using System.Text;

namespace GameDoanSo
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
                Console.WriteLine("     GAME ĐOÁN SỐ MAY MẮN        ");
                Console.WriteLine($"     Số dư hiện tại: {wallet:N0} VNĐ");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Dễ       (9 lần đoán | Cược x0.5)");
                Console.WriteLine("2. Trung bình (6 lần đoán | Cược x1.0)");
                Console.WriteLine("3. Khó      (4 lần đoán | Cược x3.0)");
                Console.WriteLine("0. Thoát game");
                Console.Write("Chọn độ khó (0-3): ");

                string levelChoice = Console.ReadLine();
                if (levelChoice == "0") break;

                int maxAttempts = 0;
                double multiplier = 0;

                switch (levelChoice)
                {
                    case "1":
                        maxAttempts = 9;
                        multiplier = 0.5;
                        break;
                    case "2":
                        maxAttempts = 6;
                        multiplier = 1.0;
                        break;
                    case "3":
                        maxAttempts = 4;
                        multiplier = 3.0;
                        break;
                    default:
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

                int targetNumber = random.Next(1, 101);
                bool guessedCorrectly = false;

                Console.WriteLine($"Máy tính đã chọn 1 số từ 1 đến 100. Bạn có {maxAttempts} lượt đoán!");

                for (int attempt = 1; attempt <= maxAttempts; attempt++)
                {
                    Console.Write($"Lần {attempt}/{maxAttempts} - Nhập số đoán: ");
                    if (!int.TryParse(Console.ReadLine(), out int guess))
                    {
                        Console.WriteLine("Vui lòng nhập số hợp lệ!");
                        attempt--;
                        continue;
                    }

                    if (guess == targetNumber)
                    {
                        guessedCorrectly = true;
                        Console.WriteLine($"CHÚC MỪNG! Bạn đoán đúng số {targetNumber} ở lượt thứ {attempt}!");
                        break;
                    }
                    else if (guess < targetNumber)
                    {
                        Console.WriteLine("-> Số máy tính LỚN HƠN!");
                    }
                    else
                    {
                        Console.WriteLine("-> Số máy tính NHỎ HƠN!");
                    }
                }

                if (guessedCorrectly)
                {
                    double winReward = bet * multiplier;
                    wallet += winReward;
                    Console.WriteLine($"Bạn thắng +{winReward:N0} VNĐ!");
                }
                else
                {
                    wallet -= bet;
                    Console.WriteLine($"Hết lượt! Số đúng là: {targetNumber}");
                    Console.WriteLine($"Bạn bị trừ -{bet:N0} VNĐ!");
                }

                if (wallet <= 0)
                {
                    Console.WriteLine("Bạn đã hết sạch tiền! Game Over.");
                    break;
                }

                Console.Write("Bạn có muốn chơi ván mới không? (Y/N): ");
                if (Console.ReadLine().Trim().ToUpper() != "Y") break;
            }

            Console.WriteLine("Cảm ơn bạn đã chơi Game Đoán số!");
            Console.ReadKey();
        }
    }
}