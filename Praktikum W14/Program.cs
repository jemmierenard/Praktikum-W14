using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum_W14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input : ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Output : ");
			int jumlah = 0;
			for (int i = 1; i <= input; i++)
			{
				int sisa = input % i;
				if (sisa == 0)
				{
					jumlah = jumlah + 1;
				}
			}

			if (jumlah > 2)
			{
				Console.WriteLine("Bukan angka prima");
			}
			else
			{
				Console.WriteLine("Angka prima");
			}
		}
    }
}
