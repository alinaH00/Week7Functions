int a = 5;
int b = 6;

Add(a,b);
Add(10, 100);
Add(8238, 8243);

Multiply(a,b);
Multiply(11, 30);

Substract(a,b);
Divide(a,b);
Divide(6, 6);

static void Add(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x + y}");

} 

static void Multiply(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");
}

static void Substract(int x, int y)
{
    Console.WriteLine($"{x} - {y} = {x - y}");

}
 static void Divide(int x, int y)
{
    Console.WriteLine($"{x} / {y} = {x / y}");
}