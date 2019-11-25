using System;
using System.Reflection;

namespace ObjectReflection
{
	class Person
	{
		public string Name { get; set; }
	}
	class Program
	{
		static void Main(string[] args)
		{		
			var p = new Person();
			var type = p.GetType();
			foreach (var member in type.GetMembers())
			{
				Console.WriteLine(member.ToString());
			}
			Console.ReadKey();
		}
	}
}
