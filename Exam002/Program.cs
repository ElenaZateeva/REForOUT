// Принимает на входе число и проверяет на четность. Результат bool
Console.WriteLine("Введите любое число");
bool isParsedA = int.TryParse(Console.ReadLine(), out int A);

if (!isParsedA)
{
    Console.WriteLine("Ошибка ввода данных");
    return;
}
bool evenNumber = ParityCheck(A);

if (evenNumber)
    Console.WriteLine($"Значение числа {A} четное. Результат деления {A / 2}.");
else
    Console.WriteLine($"Значение числа {A} нечетное.");

bool ParityCheck(int a)
{
    bool result = false;
    if (A % 2 == 0) result = true;
    return result;
}