int size = GetArraySize("Enter the length of the array: ", "Error, need more array");
string[] elements = GetArray(size);
Console.WriteLine("\n Source array: ");
Console.WriteLine(String.Join(", ", elements));
Console.WriteLine("\n The final arrayy: ");
ReturnNewArray(elements);

int GetArraySize(string message, string error)
{
    while(true)
    {
        Console.Write(message);
        int size;
        if(int.TryParse(Console.ReadLine(), out size) && size > 0)
            return size;
        Console.WriteLine(error);
    }
}

string[] GetArray(int size)
{
    string[] firstArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"\n Enter {i+1} element of the array: ");
        firstArray[i] = Console.ReadLine();
    }
    return firstArray;
}

static void ReturnNewArray(string[] firstArray)
{
    string[] secondArray = new string[0];
    foreach (var value in firstArray)
    {
        if (value.Length <= 3)
        {
            Array.Resize(ref secondArray, secondArray.Length + 1);
            secondArray[secondArray.Length - 1] = value;
        }
    }
    if(secondArray.Length > 0)
    {
        Console.WriteLine(String.Join(", ", secondArray));
    }
    else
    {
        Console.WriteLine("Not a single element of the array <= 3 characters was found.");
    }
}