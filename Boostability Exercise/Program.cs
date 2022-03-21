using System;
using System.Collections.Generic;

namespace Boostability_Exercise
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] routes =
			{
				"/home",
				"/privacy -> /about -> /members",
				"/members -> /about",
				"/events -> /guestlist -> /home",
				"/about -> /members",
				"/members -> /about"
			};

			foreach (var route in routes)
			{
				string[] splitRoute = route.Split(" -> ");
				foreach (var split in splitRoute)
				{
					Console.WriteLine(split);
				}
				Console.WriteLine("\n");
			}
		}
	}
}
