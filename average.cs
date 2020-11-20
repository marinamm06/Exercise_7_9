//This program calculates the average of a set of marks until the user types "end"

using System;

public class Average
{
	public static void Main()
	{
		double sumNotes = 0, note, counter = 0, average;
		string mark;

		Console.Write("Insert a mark: ");
		mark = Console.ReadLine(); 	 

		while (mark != "end")
		{  
			note = Convert.ToDouble(s);
			counter++;   
			sumNotes += note;  

			Console.Write("Insert a mark: ");
			mark = Console.ReadLine();
		}

		if (counter != 0)
		{
			average = sumNotes / counter;  
			Console.WriteLine("The average is {0}.", average);
		}
	}
}

