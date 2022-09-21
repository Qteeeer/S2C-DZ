// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число дня недели");
int day = Convert.ToInt32(Console.ReadLine());

int DayNumber(int day)
{

    if (day == 6 && day == 7)
    {
        Console.WriteLine("День является выходным");
    }
    else if (day >= 1 && day <= 5)
    {
        Console.WriteLine("День является рабочим");
    }
    else 
    {
            Console.WriteLine("В неделе 7 дней, введите от 1 до 7"); 
    }
    return  day;
}
DayNumber(day);
