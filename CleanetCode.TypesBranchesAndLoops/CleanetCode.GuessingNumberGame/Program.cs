using System.Text.RegularExpressions;

Random rng = new Random();

int secretNumber = rng.Next(0, 999);
int userNumber = -1;

string? userName;
string? userInput;

bool isIntNumber = false;

bool isWin = false;

int countMove = 0;

Console.WriteLine("Hello There!\n");
Console.WriteLine("Как вас зовут\n");

do
{
    userName = Console.ReadLine();
    Regex validationUserName = new Regex("^[a-zA-ZА-Яа-я]+$");


    if (userName == "")
    {
        Console.WriteLine("\nВведите имя, пустое значение не принимается\n");

    }
    if (!validationUserName.IsMatch(userName))
    {
        Console.WriteLine("Введите корректное имя, можно использовать только буквы латинского и русского алфавита");
        userName = "";
    }


} while (userName == "");

Console.WriteLine($"\nПривет {userName}." +
    $" Я загадал для тебя число(целое)! Попробуй отгдать");

while (!isWin)
{
    countMove++;
    Console.WriteLine("\nВведи целое число от 0 до 999 или exit для выхода\n");

    do
    {
        userInput = Console.ReadLine();

        if (userInput == "")
        {
            Console.WriteLine("Пустое значение не принимается!\n");
        }

        if (userInput == "exit")
            break;

        isIntNumber = int.TryParse(userInput, out userNumber);

        if (!isIntNumber && userInput != "")
        {
            Console.WriteLine($"\nВы ввели {userInput}, нужно ввести целое число от 0 до 999");
        }

        // добавим регулярку для валидации положительных целых чисел
        Regex validationUserNumber = new Regex("^[0-9]+$");
        if (!validationUserNumber.IsMatch(userInput) || userNumber > 999)
        {
            Console.WriteLine("\nДопускаются только целые числа от 0 до 999\n");
            isIntNumber = false;
        }

    } while (!isIntNumber || userInput == "exit");

    if (userInput == "exit")
        break;

    if (userNumber > secretNumber)
    {
        Console.WriteLine($"\nВаше число {userNumber} больше, чем загаданное");
    }
    else if (userNumber < secretNumber)
    {
        Console.WriteLine($"\nВаше число {userNumber} меньше, чем загаданное");

    }
    else
    {
        isWin = true;
        Console.WriteLine($"\n{userName}, вы победили!Колличество попыток - {countMove} ");
    }    
}


