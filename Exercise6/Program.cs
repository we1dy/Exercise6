using System;
public class Exercise
{
	public static void Main()
	{
		float PerHeight;
		Console.Write("\n\n");
		Console.Write("Accept the height of a person in centimeter");

		Console.Write("Input the height of the person (in centimetres):");
		PerHeight = Convert.ToInt32(Console.ReadLine());

		if (PerHeight < 150.0)
			Console.Write("The person is Dwarf. \n\n");
		else if ((PerHeight >= 150.0) && (PerHeight <= 165.0))
			Console.Write("The person is  average heighted. \n\n");
		else if ((PerHeight >= 165.0) && (PerHeight <= 195.0))
			Console.Write("The person is taller. \n\n");
		else
			Console.Write("Abnormal height.\n\n");
	}

}

