// из числа делаем массив 
Console.WriteLine("Введите любое число");
string strNumber = Console.ReadLine();
bool isParsedA = int.TryParse(strNumber, out int A);

if (!isParsedA)
{
    Console.WriteLine("Ошибка ввода данных");
    return;
}
bool trueNumber = WriteToArray(strNumber);
Console.WriteLine($"Число {trueNumber}");
PrintArray(myArray);

bool WriteToArray(string Aa)
{
    bool result = false;
    if (Convert.ToInt32(Aa) < 0)
        return result;
    else
    {
        char[] myArray = new char[Aa.Length];
        for (int i = 0; i < Aa.Length; i++)
        {
            myArray[i] = Aa[i];
        }

        result = true;
    }
    return result;
}

void PrintArray(char[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.WriteLine(col[i]);
    }
}