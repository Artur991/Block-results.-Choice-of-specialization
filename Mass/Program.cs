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

void fillArray(string[] array)         // 2 заполнение массива с клавиатуры
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine(); 
    }
}
