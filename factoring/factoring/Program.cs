using System;
using System.Collections.Generic;
using System.IO;

namespace factoring
{
	
	class Factor
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("input a file path: ");
			String file = Console.ReadLine ();
			if(!File.Exists (file)){
				while (!File.Exists (file)) {
					Console.WriteLine ("File Not Found. Input a file path: ");
					file = Console.ReadLine ();
				
				}
			}
			List<int> fileIntegers = new List<int>();
			string line;
			using (TextReader reader = File.OpenText (file)) {
				while((line = reader.ReadLine()) != null)
					fileIntegers.Add(int.Parse(line));
			}

			foreach (int item  in fileIntegers)
			{
				printPrimeFactors(item);
			}


		}

		private static void printPrimeFactors(int n)
		{
			Console.Write (n + ": ");
			List<int> factorList = new List<int>();
			int fac = 2;
			while (fac * fac <= n)
			{
				if (n % fac == 0){
					factorList.Add(fac);
					n /= fac;
				}else{
					fac += (fac == 2) ?  1 : 2;
				}
			}
			if (n > 1) 
				factorList.Add(n);
			foreach(int x  in factorList)
			{
				Console.Write("{0}, ", x);
			}
			Console.Write ("\n");
			return;
		}
	}
}
