using System;
using System.Text.RegularExpressions;

namespace lab11
{
    class Program
    {
		static void Main(string[] args)
		{
			string s = "У меня 10 долларов, 3 яблока, 5 апельсинов.";
			Console.WriteLine(s);
			Console.WriteLine("После каждой запятой в тексте поставить в квадратных скобках её порядковый номер.");
			Console.WriteLine("-----------------------");
			Regex r = new Regex(@"\,");
			string so;

			//поиск того, что соответствует шаблону:
			MatchCollection mc = r.Matches(s);
			string[] sc = r.Split(s);
			int i = 1;
			foreach (Match m in mc)
			{
				if(i <= 1)
					Console.Write(sc[0]);
				if (i > sc.Length - 1)
					break;
				Console.Write($",[{i}]" + sc[i]);
				i++;
			}
			Console.WriteLine();
			Console.WriteLine("-----------------------");
			//замена текста:
			MatchEvaluator ma = new MatchEvaluator(myReplace);
			so = r.Replace(s, ma);
			Console.WriteLine(so);

		}

		static string myReplace(Match m)
		{
			return m.ToString();
		}

	}
}
