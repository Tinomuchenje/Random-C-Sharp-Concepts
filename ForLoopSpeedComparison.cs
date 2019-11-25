using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ForLoopSpeedComparison
{
	class Program
	{
		//Testing Speed of execution normal for Loop and ParallelFor Loop

		static void Main(string[] args)
		{			
			var executionTime = new Stopwatch();
			executionTime.Start();
			for (var i = 0; i < 100000000; i++)
			{
				//Console.WriteLine(i);
			}
			Console.WriteLine($"The execution time Normal for Loop'{ executionTime.Elapsed}'");
			executionTime.Stop();

			executionTime.Restart();
			Parallel.For(0, 100000000, (i) =>
			{
				//Console.WriteLine(i);
			});
			Console.WriteLine($"The execution time Parallel For Loop'{ executionTime.Elapsed}'");
			executionTime.Stop();

			Console.ReadKey();
		}
	}
}
