using System;
using System.Text;

namespace bai10
{
    public enum StockStatus
    {
        OutOfStock,
        LowStock,
        InStock,
        Discontinued
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Mã sản phẩm: ");
            string productCode = Console.ReadLine();

            Console.Write("Tên sản phẩm: ");
            string productName = Console.ReadLine();

            Console.Write("Số lượng tồn kho (để trống nếu chưa biết): ");
            string qtyInput = Console.ReadLine();
            int? quantity = string.IsNullOrWhiteSpace(qtyInput) ? (int?)null : int.Parse(qtyInput);

            Console.Write("Ngưỡng tối thiểu (mặc định 10): ");
            string thresholdInput = Console.ReadLine();
            int minThreshold = string.IsNullOrWhiteSpace(thresholdInput) ? 10 : int.Parse(thresholdInput);

            Console.Write("Ngày nhập hàng tiếp theo (dd/MM/yyyy, để trống nếu chưa có): ");
            string dateInput = Console.ReadLine();
            DateTime? restockDate = string.IsNullOrWhiteSpace(dateInput)
                                    ? (DateTime?)null
                                    : DateTime.ParseExact(dateInput, "dd/MM/yyyy", null);

            int displayQuantity = quantity ?? 0;
            Console.Write($"Số lượng hiển thị: {displayQuantity}");
            if (quantity == null)
                Console.WriteLine(" (Cảnh báo: Dữ liệu trống)");
            else
                Console.WriteLine();

            StockStatus status;
            if (quantity == null || quantity == 0)
                status = StockStatus.OutOfStock;
            else if (quantity < minThreshold)
                status = StockStatus.LowStock;
            else
                status = StockStatus.InStock;

            string statusDisplay = status switch
            {
                StockStatus.OutOfStock => "OutOfStock (Hết hàng)",
                StockStatus.LowStock => "LowStock (Sắp hết)",
                StockStatus.InStock => "InStock (Còn hàng)",
                _ => "Discontinued (Ngừng bán)"
            };
            Console.WriteLine($"Trạng thái kho: {statusDisplay}");

            string restockDisplay = restockDate?.ToString("dd/MM/yyyy") ?? "Chưa có lịch nhập hàng";
            Console.WriteLine($"Dự kiến nhập hàng: {restockDisplay}");

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}