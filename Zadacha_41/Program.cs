// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

//определение методов
//ввод данных пользователем
int enterDate(string message=" ")
{
    Console.WriteLine($"{message}: ");
    string Date=Console.ReadLine();
    int setDate=int.Parse(Date);
    return setDate;
}

//создание массива данных
int[] Massiv(int size)
{
    int[] array=new int[size];

    for(int i=0;i<array.Length;i++)
    {
        array[i]=enterDate($"Введите число {i+1}: ");
    }

    return array;
}

//определение кол-ва чисел больше нуля
int countPozitiv(int[] array)
{
    int count=0;

    for(int i=0;i<array.Length;i++)
    {
        if(array[i]>0)
        {
            count=count+1;
        }
    }

    return count;
}

//выполнение
int size=enterDate("Введите число вводимых чисел: ");

int[] mass=Massiv(size);
int count=countPozitiv(mass);

Console.WriteLine("Введенные данные: ");
System.Console.WriteLine(string.Join(" ",mass));
System.Console.WriteLine($"Количество положительных чисел: {count}");