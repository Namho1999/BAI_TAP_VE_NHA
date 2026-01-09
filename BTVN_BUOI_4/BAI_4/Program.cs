namespace BAI_4
{
    internal class Program
    {
        public static void TinhGiaithua(out int n)
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

            TinhGiaithua(out int n);

            int temp = n;
            long giaiThua = 1;

            while (temp > 0)
            {
                giaiThua *= temp;
                temp -= 1;
            }
            Console.WriteLine($"Giai thừa của {n} là: {giaiThua:N0} ");
        }
    }
}
