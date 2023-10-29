// Задача 2
// Задайте думерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// 4 3 1   =>  4 6 2
// 2 6 9   =>  2 6 9 
// 4 6 2   =>  4 3 1

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

// int[] NewMatrix(int[,] array, int Columns)
// {
//     int[] array_new = new int [Columns];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == 0)
//             {
//                 array_new[j] = array[i, j];
//             }
//         }
//     }
//     return array_new;
// }


//=========================  МЕТОД ПО ЗАМЕНЕ 1-ОЙ СТРОКИ НА ПОСЛЕДНЕЙ И ПОСЛЕДНЕЙ НА 1-Ю  ===================
int[,] PrintNewMatrix(int[,] array, int LastRow)
{
    int[,] copy_arr = array.Clone() as int[,];  // СОЗДАЕМ КОПИЮ НАШЕГО МАССИВА

    for(int i = 0; i < array.GetLength(0); i++)
    {
        if (i == LastRow)    
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                array[0, j] = array[LastRow, j];      // ЗДЕСЬ КАК РАЗ ПРОИСХОДИТ ЗАМЕНА 1-ОЙ СТРОКИ НА ПОСЛЕДНЮЮ
                array[LastRow, j] = copy_arr[0, j];
            }
        }
        else
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = array[i, j];
            }
        }

    }
    return array;
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

//int[] array_new = NewMatrix(array, columns);

//==================  МЕТОД ПО ЗАМЕНЕ 1-ОЙ СТРОКИ НА ПОСЛЕДНЮЮ И ПОСЛЕДНЕЙ НА 1-Ю  =========================
int[,] array_change = PrintNewMatrix(array, rows-1);
//----------------  ВЫВОД НА ЭКРАН НОВОГО МАССИВА  --------------------------
PrintArray(array_change);



