using System;
using System.Collections.Generic;
using System.Text;
//A Pascal triangle is mathematical array. It is created by each number being equal to the direct total of the numbers above it. 
//Avoid using a namespace as there is currently only 1 class
class PascalTriangle
{
	static void Main(string[] args)
	{
		Console.WriteLine("An Example of A Pascal Triangle Program");
		Console.Write("Enter in the numbers of rows for the triangles: ");
		string input = Console.ReadLine();
		int numRows = Convert.ToInt32(input);//Converts strings to numbers.
		for (int y = 0; y < numRows; y++)
		{
			int pascalStart =1;//Pascal triangles normally start from 1
			for (int q = 0; q < numRows - y; q++)
			{
				Console.Write("  ");//This will create the needed spacing for the shape to be a pascal triangle shape.

			}
			for (int x = 0; x <= y; x++)
			{
				Console.Write("   {0:D}", pascalStart);
				pascalStart= pascalStart* (y - x) / (x + 1);
			}
			Console.WriteLine();
			Console.WriteLine();
		}
		Console.WriteLine();
	}
}
