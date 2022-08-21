Console.WriteLine("Enter a number :");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter another number :");
int n2 = int.Parse(Console.ReadLine());


if (n1%n2==0)
{
    Console.WriteLine("The number " +n1+ " is multiple to number " + n2);
}

else 
{
    Console.WriteLine("The number " +n1+  " is not multiple to number " + n2 +  ". The Remainder is " + n1%n2 );
}




