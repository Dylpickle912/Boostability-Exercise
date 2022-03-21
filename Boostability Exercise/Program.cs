using System;
using System.Collections.Generic;
using System.Linq;

namespace Boostability_Exercise
{
	internal class Program
	{
		static void Main(string[] args)
		{

			// declare routes
			string[] routes =
			{
				"/home",
				"/privacy -> /about -> /members",
				"/members -> /about",
				"/events -> /guestlist -> /home",
				"/about -> /members",
				"/members -> /about"
			};

			string previousPath = "";
			Console.WriteLine(previousPath);

			foreach (var route in routes)
			{
				Console.WriteLine(route);

				// declare the delegate as -> and split the route
				List<string> splitRoute = route.Split(" -> ").ToList();

				Console.WriteLine("Route Count: " + splitRoute.Count());

				// convert previousRoute to List<string>
				List<string> PreviousRoute = previousPath.Split(" -> ").ToList();

				// declare newRoute
				string newPath = "";

				if (previousPath.Count() != 0)
				{
					// if first route in the current route is equal to the last route of the previous path
					if (splitRoute[0] == PreviousRoute[PreviousRoute.Count() - 1])
					{
						splitRoute.Remove(splitRoute[0]);
						newPath = string.Join(" -> ", splitRoute);
						Console.WriteLine("New Route: " + newPath);
					} else if (splitRoute[0] == PreviousRoute[PreviousRoute.Count() - 1] && splitRoute[splitRoute.Count() - 1] == PreviousRoute[0])
					{
						Console.WriteLine("Circular reference not allowed");
					}
				}
				
				foreach (var split in splitRoute)
				{
					Console.WriteLine(split);
				}
				Console.WriteLine("\n");

				previousPath = newPath;
			}

			string[] newRoutes = new string[] { };
		}
	}
}
