// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
fizzBuzz(15);
static void fizzBuzz(int n)
{
    for (int i = 1; i <= n; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
            continue;
        }
        if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
            continue;
        }
        if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
            continue;
        }
   

        Console.WriteLine(i);

    }
}
Console.ReadLine();