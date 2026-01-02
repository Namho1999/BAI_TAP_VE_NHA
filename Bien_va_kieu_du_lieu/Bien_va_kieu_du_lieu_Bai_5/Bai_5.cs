namespace Bien_va_kieu_du_lieu_Bai_5
{
    internal class Bai_5
    {
        static void Main(string[] args)
        {
            float x1 = 14593.3567f;
            float x2 = 263.14678f;

            float y1 = x1 / x2;
            double y2 = x1 / x2;

            decimal x11 = 14593.3567m;
            decimal x22 = 263.14678m;

            decimal y3 = x11 / x22;

            Console.WriteLine("Do chinh xac phep tinh float: "+ y1);
            Console.WriteLine("Do chinh xac phep tinh double: "+ y2);
            Console.WriteLine("Do chinh xac phep tinh decimal: "+ y3);
        }
    }
}
