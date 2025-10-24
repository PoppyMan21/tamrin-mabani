using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("لطفاً یک عدد وارد کنید: ");
            num = Convert.ToInt32(Console.ReadLine());

            // شرط: هم کوچکتر از 10 باشد (num < 10)
            //      و هم زوج باشد (num % 2 == 0)
            if (num < 10 && num % 2 == 0)
            {
                Console.WriteLine("TRUE");
            }
        }
    }
}
