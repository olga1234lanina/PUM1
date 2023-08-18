// Напишите программу, которая на вход принимает цифру, обозначающую день недели, и проверяет, является ли этот день выходным
// 1 -> NO
// 2 -> NO
// 3 -> NO
// 4 -> NO
// 5 -> NO
// 6 -> YES
// 7 -> YES

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}
bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
       return true;
    }
    Console.WriteLine("Подумайте лучше, сколько дней в недели :) и попробуйте еще раз:");
    return false;
}

int weekDay = Prompt("Пожалуйста введите день недели (>)ниже ");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Поздравляю! Отличная работа! Ты нашел(ла) выходные дни :)");
    }
    else
    {
        Console.WriteLine("Потрудись еще, но ты на верном пути :)");
    }
}