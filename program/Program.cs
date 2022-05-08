
string[] findMaxThreeChar(string[] array)
{
    string s = string.Empty;
    int count = 0;
    for(int i =0; i < array.Length; i++)
    {
        if(array[i].Length < 4)
        {
            if(count == 0)
            {
                s = array[i];
                count++;
            }
            else s = $"{s}, {array[i]}";  
        }
    }
    string[] rezult = s.Split(",")
            .Select(e=>(e))
            .ToArray();
    return rezult;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

string[] inputDate = new string[]{"j", "ndh", "kfi)", "dhyrj", "jjj"};
PrintArray(inputDate);
string[] array;
array = findMaxThreeChar(inputDate);
PrintArray(array);