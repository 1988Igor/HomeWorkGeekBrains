int numberA = new Random().Next(1,10);
Console.WriteLine(numberA);
int result = numberA % 2;
if (result == 0)
{

    Console.WriteLine("This number is Even");
}
else
{

    Console.WriteLine("The number is not Even");
}