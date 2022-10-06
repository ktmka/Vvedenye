// Создание массива с заданным числом элементов (10)
int[] array = new int[10]; // по умолчанию заполнен нулями, его будем наполнять с помощью функции


// Создаем функцию FillArray для заполнения массива collection1
void FillArray(int[] collection1)
{
    int length = collection1.Length;
    int index1 = 0;
    while (index1 < length)
    {
        collection1[index1] = new Random().Next(1, 10);
        index1++;
    }
}



// Функция для вывода массива (новый массив col)
void PrintArray(int[] col)
{
    int count1 = col.Length;
    int position = 0;
    while (position < count1)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}




// Напишем функцию для поиска элемента в массиве и отображения его индекса 
int IndexOf(int[] collection, int find);     // Индекс - это тип integer, как и искомый элемент - поэтому тип int
{
    int count = collection.Length;
    int index = 0;
    int positionFind = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            positionFind = index;
            break;
        }
        index++;
    }
    return positionFind;
}


// Применяем первые две созданные функции для созданного нулевого массива array
FillArray(array);
PrintArray(array);
Console.WriteLine(); // Для точности, что вышли из построения функции (?)

int pos = IndexOf(array, 4); // Применяем метод поиска индекса для массива array
Console.WriteLine(pos);