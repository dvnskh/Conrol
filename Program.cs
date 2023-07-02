string[] FindThreeSymbols(string[] array) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i].Length <= 3) 
    {
        count++;
    }
    }

    string [] arrayThreeSymbols = new string [count]; //в новом массиве заполним элементами кторые меньше либо равны 3
    for (int i = 0,j=0;  i <array.Length; i++)//заполним массив этими символами
    {
        string symbols= array[i];//найденные символы прикрутим к новой переменной 
        if (array[i].Length<=3)
        {
        arrayThreeSymbols[j]=symbols;//заполнл новую переменную
        j++;
        }
    }return arrayThreeSymbols;//вернул значение
  }
void PrintArray(string[] arr, string v) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length ) Console.Write($"{arr[i]}{v}"); //распечатал 
    }  
}



Console.Write("[");
string[] array = new string[5] { "Msi", "NeVoidet", "Jet", "=)!", "Soul" };
PrintArray(array, ",");
Console.WriteLine("]");
Console.WriteLine();
Console.Write("[");
string[] array2 = FindThreeSymbols(array);
PrintArray(array2, ",");
Console.WriteLine("]");
