namespace BAI_3
{
    internal class Program
    {
        // 1. Khai báo hằng số 
        const double MIN_PER_HOUR = 60.0;
        const double SALARY_PER_HOUR = 45000.0;

        // 2. Khai báo tổng số phút làm việc, nhập từ bàn phím
        public static void SoPhutLamViec(out int soPhut)
        {
            Console.WriteLine("Nhập thông tin làm việc của nhân viên:");
            Console.Write("Tổng số phút làm việc: ");
            while (!int.TryParse(Console.ReadLine(), out soPhut) || soPhut < 0)
            {
                Console.WriteLine("Nhập sai thông tin, vui lòng nhập lại số phút làm việc.");
            }
        }

        // 3. Hàm tính toán
        public static double TinhTienLuong(ref int thoiGianLamViec)
        {
            // Quy đổi phút sang giờ
            double soGioLamViec = (double)(thoiGianLamViec / MIN_PER_HOUR);

            // Ghi đè và làm tròn số phút sang giờ làm
            thoiGianLamViec = (int)Math.Round(soGioLamViec);

            // Tính tiền lương
            double tienLuong = soGioLamViec * SALARY_PER_HOUR;

            return tienLuong;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int tongThoiGian;

            // Nhập thời gian làm việc
            SoPhutLamViec(out tongThoiGian);
            Console.WriteLine($"Thông tin chấm công sau khi nhập");
            Console.WriteLine($"Thời gian làm việc: {tongThoiGian} phút");

            // Quy đổi, ghi đè và làm tròn phút sang giờ, tính tiền lương
            double tongTienLuong = TinhTienLuong(ref tongThoiGian);
            Console.WriteLine($"Hiển thị kết quả");
            Console.WriteLine($"Tổng thời gian làm việc sau khi quay đổi (phút -> giờ): {tongThoiGian} giờ");
            Console.WriteLine($"Tổng tiền lương: {tongTienLuong:N0} VNĐ");


        }
    }
}
