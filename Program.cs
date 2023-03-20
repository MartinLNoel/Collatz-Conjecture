using System;

class Program
{
    //A function that determines if the number given is odd or even and return true if its even.
    public bool IsEven(int number)
    {
        if (number % 2 == 0)
            return true;
        else
            return false;
    }
    // A function that takes two numbers and compares them returning a boolean
    public int CompareNumber(int currentNumber, int pastNumber)
    {
       return (pastNumber > currentNumber) ? pastNumber : currentNumber;
    }
    //Function that outputs the console.writeLine of all the neseccary information
    public void Text(int pastNumber, int count)
    {
        Console.WriteLine("Biggest Number: " + pastNumber);
        Console.WriteLine("Number of steps: " + count);
    }

    //The "main" function that calls the IsEven function and depending on the returned bool does divide by 2 or multiple by 3 plus 1.
    public void Calculation(int number)
    {
        //Variables used to save the numbers which will be used to compare later
        int pastNumber = 0;

        //The variable that is returned at the end and counts how many times the given number went through the process.
        int count = 1;
        //An if statement that prevents the given number to be 0 or less
        if (number <= 0)
        {
            Console.WriteLine("Please enter a number higher than 0.");
            Environment.Exit(0);
        }
        //A while loop that causes the main calculation to be on repeat until the given number is 1
        while (number != 1)
        {
            count++;
            //Calling the function that determines if the number variable is odd or even
            if (IsEven(number) == true)
                //if Even then the number is divided
                number /= 2;
            else
                //if odd then the number is multiplied by 3 plus 1
                number = number * 3 + 1;
            //Saving the new calculated number into currentNumber
            int currentNumber = number;
            //Calling the function that will compare the two numbers and output the biggest number
            pastNumber = CompareNumber(currentNumber, pastNumber);
        }
        //Cal the function to print all information once exited the while loop
        Text(pastNumber, count);
    }

    public static void Main(string[] args)
    {
        Program p = new Program();
        p.Calculation(100);
    }
}