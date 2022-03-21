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

			List<string> NewPaths = new List<string>();

			string previousPath = "";

			foreach (var route in routes)
			{
				Console.WriteLine(route);

				// declare the delegate as -> and split the route
				List<string> splitRoute = route.Split(" -> ").ToList();

				Console.WriteLine("Route Count: " + splitRoute.Count());

				// convert previousRoute to List<string>
				List<string> PreviousRoute = previousPath.Split(" -> ").ToList();
				Console.WriteLine("Previous Route [" + PreviousRoute.Count() + "]: " + String.Join(" ", PreviousRoute));

				// declare newRoute
				string newPath = "";

				if (previousPath != "")
				{
					// if first route in the current route is equal to the last route of the previous path
					if (splitRoute[0] == PreviousRoute[PreviousRoute.Count() - 1] && splitRoute[splitRoute.Count() - 1] != PreviousRoute[0])
					{
						splitRoute.Remove(splitRoute[0]);
						newPath = previousPath + " -> " + string.Join(" -> ", splitRoute);

						Console.WriteLine("New Route: " + newPath);

					} else if (splitRoute[0] == PreviousRoute[PreviousRoute.Count() - 1] && splitRoute[splitRoute.Count() - 1] == PreviousRoute[0])
					{
						Console.WriteLine("Circular reference not allowed");
					} else
					{
						newPath = string.Join(" -> ", splitRoute);
						Console.WriteLine("New Route: " + newPath);
					}
				} else
				{
					newPath = route;
					Console.WriteLine("New Route: " + newPath);
				}
				
				foreach (var split in splitRoute)
				{
					Console.WriteLine(split);
				}
				Console.WriteLine("\n");

				NewPaths.Add(newPath);

				previousPath = route;
			}

			Console.WriteLine("New Paths: \n");
			foreach (var path in NewPaths)
			{
				Console.WriteLine(path + "\n");
			}
		}
	}
}
