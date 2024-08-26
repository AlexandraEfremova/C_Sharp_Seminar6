// Задание 1. Задайте массив символов (тип char[]). Создайте
// строку из символов этого массива
// Пример [`a', `b', `c', `d'] => "abcd"

void Main()
{
    // объявим массив символов типа char
    char[] letters = {'a', 'b', 'c', 'd'};
    // 1-ый метод преобрзования массива в строку
    // string str = new string(letters);

    // 2-ой способ вывод
    // string str = FromCharArrayToString(letters);

    // 3-ий способ
    // string str = string.Join("", letters);
    
    // 4-ый способ
    // string.Concat - объедияет все элементы массива без разделителей
    string str = string.Concat(letters);
    System.Console.WriteLine(str);
}
// // 2-ой способ
// // напишем метод, который из массива символов будет склеивать и возвращать нам строку
// string FromCharArrayToString(char[] letters)
// {
//     // создаём строку, в которую будем созранять результат
//     // пустое пространство выделяет опреативную память для хранения значений в строке
//     string str = "";
//     foreach(char letter in letters)
//         str += letter;
//     return str;
// }

Main();