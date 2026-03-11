using System;
public class Program
{
    static string weekdayInput = "4";
    static int weekdayProcessor = 0;

	static bool runBool = true;
    public static void Main()
    {
        Console.WriteLine("Pick a day number 0-6 & I'll tell you what" +
            " day it is" + " \nPick number 7 to end the program");
		
		while(runBool == true){
	    weekdayInput = Console.ReadLine();
        weekdayProcessor = int.Parse(weekdayInput);//
        
        
        int weekdaying = weekdayProcessor;
        switch ((Day)weekdaying)
        {
        
            case Day.Monday://you might leave the first empty to
                Console.WriteLine("Time to work!");//show the playerstate as none
                break;
            case Day.Tuesday:
               Console.WriteLine("Time to work!");
			   break;
            case Day.Wednesday:
               Console.WriteLine("Time to work!");
                break;
            case Day.Thursday:
			Console.WriteLine("Time to work!");
                break;
            case Day.Friday:
                Console.WriteLine("Time to work!");
                break;
            case Day.Saturday:
                Console.WriteLine("Relax, it's the weekend!"); 
                break;
            case Day.Sunday:
            Console.WriteLine("Relax, it's the weekend! Today is the Lord's day");
                break;
            case Day.stopDay:
            System.Environment.Exit(0);
                break;

        	}
		}//end of runbool while loop


//it is very important to not have Magic Numbers
//in your code

    }

    enum Day
    {
        Monday = 0,
        Tuesday = 1, 
        Wednesday, 
        Thursday, 
        Friday,
        Saturday, 
        Sunday, 

		stopDay = 7,
    }
}
