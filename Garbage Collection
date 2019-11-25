using System;

namespace UsingIDisposable
{
	class CrucialConnection : IDisposable
	{
		public void Dispose()
		{
			Console.WriteLine("Dispose called");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			using (CrucialConnection c = new CrucialConnection())
			{
				// do something with the crucial connection
				Console.WriteLine("Doing something");
			}
			Console.ReadKey();
		}
	}
}
