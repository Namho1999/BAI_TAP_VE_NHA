namespace BAI_1
{
    internal class Program
    {
        // Nhập vào và kiểm tra đã nhập đúng một số nguyên dương
        public static void SoNguyenDuong(out int soNguyenDuong)
        {
            Console.WriteLine("Nhập từ bàn phím số nguyên dương");
            Console.Write("Giá trị số nguyên dương là:");
            while (!int.TryParse(Console.ReadLine(), out soNguyenDuong) || soNguyenDuong <= 0)
            {
                Console.WriteLine("Nhập thông tin sai, vui lòng nhập lại");
            }    
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SoNguyenDuong(out int soNguyenDuong);
            Console.WriteLine("Tính tổng các số của một số nguyên dương");
            Console.WriteLine($"Số nguyên dương nhập vào là: {soNguyenDuong}");

            int tong = 0;
            int temp = soNguyenDuong;
            while (temp > 0)
            {
                tong += (temp % 10);
                temp /= 10;
            }

            Console.WriteLine($"Tổng các chữ số của số nguyên dương là: {tong}");
        }
    }
}
