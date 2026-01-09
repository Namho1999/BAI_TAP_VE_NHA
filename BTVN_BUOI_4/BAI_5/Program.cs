namespace BAI_5
{
    internal class Program
    {
        public static void KiemTraSoDoiXung(out int n)
        {
            Console.WriteLine("Nhập từ bàn phím số nguyên dương");
            Console.Write("Giá trị số nguyên dương là:");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Nhập thông tin sai, vui lòng nhập lại");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            KiemTraSoDoiXung(out int n);

            int soGoc = n;
            int soDaoNguoc = 0;

            while ( n > 0)
            {
                int temp = n % 10; // Lấy số hàng đơn vị
                soDaoNguoc = soDaoNguoc * 10 + temp; // Số đảo ngược từ số gốc
                n /= 10;
            }

                if (soDaoNguoc == soGoc)
                {
                    Console.WriteLine("Số nhập vào chính là số Palindrome (đối xứng)");
                }
                else
                {
                    Console.WriteLine("Số nhập vào không phải là số Palindrome (đối xứng)");
                }
        }
    }
}
