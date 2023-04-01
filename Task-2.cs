int[] Numbers = { 73, 58, -96, 0, 28, -67 };
int PositiveCount = 0;
int NegativeCount = 0;

for (int i = 0; i < Numbers.Length; i++)
{
    if (Numbers[i] > 0)
    { PositiveCount++; }

    else if (Numbers[i] < 0)
    { NegativeCount++; }
}

Console.WriteLine(PositiveCount + " positive numbers");
Console.WriteLine(NegativeCount + " negative numbers");