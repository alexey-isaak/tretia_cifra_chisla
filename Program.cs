using System;
 
namespace tretia_cifra
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число: ");
            int chislo = Convert.ToInt32(Console.ReadLine());
            string chislo_string = Convert.ToString(chislo);
            int chislo_l = Convert.ToInt32(chislo_string.Length);
            if (chislo_l < 3)
            {
                Console.WriteLine("В этом числе меньше трех знаков");
            }
            else
            {
                Console.WriteLine("Третья цифра этого числа: " + chislo_string[2]);
            }
        }
    }
}
