using System.Reflection.Metadata.Ecma335;

namespace BAI_1
{
    internal class Program
    {
        // 1.Khai báo hằng số thuế VAT = 10%
        public const double VAT = 0.10;

        // 2.Hàm nhập đơn giá và số lượng
        
        public static void NhapDonGiaVaSoLuong(out double donGia, out int soLuong)
        {
            Console.WriteLine("Nhập thông tin đơn hàng");
            Console.Write("Nhập đơn giá: ");
            while (!double.TryParse(Console.ReadLine(), out donGia) || donGia < 0)
            {
                Console.WriteLine("Nhập sai. Vui lòng nhập lại đơn giá: ");
            }

            Console.Write("Nhập số lượng: ");
            while (!int.TryParse(Console.ReadLine(), out soLuong) || soLuong < 0)
            {
                Console.WriteLine("Nhập sai. Vui lòng nhập lại số lượng");
            }
        }
        
        // 3. Hàm tính toán
        public static void TinhToan(double donGia, int soLuong, out double thanhTien, out double thueVAT, out double tongTienThanhToan)
        {
            thanhTien = donGia * soLuong;
            thueVAT = thanhTien * VAT;
            tongTienThanhToan = thanhTien + thueVAT;
        }

        // 4. Tăng số lượng lên 1 (tham chiếu ref)
        public static void TangSoLuong(ref int soLuong)
        {
            soLuong++;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double donGia;
            int soLuong;
            double thanhTien;
            double thueVAT;
            double tongTienThanhToan;

            // Nhập đơn giá và số lượng
            NhapDonGiaVaSoLuong(out donGia, out soLuong);
            Console.WriteLine($"\nThông tin sau khi nhập");
            Console.WriteLine($"Đơn giá: {donGia:N0} VNĐ");
            Console.WriteLine($"Số lượng ban đầu : {soLuong}");

            // Tính toán và in ra kết quả
            TinhToan(donGia, soLuong, out thanhTien, out thueVAT, out tongTienThanhToan);
            Console.WriteLine("\n Kết quả tính toán");
            Console.WriteLine($"Thành tiền (chưa thuế): {thanhTien:N0} VNĐ");
            Console.WriteLine($"Thuế VAT: {thueVAT:C}");
            Console.WriteLine($"Tổng tiền thanh toán: {tongTienThanhToan:N0} VNĐ");

            // Tăng số lượng lên 1
            TangSoLuong(ref soLuong);
            Console.WriteLine($"Số lượng sau khi tăng thêm 1: {soLuong}");

            // Ép kiểu dữ liệu tổng tiền sang Int
            int tongTienThanhToanInt = (int)tongTienThanhToan;
            Console.WriteLine($"Tổng tiền thanh toán (int) : {tongTienThanhToanInt:N0} VNĐ");

        }
    }
}
