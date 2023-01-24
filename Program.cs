using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._18._1_Cevrimler3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //iç içe döngülerde dıştaki döngü içteki döngüye çarpan etkisi görür.
            for (int i = 0; i < n; i++)//0dan başlayıp n'e gider
            {
                for (int j = 0; j <= i; j++)//küçük n olana kadar dönsün
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
