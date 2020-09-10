using System;

namespace tienlai
{
    class Program
    {
        static void tinh()
        {
           
            double money = 1.0;
            int month = 1;
            double intersetRate = 1.0;

           
            Console.WriteLine("Nhap vao tien cho vay: ");
            money = Double.Parse(Console.ReadLine());

           
            Console.WriteLine("Nhap vao so thang cho vay: ");
            month = Int32.Parse(Console.ReadLine());

           
            Console.WriteLine("Nhap vao ti le lai xuat: ");
            intersetRate = Double.Parse(Console.ReadLine());

          
            double totalInterset = 0;
            for (int i = 0; i < month; i++)
            {
                totalInterset = money * (intersetRate / 100) / 12 * 3;
            }
          
            Console.WriteLine("Total of interset: " + totalInterset);
        }
        static void Main(string[] args)
        {
            tinh();
        }
    }
}
