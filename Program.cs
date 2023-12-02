for (int i = 0; i < myArray.Length; i++)

{
    if (myArray[i].Length <= 3)
    {
        if (i != myArray.Length - 1)
        {
            Console.Write($"{myArray[i]}, ");
        }
        else
        {
            Console.Write($"{myArray[i]}");
        }
    }
}