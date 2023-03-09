void Newarray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = String($" value № {i+1}");
    }

    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        if( array[i].Length <= 3 && array[i].Length!= 0 )
        {
            Console.Write($"{array[i]} ");
        }
    }
}
int ReadInt(string argument1)
{
    Console.Write($"Enter {argument1} ");
    int number;

    while(!int.TryParse(Console.ReadLine(), out number))
    {
        
        Console.WriteLine(" You entered an invalid number, try again!");
    }
    
    return number; 
}
string String (string argument1)
{
    Console.Write($"Enter {argument1} ");
    string a = "";

    while( a.Length==0)
    {
        a = Console.ReadLine();
        if(a.Length==0)
        {
            Console.WriteLine(" You entered an invalid value, try again!");
        }
    }
    
    return a; 
}
string[] array = new string[ReadInt("array lengt")];
Newarray(array);