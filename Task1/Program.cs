//Задача 1
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указани, что такого элемента нет.
// 4 3 1    (1, 2) => 9
// 2 6 9  

//========================  МЕТОД ПО СОЗДАНИЮ И ЗПОЛНЕНИЮ МАССИВА РАНДОМНЫМИ ЧИСЛАМИ  =======================

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



int CheckMatrix(int[,] array, int NeedRow, int NeedColumn)
{
    //if 
    int number = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i == NeedRow && j == NeedColumn)
            {
                number = array[i, j];
            }
            else if(NeedRow > array.GetLength(0) || NeedColumn > array.GetLength(1))
            {
                ErorText();
                break;
            }
        }
    }
    return number;
}

void ErorText()
{
    Console.WriteLine("С данной позицией элемента нет в массиве.");
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
Console.Write("Введите 1-ую позицию массива: ");
int pos1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-ую позицию массива: ");
int pos2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int result = CheckMatrix(array, pos1, pos2);
Console.Write("Элемент с такой позицией - " + result);






//Console.WriteLine("Array = " + array);
