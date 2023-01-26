string[] InputArray(int n)
{
    string[] list = new string[n];
    list = test.Split(new Char[] {' '});
    return (list);    
}

void FindThreeElements(string[] list)
{
    foreach(string item in list)
    {
        int num = int.Parse(item);

    }
}




Console.Clear();
Console.Write("Введите количество значений: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(InputArray(n));





