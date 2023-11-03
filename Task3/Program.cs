int[,] GenerateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;   // ВОЗВРАЩАЕТ СОЗДАННЫЙ МАССИВ
}


//======================  МЕТОД ПО ОТОРАЖЕНИЮ МАССИВА В ТЕРМИНАЛЕ  ===========================
void PrintArray(int[,] array)
{
    Console.WriteLine("Массив: ");
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


int FindMinRow(int[,] array)
{
    int min_index = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int result = 0;
        int summa = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            summa += array[i, j];

            if(j == array.GetLength(1) - 1)
            {
                if(result < summa)
                {
                    result = summa;
                    min_index += 1;
                }
            }
        }

    }

    return min_index;
}



//===============================  ЗАПРОС У ПОЛЬЗОВАТЕЛЯ РАЗМЕРНОСТИ МАССИВА  ====================
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количетсво столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

//====================  ИНИЦИАЛИЗАЦИЯ МАССИВА И ВЫЗОВ МЕТОДА ПО ЕГО СОЗДАНИЮ =============================
int[,] array = GenerateArray(rows, columns);
// -----------------  ВЫВОД МАССИВА В ТЕРМИНАЛ  ---------------------------------------
PrintArray(array);
Console.WriteLine();

int min_index = FindMinRow(array);
Console.Write("Наименьшая сумма элементов находится на строке - " + min_index);





