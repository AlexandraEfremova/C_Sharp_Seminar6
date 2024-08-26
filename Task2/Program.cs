// На основе символов строки (тип string) сформировать
// массив символов (тип char[]). Вывести массив на экран

void Main()
{
    string str = "Hello!";
    // самый лёгкий способ преобразовать строку в массив символов
    // char[] tempChar = str.ToCharArray();
    // PrintCharArray(tempChar);
    PrintCharArray(FromStringToCgarArray(str));
}
// напишем метод, который возвращает массив символов
char[] FromStringToCgarArray(string str)
{
    char[] tempChar = new char[str.Length];
    // по сути каждая строка - это массив, в котором можно обращаться к его 
    // элементам по индексу, однако в строке элементы доступны только для чтения
    for(int i = 0; i < str.Length; i++)
    {
        tempChar[i] = str[i];
    }
    return tempChar;
}
// напишем метод, который выводит массив
void PrintCharArray(char[] c)
{
    System.Console.WriteLine("['" + string.Join("', '", c) + "']");
}

Main();

// // операция проверки на условный Null
// string str = null;
// // без знанака "?" будет ошибка, с этим знаком программа завершиться. 
// // Что делает "?" - проверяет содержит ли строка значение null, если да, 
// // то строка просто не возвращается
// // если там не Null, то строка выполнится
// System.Console.WriteLine(str?.Contains("c"));  