﻿

Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

//kas number on paaris või paaritu

int result = userNum % 2;

if (result != 0)
{
    Console.WriteLine("User number is odd.");
}
else
{
    Console.WriteLine("user number is even.");
}