using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("لطفاً یک عدد وارد کنید: ");
            num = Convert.ToInt32(Console.ReadLine());

            // شرط: آیا عدد مضرب 7 است؟
            // (باقیمانده تقسیم آن بر 7 باید 0 باشد)
            if (num % 7 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                // در غیراینصورت، آن را در 3 ضرب کن
                int result = num * 3;
                Console.WriteLine("نتیجه: " + result);
            }
        }
    }
}
