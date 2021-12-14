using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum_W14
{
    internal class Program
    {
		public static void Prima(int input)
        {
			int jumlah = 0;
			int apaPrima = 0;
			int angkaMaju = 0;
			for (int i = 0; i <= input; i++)
			{
				for (int j = 0; j <= input; j++)
				{
					apaPrima = 0;
					while (apaPrima == 0)
					{
						angkaMaju++;
						jumlah = 0;
						for (int k = 1; k <= angkaMaju; k++)
						{
							if (angkaMaju % k == 0)
							{
								jumlah++;
							}
						}
						if (jumlah == 2)
						{
							apaPrima = 1;
						}
						else
						{
							apaPrima = 0;
						}
					}
					Console.Write(String.Format("{0,5}", angkaMaju));
				}
				Console.WriteLine();
			}
		}
		public static void BukanPrima(int input)
        {
			int jumlah = 0;
			int apaPrima = 0;
			int angkaMaju = 0;
			for (int i = 1; i <= input; i++)
			{
				for (int j = 1; j <= input; j++)
				{
					apaPrima = 0;
					while (apaPrima == 0)
					{
						angkaMaju++;
						jumlah = 0;
						for (int k = 1; k <= angkaMaju; k++)
						{
							if (angkaMaju % k == 0)
							{
								jumlah++;
							}
						}
						if (jumlah == 2)
						{
							apaPrima = 0;
						}
						else
						{
							apaPrima = 1;
						}
					}
                    Console.Write(String.Format("{0,5}",angkaMaju));
				}
				Console.WriteLine();
			}
		}
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
				BukanPrima(input);
			}
			else
			{
				Prima(input);
			}
		}
    }
}
