// Виды методов в языке C#

// ______________________________________________________________________

// Войд-метод 1. Ничего не принимает и ничего не возвращает

// void Method01()
// {
//     Console.WriteLine("Автор Курочкин Виктор");
// }

// Method01();

// ______________________________________________________________________

// Войд-метод 2. Что-то принимает, но ничего не возвращает

// void Method02(string msg)
// {
//     Console.WriteLine(msg);
// }

// Method02("Сюда выведется текст сообщения, который соответствует msg");

// void Method02(string msg, int count)
// {
//     int i = 1;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
        
// }
// Method02("Новая строка", 5);
// ______________________________________________________________________

// Метод 3. Ничего не принимает, но что-то возвращает

// int Method03()
// {
//     return DateTime.Now.Year;
// }

// int Year = Method03();
// Console.WriteLine(Year);

// ______________________________________________________________________

// Метод 4 (чаще всего применяется). Что-то принимает и что-то возвращает

// string Method04(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string final = Method04(4, "123 ");
// Console.WriteLine(final);

// ______________________________________________________________________

// Метод 4 через цикл for (цикл со счетчиков, когда известно число шагов)

string Method04(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string final = Method04(10, "12345 ");
Console.WriteLine(final);