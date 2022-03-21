using System;
using System.Collections.Generic;

namespace Boostability_Exercise
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> HomeRoutes = new List<string>();
			HomeRoutes.Add("/home");
			HomeRoutes.Add("/privacy");
			HomeRoutes.Add("/error");

			List<string> AboutRoutes = new List<string>();
			HomeRoutes.Add("/about");
			HomeRoutes.Add("/members");
			HomeRoutes.Add("/sponsors");

			List<string> EventRoutes = new List<string>();
			HomeRoutes.Add("/events");
			HomeRoutes.Add("/guestlist");

			foreach (var route in HomeRoutes)
			{
				Console.WriteLine(route);
			}

			foreach (var route in AboutRoutes)
			{
				Console.WriteLine(route);
			}

			foreach (var route in EventRoutes)
			{
				Console.WriteLine(route);
			}

		}
	}
}
