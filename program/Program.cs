
string[] findMaxThreeChar(string[] array)
{
    int count = 0;
    for(int i =0; i < array.Length; i++)
    {
        if(array[i].Length < 4) count++;
    }

    string[] rezult = new string[count];
    count = 0;
    for(int i =0; i < array.Length; i++)
    {
        if(array[i].Length < 4)
        {
            rezult[count] = array[i];
            count++;
        }
    }

    return rezult;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"\"{array[i]}\" ");
    Console.WriteLine();
}






string[] inputDate;
int selectInput = 0;
bool select = false;

while(!select)
{
    Console.WriteLine("Какой массив будем использовать? \n 1: Ввод с клавиатуры \n 2: Заданный программой \n введите 1 или 2");
    selectInput = int.Parse(Console.ReadLine() ?? "0");
    if(selectInput == 1 || selectInput == 2) select = true;
}

if(selectInput == 1)
{
    Console.WriteLine("Введите элементы массива через запятую:");
    string str = Console.ReadLine() ?? "0";
    inputDate = str.Split(",")
                   .Select(e=>(e))
                   .ToArray();
}
else
{
    inputDate = new string[]{"I", "need", "very", "well", "assessment", ":-)", "it", "is", "fun"};
}

Console.WriteLine("===========");
Console.WriteLine("Массив с которым будем работать:");
PrintArray(inputDate);

string[] arrayMaxThreeChar;
arrayMaxThreeChar = findMaxThreeChar(inputDate);

Console.WriteLine("===========");
Console.WriteLine("Полученный результат:");
PrintArray(arrayMaxThreeChar);
