using System;

class Program
{
    //A function that determines if the number given is odd or even adn return true if its even.
    public bool IsEven(int number)
    {
        if (number % 2 == 0)
            return true;
        else
            return false;
    }

    public int CompareNumber(int currentNumber, int pastNumber)
    {
       return (pastNumber > currentNumber) ? pastNumber : currentNumber;
    }

    //The "main" function that calls the IsEven function and depending on the returned bool does divide by 2 or multiple by 3 plus 1.
    public int Calculation(int number)
    {
        //Variables used to save the numbers which will be used to compare later
        int pastNumber = number;
        int currentNumber = number;

        //The variable that is returned at the end and counts how many times the given number went through the process.
        int count = 1;
        //An if statement that prevents the given number to be 0 or less
        if (number <= 0)
            return 0;
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
            currentNumber = number;
            //Calling the function that will compare the two numbers and output the biggest number
            pastNumber = CompareNumber(currentNumber, pastNumber);
        }
        //Output the biggest number
        Console.WriteLine("Biggest Number: " + pastNumber);
        //Return the count calculated throught the process
        return count;
    }

    public static void Main(string[] args)
    {
        Program p = new Program();
        Console.WriteLine("Number of steps: " + p.Calculation(7));
    }

}

//take the current number and save it to pastNumber
//do the calculation
//save the new number to currentNumber
//compare the two numbers
//save the bigger one in pastNumber