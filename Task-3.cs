int[] Numbers = {1, 3, 2, 6, 7, 4, 45, 36};
int max = 0;

for (int i = 0; i < Numbers.Length; i++)
{
    Console.WriteLine(Numbers[i]);
    if (Numbers[i] > max)
    { max = Numbers[i]; }
}

Console.WriteLine("Greatest number = " + max);