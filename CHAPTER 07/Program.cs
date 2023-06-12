// See https://aka.ms/new-console-template for more information

// 7.    Write a C# program to input any character and check whether it is alphabet, digit or special character  ?

Console.WriteLine("enter any chracter");
int ch = Convert.ToChar(Console.ReadLine());


if ( ch >= 'a' && ch <= 'z')
{
    Console.WriteLine("its an alphabet");
}
else if ( ch >= '0' && ch <= '9')
{
    Console.WriteLine("its a digit");
}
else
{
    Console.WriteLine("its a special character");
}