using System;
using System.Data.SqlTypes;
using System.Text;
namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

                // Demo thử nghiệm các hàm
                Console.WriteLine("--- PHẦN 1: BÀI TẬP CÓ HƯỚNG DẪN ---");
                Console.WriteLine($"Bài 1 - TinhTong(5, 10): {TinhTong(5, 10)}");
                Console.WriteLine($"Bài 2 - KiemTraChan(4): {KiemTraChan(4)}");
                Console.WriteLine($"Bài 3 - TimMax(3, 9, 5): {TimMax(3, 9, 5)}");
                Console.WriteLine($"Bài 4 - TinhGiaiThua(5): {TinhGiaiThua(5)}");
                Console.WriteLine($"Bài 5 - DaoNguocChuoi(\"hello\"): {DaoNguocChuoi("hello")}");

                Console.WriteLine("\n--- PHẦN 2: BÀI TẬP THAM CHIẾU ---");
                Console.WriteLine($"Bài 6 - KiemTraNguyenTo(7): {KiemTraNguyenTo(7)} | KiemTraNguyenTo(10): {KiemTraNguyenTo(10)}");

                Console.Write("Bài 7 - InFibonacci(6): ");
                InFibonacci(6);

                Console.WriteLine($"Bài 8 - DemNguyenAm(\"Hello World\"): {DemNguyenAm("Hello World")}");
                Console.WriteLine($"Bài 9 - TinhLuyThua(2, 3): {TinhLuyThua(2, 3)}");
                Console.WriteLine($"Bài 10 - TinhTrungBinh([4, 5, 6, 7]): {TinhTrungBinh(new int[] { 4, 5, 6, 7 })}");
                Console.WriteLine($"Bài 11 - KiemTraDoiXung(\"radar\"): {KiemTraDoiXung("radar")}");
                Console.WriteLine($"Bài 12 - CelsiusToFahrenheit(25): {CelsiusToFahrenheit(25)}");
                Console.WriteLine($"Bài 13 - TimMin([10, 5, 8, 2, 9]): {TimMin(new int[] { 10, 5, 8, 2, 9 })}");
                Console.WriteLine($"Bài 14 - TongCacChuSo(1234): {TongCacChuSo(1234)}");

                Console.Write("Bài 15 - SapXepMang([3, 1, 4, 2]): ");
                SapXepMang(new int[] { 3, 1, 4, 2 });

                Console.WriteLine($"Bài 16 - XoaTrungLap(\"programming\"): {XoaTrungLap("programming")}");
                Console.WriteLine($"Bài 17 - UCLN(12, 18): {UCLN(12, 18)}");
                Console.WriteLine($"Bài 18 - DecimalToBinary(10): {DecimalToBinary(10)}");
                Console.WriteLine($"Bài 19 - KiemTraNamNhuan(2024): {KiemTraNamNhuan(2024)}");
                Console.WriteLine($"Bài 20 - DemSoTu(\"Học lập trình C# rất thú vị\"): {DemSoTu("Học lập trình C# rất thú vị")}");
        }

            #region Phần 1: Bài tập có hướng dẫn (Bài 1 - Bài 5)

            // Bài 1: Tính tổng hai số nguyên
            public static int TinhTong(int a, int b)
            {
                return a + b;
            }

            // Bài 2: Kiểm tra số chẵn lẻ
            public static bool KiemTraChan(int n)
            {
                return n % 2 == 0;
            }

            // Bài 3: Tìm số lớn nhất trong ba số
            public static int TimMax(int a, int b, int c)
            {
                return Math.Max(Math.Max(a, b), c);
            }

            // Bài 4: Tính giai thừa của một số
            public static long TinhGiaiThua(int n)
            {
                long result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }

            // Bài 5: Đảo ngược chuỗi ký tự
            public static string DaoNguocChuoi(string input)
            {
                if (string.IsNullOrEmpty(input)) return input;
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }

            #endregion

            #region Phần 2: Bài tập có kết quả mẫu (Bài 6 - Bài 20)

            // Bài 6: Kiểm tra số nguyên tố
            public static bool KiemTraNguyenTo(int n)
            {
                if (n < 2) return false;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }

            // Bài 7: In dãy Fibonacci (N số đầu tiên)
            public static void InFibonacci(int n)
            {
                if (n <= 0) return;
                int a = 0, b = 1;
                for (int i = 0; i < n; i++)
                {
                    Console.Write(a + (i == n - 1 ? "" : " "));
                    int temp = a + b;
                    a = b;
                    b = temp;
                }
                Console.WriteLine();
            }

            // Bài 8: Đếm số lượng nguyên âm trong chuỗi
            public static int DemNguyenAm(string s)
            {
                int count = 0;
                string vowels = "aeiouAEIOU";
                foreach (char c in s)
                {
                    if (vowels.Contains(c)) count++;
                }
                return count;
            }

            // Bài 9: Tính lũy thừa x^y (Không dùng Math.Pow)
            public static double TinhLuyThua(double x, int y)
            {
                double result = 1.0;
                int exponent = Math.Abs(y);

                for (int i = 0; i < exponent; i++)
                {
                    result *= x;
                }

                return y < 0 ? 1.0 / result : result;
            }

            // Bài 10: Tính điểm trung bình của mảng
            public static double TinhTrungBinh(int[] arr)
            {
                if (arr == null || arr.Length == 0) return 0;
                double sum = 0;
                foreach (int num in arr)
                {
                    sum += num;
                }
                return sum / arr.Length;
            }

            // Bài 11: Kiểm tra chuỗi đối xứng (Palindrome)
            public static bool KiemTraDoiXung(string s)
            {
                if (string.IsNullOrEmpty(s)) return true;
                int left = 0;
                int right = s.Length - 1;

                while (left < right)
                {
                    if (char.ToLower(s[left]) != char.ToLower(s[right]))
                        return false;
                    left++;
                    right--;
                }
                return true;
            }

            // Bài 12: Chuyển đổi nhiệt độ (°C sang °F)
            public static double CelsiusToFahrenheit(double c)
            {
                return (c * 9 / 5) + 32;
            }

            // Bài 13: Tìm giá trị nhỏ nhất trong mảng
            public static int TimMin(int[] arr)
            {
                if (arr == null || arr.Length == 0)
                    throw new ArgumentException("Mảng không được rỗng.");

                int min = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min) min = arr[i];
                }
                return min;
            }

            // Bài 14: Tính tổng các chữ số của một số nguyên
            public static int TongCacChuSo(int n)
            {
                n = Math.Abs(n);
                int sum = 0;
                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                return sum;
            }

            // Bài 15: Sắp xếp mảng tăng dần
            public static void SapXepMang(int[] arr)
            {
                if (arr == null) return;

                // Tạo bản sao để không làm thay đổi mảng gốc (hoặc dùng Array.Sort trực tiếp)
                int[] sortedArr = (int[])arr.Clone();
                Array.Sort(sortedArr);

                Console.WriteLine(string.Join(" ", sortedArr));
            }

            // Bài 16: Xóa ký tự trùng lặp
            public static string XoaTrungLap(string s)
            {
                if (string.IsNullOrEmpty(s)) return s;

                string result = "";
                foreach (char c in s)
                {
                    if (!result.Contains(c))
                    {
                        result += c;
                    }
                }
                return result;
            }

            // Bài 17: Tìm ước chung lớn nhất (UCLN) bằng thuật toán Euclid
            public static int UCLN(int a, int b)
            {
                a = Math.Abs(a);
                b = Math.Abs(b);
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }

            // Bài 18: Chuyển đổi hệ thập phân sang nhị phân
            public static string DecimalToBinary(int n)
            {
                if (n == 0) return "0";
                return Convert.ToString(n, 2);
            }

            // Bài 19: Kiểm tra năm nhuận
            public static bool KiemTraNamNhuan(int year)
            {
                return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            }

            // Bài 20: Đếm số từ trong câu
            public static int DemSoTu(string sentence)
            {
                if (string.IsNullOrWhiteSpace(sentence)) return 0;

                // Tách câu bằng các khoảng trắng
                string[] words = sentence.Trim().Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                return words.Length;
            }
        #endregion
    }

}