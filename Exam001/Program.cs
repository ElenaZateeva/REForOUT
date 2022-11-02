// Принимаем на входе 2 числа и меняем значения местами (REF)
//int A=0, B=0;
Console.WriteLine("Введите любые 2 числа");
bool isParsedA = int.TryParse(Console.ReadLine(), out int A);
bool isParsedB = int.TryParse(Console.ReadLine(), out int B);

Console.WriteLine($"Значение чисел: А={A} B={B}");

if (!isParsedA || !isParsedB)
{
    Console.WriteLine("Ошибка ввода данных");
    return;
}
DataExchange(ref A, ref B);
Console.WriteLine($"Значение чисел: А={A} B={B}");

void DataExchange(ref int Aa, ref int Bb)
{
    int vari = Aa;
    Aa = Bb;
    Bb = vari;
}
