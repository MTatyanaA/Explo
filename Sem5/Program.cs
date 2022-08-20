using System;
namespace Новая_папка


{

}
class Program
{

   static void WriteArray(int[] array)
   {
       for(int i = 0; i < array.Length; i++)
       {
          Console.Write(array[i] + " ");
       }
   }

static void Main(string[] args)
{
    string number =Console.ReadLine();  //1,24,613,124
    string[] array = new string[number.Length];
    int index = 0;
    foreach (var item in number)  //1, 2 4 , 6 1 3 , 1 2 4
    {
        if(item != ',')
        {
            array[index] += item.ToString();
        } else {
    
            index++;
        }
    }
    Console.Write("[");
    for(int i = 0; i <= index-1; i++)
    {
        Console.Write(array[i] +  ", ");
    }
    Console.Write(array[index] + "]");
}
}
