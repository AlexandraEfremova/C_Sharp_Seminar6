// Считать строку с консоли, состоящую из латинских букв
// в нижнем регистре. Выяснить сколько среди введённых букв гласных. 

void Main()
{
    System.Console.Write("Введите текст: ");
    // ToLower() - преобразует все введённые символы к нижнему регистру, так как
    // A и a - это разные символы и буквы верхнего регистра в счётчике учитываться не будут
    string? str = Console.ReadLine()!.ToLower();
    System.Console.WriteLine(CountVowel(str));
}
// напишем метод на возврат количества гласных букв в строке
int CountVowel(string? str)
{
    int count = 0;
    foreach(char letter in str)
    {
        if(IsVowel(letter))
        {
            count++;
        }
    }
    return count;
}

// напишем метод проверки на гласность
bool IsVowel(char c)
{
    // проверим содержатся ли данные символы в строке
    return "aeiouy".Contains(c);
}

Main();
