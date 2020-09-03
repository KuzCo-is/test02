using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		public static int search(int[] arr, int x)
		{
			int n = arr.Length;
			for (int i = 0; i < n; i++)
			{
				if (arr[i] == x)
					return i;
			}
			return -1;
		}

		public static void Main()
		{
			int[] arr = { 9, 1, 6, 2, 4, 10, 8, 7, 5, 3};
			int x = 4;

			int result = search(arr, x);
			if (result == -1)
				Console.WriteLine("ไม่พบข้อมูล");
			else
				Console.WriteLine("Round :" + result);
		}
	}
}