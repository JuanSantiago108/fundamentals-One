void RangeOne(int range = 255)
{
    for ( int i = 1; i <= range; i++)
    {
        Console.WriteLine(i);
    }
}


RangeOne(0);


void FizzBuzz(int range = 100)
{
    for (int i = 1; i <= range; i++)
    {
        bool divisibleByThree = i % 3 == 0;
        bool divisibleByFive = i % 5 == 0;

        if (divisibleByFive && divisibleByThree)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (divisibleByThree && !divisibleByFive)
        {
            Console.WriteLine("Fizz");
        }
        else if (divisibleByFive)
        {
            Console.WriteLine("FizzBuzz");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}

FizzBuzz();