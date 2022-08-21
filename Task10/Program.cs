Console.WriteLine("Enter a three-digit number :");
int n = int.Parse(Console.ReadLine());

if (n < 100 || n>999)
{
    Console.WriteLine("It was entered a not three-digit number! ");
    Console.WriteLine("The third number of digit could not be find!");
    Console.WriteLine("Please try again!");
 
 }

else
{
Console.WriteLine("The third number of digit is: " +  n %10);
}




    

