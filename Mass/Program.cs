// 1 создание размера
// 2. заполнение масива с клавиатуры.
// 3. вывод результата на экран.
// 4. запуск сортировки массива с отбором элементовз меньше/= 3 знакам
// 5. вывод результата на экран

Console.WriteLine("Создание одномерного массива. ");
Console.Write("Введите количество строк массива:  ");
int rowcount = Convert.ToInt32(Console.ReadLine());
string [] array = new string [rowcount]; //1 создание размера

fillArray(array);
printArray(array);
printSortArray(array);

void fillArray(string[] array)         // 2 заполнение массива с клавиатуры
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine(); 
    }
}


void printArray(string[] array)  // 3 вывод массива на экран
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {  
        Console.Write(array[i] + ",  "); 
    }
    Console.Write("]");
    Console.WriteLine();
}


void printSortArray(string[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        int temp1 = array[i].Length;
           if (temp1 <= 3)
           {
            Console.Write(array[i] + "  ");
           }
    }
    Console.Write("]");
    Console.WriteLine();
}  
