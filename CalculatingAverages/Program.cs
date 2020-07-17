using System;
using System.Linq;
using System.Collections.Generic;

namespace CalculatingAverages
{
	class Program
	{
		static void Main()
		{
			int a;
			Console.WriteLine("For Sum of numbers please type 1.\nFor Average ten scores please type 2.\nFor Average a specific number of scores please type 3." +
				"\nFor Average a non-specific number of scores please type 4.");
			a = int.Parse(Console.ReadLine());

			if (a == 1)
			{
				SumOfNumbers();
				Console.ReadKey();
			}
			else if (a == 2)
			{
				AverageTenScores();
				Console.ReadKey();
			}
			else if (a == 3)
			{
				AvergageSpecific();
				Console.ReadKey();
			}
			else if (a == 4)
			{
				AvergageNonSpecific();
				Console.ReadKey();
			}

			Console.ReadKey();
		}
		static string SumOfNumbers()
		{
			int a, b, c, d, e, f, g, h, i, j;

			Console.WriteLine("Please enter the value of 1st Test Score:");
			a = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the value of 2nd Test Score:");
			b = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the value of 3rd Test Score:");
			c = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the value of 4th Test Score:");
			d = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the value of 5th Test Score:");
			e = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the value of 6th Test Score:");
			f = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the value of 7th Test Score:");
			g = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the value of 8th Test Score:");
			h = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the value of 9th Test Score:");
			i = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the value of 10th Test Score:");
			j = int.Parse(Console.ReadLine());

			Console.WriteLine($"Sum = {(a + b + c + d + e + f + g + h + i + j)}");
			return Console.ReadLine();
		}

		static string AverageTenScores() 
		{
			double a, b, c, d, e, f, g, h, i, j;

			Console.WriteLine("Please enter the value of 1st Test Score:");
			a = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the value of 2nd Test Score:");
			b = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the value of 3rd Test Score:");
			c = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the value of 4th Test Score:");
			d = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the value of 5th Test Score:");
			e = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the value of 6th Test Score:");
			f = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the value of 7th Test Score:");
			g = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the value of 8th Test Score:");
			h = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the value of 9th Test Score:");
			i = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the value of 10th Test Score:");
			j = double.Parse(Console.ReadLine());

			var arr = new double[] {a, b, c, d, e, f, g, h, i, j};
			double avg = Queryable.Average(arr.AsQueryable());

			if (avg == 100 || avg >= 90)
			{
				Console.WriteLine($"The Average score is: A ({avg})");
				Console.ReadKey();
			}
			else if (avg <= 89 || avg >= 80)
			{
				Console.WriteLine($"The Average score is: B ({avg})");
				Console.ReadKey();
			}
			else if (avg <= 79 || avg >= 70)
			{
				Console.WriteLine($"The Average score is: C ({avg})");
				Console.ReadKey();
			}
			else if (avg <= 69 || avg >= 60)
			{
				Console.WriteLine($"The Average score is: D ({avg})");
				Console.ReadKey(); ;
			}
			else if (avg <= 59)
			{
				Console.WriteLine($"The Average score is: F ({avg})");
				Console.ReadKey(); ;
			}

			return Console.ReadLine();
		}

		///Helped by Aaron Hevia
		static string AvergageSpecific() 
		{
			int NScore, avg, score;
			List<int> scoreList = new List<int>();

			//Ask for the amount of test scores you're going to enter
			Console.WriteLine("Please enter the amount of test scores you're going to enter: ");
			NScore = int.Parse(Console.ReadLine());

			for (int i = 0; i < NScore; i++)
			{
				Console.WriteLine("Please enter the value of your Test Score:");
				score = int.Parse(Console.ReadLine());
				scoreList.Add(score);
			} 

			avg = (int)scoreList.Average();


			if (avg == 100 || avg >= 90)
			{
				Console.WriteLine($"The Average score is: A ({avg})");
				Console.ReadKey();
			}
			else if (avg <= 89 || avg >= 80)
			{
				Console.WriteLine($"The Average score is: B ({avg})");
				Console.ReadKey();
			}
			else if (avg <= 79 || avg >= 70)
			{
				Console.WriteLine($"The Average score is: C ({avg})");
				Console.ReadKey();
			}
			else if (avg <= 69 || avg >= 60)
			{
				Console.WriteLine($"The Average score is: D ({avg})");
				Console.ReadKey(); ;
			}
			else if (avg <= 59)
			{
				Console.WriteLine($"The Average score is: F ({avg})");
				Console.ReadKey(); ;
			}

			return Console.ReadLine();
		}
		static string AvergageNonSpecific()
		{
			int avg, score;
			List<int> scoreList = new List<int>();

			while (true)
			{
				Console.WriteLine("Please enter your Test Score or type '0000' to calculate the grade average: ");
				score = int.Parse(Console.ReadLine());

				if (score == 0000)
				{
					break;
				}

				scoreList.Add(score);
			}

			avg = (int)scoreList.Average();


			if (avg == 100 || avg >= 90)
			{
				Console.WriteLine($"The Average score is: A ({avg})");
				Console.ReadKey();
			}
			else if (avg <= 89 || avg >= 80)
			{
				Console.WriteLine($"The Average score is: B ({avg})");
				Console.ReadKey();
			}
			else if (avg <= 79 || avg >= 70)
			{
				Console.WriteLine($"The Average score is: C ({avg})");
				Console.ReadKey();
			}
			else if (avg <= 69 || avg >= 60)
			{
				Console.WriteLine($"The Average score is: D ({avg})");
				Console.ReadKey(); ;
			}
			else if (avg <= 59)
			{
				Console.WriteLine($"The Average score is: F ({avg})");
				Console.ReadKey(); ;
			}

			return Console.ReadLine();
		}
	}
}
