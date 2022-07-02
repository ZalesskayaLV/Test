/*Написать программу, которая из имеющегося массива строк
 формирует массив из строк, длина которых
меньше либо равна 3 символа. */


//Метод выборки и создания массива строк меньше четырех символов из имеющегося массива
string[] Sample(string[] inputList)
{
    int len = 0;
    int count = inputList.Length;
    int characterLen = 4;

    for (int i = 0; i < count; i++)
    {
        if (inputList[i].Length < characterLen)
            len++;
    }

    string[] outputList = new string[len];
    int index = 0;
    for (int j = 0; j < count; j++)
    {
        if (inputList[j].Length < characterLen)
        {
            outputList[index] = inputList[j];
            index++;
        }
    }
    return outputList;
}


string Print(string[] words)
{
    string res = string.Empty;
    int length = words.Length;

    for (int i = 0; i < length; i++)
    {
        res += $"{words[i]} ";
    }
    return res;
}


Console.WriteLine("Введите несколько слов через запятую: ");
string words = Console.ReadLine();
string[] text = words.Split(", ");

string[] result = Sample(text);
Console.WriteLine($"{Print(result)}");
