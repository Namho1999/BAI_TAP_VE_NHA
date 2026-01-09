namespace BAI_2
{
    internal class Program
    {
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
            Console.WriteLine("Đảo ngược số nguyên dương");
            Console.WriteLine($"Số nguyên dương nhập vào là: {soNguyenDuong}");

            int temp = soNguyenDuong;
            int daoNguoc = 0;

            while (temp > 0)
            {
                int soCuoi = temp % 10;
                daoNguoc = daoNguoc * 10 + soCuoi;
                temp /= 10;
            }

            Console.WriteLine($"Số nguyên dương được đảo ngược là: {daoNguoc}");
        }
    }
}
