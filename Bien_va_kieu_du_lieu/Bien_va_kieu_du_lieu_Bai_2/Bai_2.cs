namespace Bien_va_kieu_du_lieu_Bai_2
{
    internal class Bai_2
    {
        static void Main(string[] args)
        {
            sbyte sb = 126;
            Console.WriteLine("overflow with sbyte: "+ sb);
            sb++;
            Console.WriteLine("overflow with sbyte: " + sb);
            sb++;
            Console.WriteLine("overflow with sbyte: " + sb);
            sb++;
            Console.WriteLine("overflow with sbyte: " + sb);

            byte b = 0;
            Console.WriteLine("overflow with byte: "+ b);
            b--;
            Console.WriteLine("overflow with byte: " + b);
            b--;
            Console.WriteLine("overflow with byte: " + b);

        }
    }
}
