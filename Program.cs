
using System;

string[] FormNewStringArray(string[] array)
{
    int count = 0;
     string[] ResultArray = new string[count];
        
     for(int i = 0; i< array.Length; i++)
    {
        if(array[i].Length <= 3) 
        {   
            Array.Resize(ref ResultArray, ResultArray.Length+1);
            ResultArray[count] = array[i];
            count++; 
        }
    } 
    return (ResultArray);	
}

void PrintArray(string[] Array)
{	
    for(int i = 0; i< Array.Length; i++)
    {
        Console.WriteLine("[" + Array[i] + "]"); 
    } 	
}

string[] StringArray = {"1234", "1567", "-2", "computer science"};
string[] ResultStringArray = FormNewStringArray(StringArray);

Console.WriteLine("Исходный массив: ");
PrintArray(StringArray);

Console.WriteLine("Сформированный массив: ");
if(ResultStringArray.Length == 0) 
    Console.WriteLine("В введенном массиве нет строк с длиной меньшей или равной 3");
else PrintArray(ResultStringArray);
		

