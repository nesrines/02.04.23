int score = 1;

if (score < 0 || score > 100)
{
    Console.WriteLine("invalid");
}

else if (score > 90)
{
    Console.WriteLine("A");
}

else if (score > 80)
{
    Console.WriteLine("B");
}

else if (score > 70)
{
    Console.WriteLine("C");
}

else if (score > 60)
{
    Console.WriteLine("D");
}

else if (score > 50)
{
    Console.WriteLine("E");
}

else
{
    Console.WriteLine("Failed");
}