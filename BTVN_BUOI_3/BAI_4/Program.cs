namespace BAI_4
{
    internal class Program
    {
        // Khai báo hằng số VAT
        const double VAT = 0.10;

        // Nhập giá dữ liệu đầu vào sản phảm chưa có VAT
        public static void GiaGocSanPham(out double giaGoc)
        {
            Console.WriteLine("Nhập giá gốc đầu vào của sản phẩm");
            Console.Write("Giá sản phẩm chưa tính VAT: ");
            while(!double.TryParse(Console.ReadLine(), out giaGoc) || giaGoc < 0)
            {
                Console.WriteLine("Nhập thông tin sai, vui lòng nhập lại giá sản phẩm");
            }    
        }

        // Hàm xử lý tính toán
        public static double GiaSanPhamSauThue(ref double giaGoc)
        {
            double thueVAT = giaGoc * VAT;
            double giaSauthue = giaGoc + thueVAT;

            // Ghi đè giá sau thuế đã được làm tròn xuống kiểu int
            giaGoc = (int)Math.Round(giaSauthue);

            return giaSauthue;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double giaChuaVAT;

            // Nhập giá gốc sản phẩm chưa gồm VAT
            GiaGocSanPham(out giaChuaVAT);
            Console.WriteLine($"Tính giá sản phẩm sau khi áp dụng thuế VAT");
            Console.WriteLine($"Giá sản phẩm: {giaChuaVAT} VNĐ");


            double giaSauThue = GiaSanPhamSauThue(ref giaChuaVAT);
            Console.WriteLine($"Giá sản phẩm sau thuế là: {giaSauThue} VNĐ");
            Console.WriteLine($"Giá sản phẩm sau thuế đã làm tròn là (int): {giaChuaVAT:N0} VNĐ");
        }
    }
}
