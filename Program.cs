string[] InputArray()
{
    string? test = Console.ReadLine();
    string[] list = test.Split(new Char[] {' '});
    return (list);    
}

void



void FindSizeSecondArray(string[] list)
{
    int count = 0;
    foreach(string item in list)
        if (item.Length <= 3) count++;
}

void OutputArray(string[] list)
{
    foreach(string item in list)
        Console.Write(item + " ");
}




Console.Clear();
string[] array = InputArray();





