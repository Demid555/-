// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] GenerateArray(int size)
{
    string[] array = new string[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

int PrintSize (string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

string[] NewArray(string[] array)
{
    int n = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            n++;
        }
    }

    string[] array_2 = new string[n];
    int j = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            array_2[j] = array[i];
            j++;
        }
    }
    return array_2;
}

int N = PrintSize("Введите размер массива: ");
string[] MyArray = GenerateArray(N);
Console.Write($"[{string.Join(", ", MyArray)}]");
string[] MyArray_2 = NewArray(MyArray);
Console.WriteLine();
Console.Write($"[{string.Join(", ", MyArray_2)}]");
