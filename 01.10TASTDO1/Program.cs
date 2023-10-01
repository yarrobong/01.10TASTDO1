//1

using System.Text;

string str = "С# обладает эффективными средствами обработки строк";
Console.WriteLine($"Строка str: {str}");
int indexOfO = str.IndexOf('о'); 
Console.WriteLine($"Индекс первого вхождения символа 'о': {indexOfO}");

int lastIndexOfO = str.LastIndexOf('о'); 
Console.WriteLine($"Индекс последнего вхождения символа 'о': {lastIndexOfO}");


int indexOfMi = str.IndexOf("ми"); 
Console.WriteLine($"Индекс первого вхождения подстроки 'ми': {indexOfMi}");

int lastindexOfMi = str.LastIndexOf("ми"); 
Console.WriteLine($"Индекс первого вхождения подстроки 'ми': {lastindexOfMi}");


int indexOfAorBorV = str.IndexOfAny(new char[] { 'а', 'б', 'в' });
Console.WriteLine($"Индекс первого вхождения символов 'а', 'б' или 'в': {indexOfAorBorV}");


string subString = str.Substring(0, 12); 
Console.WriteLine($"Строка str начинается с подстроки: {subString}");

int endIndex = str.LastIndexOf("строк");
string endsWithSubstring = str.Substring(endIndex);
Console.WriteLine($"Строка str заканчивается подстрокой: {endsWithSubstring}");

Console.WriteLine();
Console.WriteLine();


//2
string s1 = "это тест", s2;

s2 = s1.Insert(4, "простой ");

Console.WriteLine(s2);
Console.WriteLine();
Console.WriteLine();
//3

string m1 = "это простой тест", m2;
Console.WriteLine(m1);
m2 = m1.Insert(4, "не");
Console.WriteLine(s2);
m2 = m2.Replace("не", "но");
m2 = m2.Replace("те", "то");
Console.WriteLine(m2);
Console.WriteLine();
Console.WriteLine();

//4

string n = "Один на суше другой на море";
string[] words = n.Split(' ');

foreach (string word in words)
{
    if (word == "суше")
    {
        Console.WriteLine();
    }
    Console.WriteLine(word );
}
string result = string.Join("!", words);
Console.WriteLine(result + "!");

Console.WriteLine();
Console.WriteLine();

//5
Console.Write("Введите строку со скобками: ");
string input = Console.ReadLine();

int startIndex = input.IndexOf('('); 
int endIndex1 = input.IndexOf(')');   

if (startIndex >= 0 && endIndex1 > startIndex)
{
    string result1 = input.Substring(startIndex + 1, endIndex1 - startIndex - 1);
    Console.WriteLine(result1);
}
else
{
    Console.WriteLine("Не удалось найти открывающую и закрывающую скобки в строке.");
}

Console.WriteLine();
Console.WriteLine();

//6

string str1 = "И он сказал:Да!Конечно!";

int n1 = str1.Length;
int halfLength = n1 / 2;

StringBuilder result2 = new StringBuilder(str1); // Исправлено на str1

for (int i = 0; i < halfLength; i++)
{
    if (result2[i] == ':')
    {
        result2[i] = '*';
    }
}

for (int i = halfLength; i < n1; i++)
{
    if (result2[i] == '!')
    {
        result2[i] = '.';
    }
}

string transformedString = result2.ToString();
Console.WriteLine(transformedString);
