using System;
using System.Collections.Generic;

namespace Boostability_Exercise
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Add routes to Home
			List<string> HomeRoutes = new List<string>();
			HomeRoutes.Add("/home");
			HomeRoutes.Add("/privacy");
			HomeRoutes.Add("/error");

			// Add routes to About
			List<string> AboutRoutes = new List<string>();
			HomeRoutes.Add("/about");
			HomeRoutes.Add("/members");
			HomeRoutes.Add("/sponsors");

			// Add routes to Event
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

			// Delegate route delimiter
			Console.WriteLine("\nEnter a route, separated by ' -> ':");
			
			// Get user input
			string inputRoute = Console.ReadLine();

			Console.WriteLine("\nSubmitted Route: ");

			// Display user input
			Console.WriteLine(inputRoute);

			// Split route based on delimiter
			string[] routes = inputRoute.Split(" -> ");

			Console.WriteLine("\nAll Routes:\n");

			// Display all routes as array
			foreach (var route in routes)
			{
				Console.WriteLine(route.Trim() + "\n");
			}
		}
	}
}
