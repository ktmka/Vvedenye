// Задача на поиск элемента в массиве
int[] array = {4, 11, 21, 4, 31, 31, 15, 61, 17, 18, 19};
int n = array.Length;
int find = 4;
int index = 0;
while (index < n)
{
    if (array[index] == find) 
    {   Console.WriteLine(index);
        break;
    }
    index = index + 1;
}