namespace Bien_va_kieu_du_lieu_Bai_4
{
    internal class Bai_4
    {
        static void Main(string[] args)
        {
            double a1 = 246.489;
            object box_a1 = a1; // Boxing
            double unbox_a1 = (double)a1; // Unboxing

            Console.WriteLine(a1);
            Console.WriteLine(box_a1);
            Console.WriteLine(unbox_a1);
        }
    }
}
