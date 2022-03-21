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
				"/our-ceo.html -> /about-us.html",
				"/about-us.html -> /about",
				"/product-1.html -> /seo"
			};
			
			/*
			string[] routes =
			{
				"/about-us.html -> /about",
				"/about -> /about-us.html"
			};
			*/

			List<string> NewPaths = new List<string>();

			string previousPath = "";

			foreach (var route in routes)
			{

				// declare the delegate as -> and split the route
				List<string> splitRoute = route.Split(" -> ").ToList();


				// convert previousRoute to List<string>
				List<string> PreviousRoute = previousPath.Split(" -> ").ToList();

				// declare newRoute
				string newPath = "";

				if (previousPath != "")
				{
					// if first route in the current route is equal to the last route of the previous path
					if (splitRoute[0] == PreviousRoute[PreviousRoute.Count() - 1] && splitRoute[splitRoute.Count() - 1] != PreviousRoute[0])
					{
						// remove first route in current path
						splitRoute.Remove(splitRoute[0]);

						// add the current path to the end of the previous path
						newPath = previousPath + " -> " + string.Join(" -> ", splitRoute);

						// remove the redundant previous path from the final path list
						NewPaths.Remove(previousPath);

						// add the new path to the final path list
						NewPaths.Add(newPath);

					} else if (splitRoute[0] == PreviousRoute[PreviousRoute.Count() - 1] && splitRoute[splitRoute.Count() - 1] == PreviousRoute[0])
					{
						// if first route of current path == last route of prev path AND last route of current path == first route of prev route

						NewPaths.Add("Circular reference not allowed: " + previousPath + " -> " + route);
					} else
					{
						newPath = string.Join(" -> ", splitRoute);

						NewPaths.Add(newPath);
					}
				} else
				{
					newPath = route;

					NewPaths.Add(newPath);
				}

				previousPath = route;
			}

			Console.WriteLine("New Paths: \n");
			foreach (var path in NewPaths)
			{
				Console.WriteLine(path);
			}
		}
	}
}
