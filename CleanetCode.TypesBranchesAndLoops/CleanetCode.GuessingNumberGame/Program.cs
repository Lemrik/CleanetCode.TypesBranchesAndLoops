// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello There!");

Console.WriteLine("Как вас зовут");
string? userName = Console.ReadLine();

Console.WriteLine($"Привет {userName}." +
    $" Я загадал для тебя число от 0 до 99! Попробуй отгдать");




int secretNumber = 42;
int userNumber = -1;
bool isIntNumber = false;

do
{
    Console.WriteLine("Введи число от 0 до 99");
    string? userInput = Console.ReadLine();
    isIntNumber = int.TryParse(userInput, out userNumber);

    if (true)
    {

    }

} while (!isIntNumber) ;


if (userNumber > secretNumber)
{
    Console.WriteLine($"Ваше число {userNumber} больше, чем загаданное");
}
else if (userNumber < secretNumber)
{
    Console.WriteLine($"Ваше число {userNumber} меньше, чем загаданное");

}
else
{
    Console.WriteLine("Вы победили!");
}