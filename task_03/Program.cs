using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    /// Вычисление сумм по строкам (на выходе массив с суммами строк)
    public static int[] SumRows(int[,] array)
        
    {
        int[] sumOfAllRowsArray = new int[array.GetLength(0)];
      //Напишите свое решение здесь
      for(int i= 0; i<array.GetLength(0); i++)
      {
        for(int j= 0; j<array.GetLength(1); j++)
        {
            sumOfAllRowsArray[i] +=array[i,j] ;
        }
      }
      return sumOfAllRowsArray;
    }
    
    // Получение индекса минимального элемента в одномерном массиве
    public static int MinIndex(int[] array)
    { 
        int min=array[0];
        int mininx=0;
        for(int i=0; i<array.Length; i++)
        {
                if (array[i] < min)
                {
                min = array[i];
                mininx =i;
                }
         
        }
       //Напишите свое решение здесь
       return mininx;
    }
    public static void PrintResult(int[,] numbers)
    {   
        
       int index = MinIndex(SumRows(numbers));
       //Напишите свое решение здесь
       Console.WriteLine(index);
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            
            numbers = new int[,] {
                {1, 2, 3},
                {1, 1, 0},
                {7, 8, 2},
                {9, 10, 11}
    };      
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}