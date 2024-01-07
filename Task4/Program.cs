int n = 6749302;
while (n > 10)
{
    int i = n % 10;
    n = n / 10;
    Console.Write(i);
    Console.Write(", ");
}
Console.Write(n);