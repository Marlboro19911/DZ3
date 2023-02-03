// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом. Не используйте строки
// 14212 -> нет;   12821 -> да;   23432 -> да.

Console.Clear();
string InputNumber(string message)
{
    System.Console.Write(message + " > ");
    string? number = Console.ReadLine();
    return number;
}
string number = InputNumber("Введите любое натуральное число");
Console.WriteLine(Palindrom (number)); 
string Palindrom(string number)
{
    int variable = 0;
    int temp = 0;
    int index = 0;
    if (int.TryParse(number, out variable))
    {
        if (number[0] == '0')
        {
            return " Ошибка, введённое число ненатуральное";
        }
        else
        {
            temp = variable;
            while (temp > 0)
            {
                index = index * 10;
                index = index + temp % 10;
                temp = temp / 10;
            }
            if(variable == index)
            {
             return $"Введённое число {number} является палиндромом.";
            }
            else
            {
                return $"Введённое число {number} не является палиндромом.";
            }
        }
    }
    else
    {
        return "Ошибка, введённые данные не являются числом.";
    }
}    

