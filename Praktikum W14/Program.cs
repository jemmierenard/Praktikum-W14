using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum_W14
{
    internal class Program
    {
		public static void Prima(int input, int jumlah)
        {
			for (int i = 1; i <= input; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					if (i % j == 0)
					{
						jumlah++;
					}
				}
				if (jumlah == 2)
				{
					Console.Write(i + " ");
				}
				jumlah = 0;
			
			}
		}
		public static void bukanPrima(int input, int jumlah)
        {
			for (int i = 1; i <= input; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					if (i % j == 0)
					{
						jumlah++;
					}
				}
				if (jumlah != 2)
				{
					Console.Write(i + " ");
				}
				jumlah = 0;
			}
		}
        static void Main(string[] args)
        {
            Console.Write("Input : ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Output : ");
			int jumlah = 0;
			int[,] bilangan = new int[input, input];
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
				bukanPrima(input, jumlah);
			}
			else
			{
				Prima(input, jumlah);
			}
		}
    }
}
