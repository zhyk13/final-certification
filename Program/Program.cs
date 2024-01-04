// Из имеющегося массива строк программа формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

int InputIntNumber(string msg)                              // Ввод целого числа с клавиатуры
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(string[] printmatrix)                      // Выводит на печать одномерную матрицу
{                                                           // типа string. Каждый элемент
    for (int i = 0; i < printmatrix.GetLength(0); i++)      // выводится с новой строки.
    {
        System.Console.WriteLine($"{printmatrix[i]}");
    }
}

string[] FillMatrix(string[] fillmatrix)                        // Заполняеет одномерный массив типа string
{                                                               // значениями, вводимыми с клавиатуры.
    for (int i = 0; i < fillmatrix.GetLength(0); i++)
    {
        Console.WriteLine($"Введите строку {i+1}: ");
            fillmatrix[i] = Console.ReadLine();
    }
    return fillmatrix;
}

string[] SelectMatrix(string[] selectmatrix, string[] rezmatrix, int num) // Заполняет массив rezmatrix
{                                                                         // элементами массива selectmatrix
    int j = 0;                                                            // длина которых меньше либо 
    for (int i = 0; i < selectmatrix.GetLength(0); i++)                   // равна num.
    {
        if (selectmatrix[i].Length <= num)
        {
            rezmatrix[j] = selectmatrix[i];
            j++;
        }
    }
    return rezmatrix;
}


void PrintRezMatrix(string[] printrezmatrix)                      // Выводит на печать только те элементы 
{                                                                 // одномерной матрицы типа string, 
    for (int i = 0; i < printrezmatrix.GetLength(0); i++)         // значение которых не равно Null.
    {                                                             // Все элементы выводится с новой строки.
        if (printrezmatrix[i] != null)
        {
            System.Console.WriteLine($"{printrezmatrix[i]}");
        }
    }
}

int n = InputIntNumber("Введите кол-во элементов массива строк: ");
string[] OriginalMatrix = new string[n];
string[] RezaltMatrix = new string[n];
OriginalMatrix = FillMatrix(OriginalMatrix);
Console.WriteLine("Исходный массив:");
PrintMatrix(OriginalMatrix);
int m = InputIntNumber("Введите максимальную длину искомых строк: ");
RezaltMatrix = SelectMatrix(OriginalMatrix, RezaltMatrix, m);
Console.WriteLine("Искомый массив:");
PrintRezMatrix(RezaltMatrix);
