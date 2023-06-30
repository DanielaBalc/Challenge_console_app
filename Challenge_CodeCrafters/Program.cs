// See https://aka.ms/new-console-template for more information
using Challenge_CodeCrafters;
using Microsoft.VisualBasic;



 string userId;
DateTime dataTime;
string password;

Console.WriteLine("Please write your user ID: ");
userId = Console.ReadLine();

Console.WriteLine("Please write the Date time (2023-06-30 00:00:00): ");
dataTime = Convert.ToDateTime(Console.ReadLine());
        
Password.GeneratePass();
var timer = new PeriodicTimer(TimeSpan.FromSeconds(30));
// Console.WriteLine("Time: " + timer.);
while (await timer.WaitForNextTickAsync())
{
    Console.WriteLine("Password has expired. Do you want to generate new one?");
    string answer = Console.ReadLine();
    if (answer.ToUpper() == "Y" || answer.ToUpper() == "YES")
    {
        Password.GeneratePass();
        timer = new PeriodicTimer(TimeSpan.FromSeconds(30));
    }
    else
    {
        return;
    }
}

