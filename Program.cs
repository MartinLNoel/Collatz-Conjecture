using System;

class Program
{
    public bool IsEven(int number)
    {
        if (number % 2 == 0)
            return true;
        else
            return false;
    }

    public void Calculation(int number)
    {
        if (IsEven(number) == true)
            number /= 2;
        else
            number = number * 3 + 1;
    }
}