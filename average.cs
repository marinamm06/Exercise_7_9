using System;

public class Average
{
	public static void Main()
	{
		double sumNotes = 0, note, counter = 0, average;
		string mark;

		Console.Write("Insert a mark: ");
		mark = Console.ReadLine(); // we read the mark as string to check the word "end"	 

		while (mark != "end")
		{  // if the mark isn't an end then we pass it to double to work with it
			note = Convert.ToDouble(s);
			counter++;   //counter of numbers
			sumNotes += note;  // sum of all the notes

			Console.Write("Insert a mark: ");
			mark = Console.ReadLine();
		}

		if (counter != 0)
		{
			average = sumNotes / counter;  //calculate the average
			Console.WriteLine("The average is {0}.", average);
		}
	}
}

