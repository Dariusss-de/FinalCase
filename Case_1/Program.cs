//Написать программу которая из массива строк формирует массив строк длина которых меньше или равна 3 символам
void FillArray(String[] arr)
{
 for(int i = 0;i<arr.Length;i++)
 {
    arr[i] = Console.ReadLine();
 }
}

void RewriteArray(String[] arr, String[] arr_r)
{
  
     int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if(arr[i].Length <= 3)
        {
        arr_r[count] = arr[i];
        count++;
        }
    }
}

void PrintArray_r(String[] arr_r)
{
   for(int i = 0;i<arr_r.Length;i++)
 {
    Console.Write(arr_r[i]+" ");
 }
}


Console.Write("Введите количество строк: ");
int line = int.Parse(Console.ReadLine());

try
{
    if(line<=0) 
    {
    throw new Exception("wrong line or colum");
    }
}
catch
{
    Console.Write("Введите количество строк: ");
    line = int.Parse(Console.ReadLine());
}
String[] array = new String[line];
String[] array_r = new String[array.Length];
FillArray(array);
RewriteArray(array,array_r);
PrintArray_r(array_r);
