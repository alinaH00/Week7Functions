string hello = "Hello";
string panic = "Don't panic!";



PrintStringFiveTimes(hello);
PrintStringFiveTimes(panic);

static void PrintStringFiveTimes(string sentance)
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(sentance);
    }
}
