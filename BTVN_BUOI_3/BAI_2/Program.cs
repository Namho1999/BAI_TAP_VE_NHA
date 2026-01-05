namespace BAI_2
{
    internal class Program
    {
        // 1. Khai báo hằng số
        const double WH_TO_KWH = 1000.0;
        const double PRICE_PER_KWH = 2500.0;
        

        // 3. Hàm tính tiền điện
        public static double TinhTienDien(ref int whTieuThu)
        {
            // Ép kiểu và làm tròn từ Wh sang kWH
            int kwhLamTron = (int)Math.Round((double)whTieuThu / WH_TO_KWH);

            // Ghi đè chỉ số điện sau khi làm tròn
            whTieuThu = kwhLamTron;

            // Tổng số tiền điện phải trả
            double tongChiPhi = kwhLamTron * PRICE_PER_KWH;

            return tongChiPhi;
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 2. Dữ liệu đầu vào wh
            int whTieuThuHangThang = 208030;

            Console.WriteLine($"Chương Trình Tính Tiền Điện");
            Console.WriteLine($"Chỉ số điện tiêu thụ của tháng (wh): {whTieuThuHangThang}");

            // Gọi hàm tính tiền điện, truyền biến theo tham chiếu
            double tongHoaDon = TinhTienDien(ref whTieuThuHangThang);

            // Hiển thị kết quả
            Console.WriteLine($"Kết Quả");
            Console.WriteLine($"Lượng điện tiêu thụ sau khi quay đổi (kWh - số nguyên): {whTieuThuHangThang}");
            Console.WriteLine($"Tổng số tiền điện phải thanh toán: {tongHoaDon:N0} VNĐ");
        }
    }
}
