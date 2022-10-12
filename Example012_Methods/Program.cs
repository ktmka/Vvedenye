// Методы первого типа не возвращают и не принимают
// void Method1()
// {
//     Console.WriteLine("Автор .....");
// }

//Вызов метода
// Method1();  // указать идентификатор  метода и скобки

// ------------------------------------------------------------------------
// Методы второго типа ничего не возвращают, только принимают
// void Method2(string msg)   //идентификатор и аргументы
// {
//     Console.WriteLine(msg);
// }
// //Вызов метода
// Method2("текст сообщения");

// Именованные аргументы - для методов, которые принмиают кол-во аргументов >1
// void Method2_1(string msg, int count)   //идентификатор и аргументы
// {
//     int i = 0;
//     while (i < count){
//         Console.WriteLine(msg);
//         i++;
//     }
// }

// Вызов метода
// Method2_1("ghdjdshsaga", 3);

// Явное указание значений для аргументов
//Именованные аргументы не обязательно писать по порядку
// Method2_1(msg:"ghdjdshsaga", count: 3);

// -----------------------------------------------------------------
// Методы третьего типа возвращают, но не принимают
//Обязательно при создании метода задать тип переменной и оператор return
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// When calling this method, be sure to specify the type of the variable, т.е.метод должен "положить" в переменную значение
// int year = Method3();
// После вызова метода, повторно можно будет использовать эту переменную, полученную в результате
// ConsoleWrite(year);

// ----------------------------------------------------------------------------
// Методы четвертого типа и принимают, и возвращают
// string Method4(int count, string f)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + f;
//         i++;
//     }
//     return result;
// }
// // call
// string res = Method4(5, "fgdhs");
// Console.Write(res);
//---------------------------------------------------------------------

//Цикл FOR
// string MethodF(int count, string f)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + f;
//     }
//     return result;
// }

// string res = MethodF(5, "fgdhs");
// Console.Write(res);
//------------------------------------------------

// Таблица умножения c циклом for
// for (int i = 2; i <= 10; i++)
//     {
//         for (int j = 2; j <= 10; j++)
//         {
//             Console.WriteLine($"{i} x {j} = {i*j}");
//         }
//         Console.WriteLine();
//     }

// ------------------------------------------------------------------------
// Задача: Замена в тексте
string text = "- Я думаю, сказал толстый Федот, ухмыляясь, что - "
            +"Какой-то новый текст тут должен быть - не так ли?"
            +"Определенно какой-то новый текст тут должен быть ";
// Создаем метод
// string ReplaceT(string text, char OldValue, char NewValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == OldValue)    result = result + $"{NewValue}";
//         else                        result = result + $"{text[i]}";
//     }
//     return result;
// }

// С помощью метода заменим все пробелы в тексте
// string NewText = ReplaceT(text, ' ', '|');   // Для char всегда одинарные кавычки ' '
// Console.WriteLine(NewText);
// string NewText2 = ReplaceT(text, 'к', 'К');  // Потом заменим буквы К и к
// Console.WriteLine(NewText2);

//--------------------------------------------------------------------------
// Сортировка массива методом перебора, методом выброра минимального и его перестановки на 1 место (на каждом шаге)
// int[] a = {1,5,4,3,2,6,7,1,1};

// void PrintArray(int[] array)     // Метод для вывода массива последовательно по одному значению
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");      // Вывод в одну строку
//     }
//     Console.Write(" ");                   // Пустая сьрока для разделения
// }

// PrintArray(a);

// void SortArray(int[] array)     // Метод для сортировки массива
// {
//     for (int i = 0; i < array.Length-1; i++)
//     {
//         int minPos = i;    // Запоминаем min позицию на данный момент
//         for (int j = i + 1; i < array.Length; j++)
//         {
//             if (array[j] < array[minPos])   
//             {minPos = j;
//             }
//         }
//         int tempPos = array[i]; // Меняем позицию обратно с int minPos = i, сбрасываем 
//         array[i] = array[minPos]; // как минимальное записываем найденный minPos
//         array[minPos] = tempPos;
//     }
//     Console.Write(" ");                   // Пустая сьрока для разделения
// }


// SortArray(a);