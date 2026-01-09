namespace BAI_3
{
    internal class Program
    {
        public static void ChieuCaoTamGiac(out int h)
        {
            Console.WriteLine("Nhập từ bàn phím số nguyên dương");
            Console.Write("Giá trị số nguyên dương là:");
            while (!int.TryParse(Console.ReadLine(), out h) || h <= 0)
            {
                Console.WriteLine("Nhập thông tin sai, vui lòng nhập lại");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ChieuCaoTamGiac(out int h);
            Console.WriteLine("Nhập chiều cao tam giác cân ký tự * muốn hiển thị");
            Console.WriteLine($"Chiều cao của tam giác cân là: {h}\n");

            for (int a = 1; a <= h; a++)
            {
                for (int b = 1; b <= (h - a) * 2; b++)  // Tạo khoảng trắng căn * vào giữa mỗi hàng
                {                                       // Sau dấu sao có thêm 1 dấu " " nên 
                    Console.Write(" ");
                }    

                for (int c = 1; c <= (2 * a - 1); c++)  // Số dấu sao mỗi hàng, hàng thứ 2 số * bằng hàng trên + 2
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }    
        }
    }
}
