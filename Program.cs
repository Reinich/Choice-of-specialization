string[] InputArray()
{
    string? test = Console.ReadLine();
    string[] list = test.Split(new Char[] {' '});
    return (list);    
}

void FindThreeElementsItem(string[] list)
{
    int n = FindSizeSecondArray(list);
    if (n == 0) Console.WriteLine("Элементов, равных или меньше трех, нет");
    string[] array = new string[n];
    int i = 0;
    foreach(string item in list)
    {
        if (item.Length <= 3) 
        {
            array[i] = item;
            i++;
        }
    }
    OutputArray(array);
}


int FindSizeSecondArray(string[] list)
{
    int count = 0;
    foreach(string item in list)
        if (item.Length <= 3) count++;
    return count;
}

void OutputArray(string[] list)
{
    foreach(string item in list)
        Console.Write(item + " ");
}

Console.Clear();
string[] array = InputArray();
FindThreeElementsItem(array);







