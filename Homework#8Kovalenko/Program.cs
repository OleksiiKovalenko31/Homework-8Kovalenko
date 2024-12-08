// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;


// 1. Створити масив із 10 елементів типу int. Присвоїти їм випадкові значення від -10 до 10, використовуючи клас Random
// Вивести на екран елементи масиву з парним індексом. (не парні значення, а саме парні індекси!!)
Random rnd = new Random();
int[] intArray = new int[10];
Console.WriteLine("1. Створити масив із 10 елементів типу int. Присвоїти їм випадкові значення від -10 до 10.\n");
for (int item = 0; item < intArray.Length; item++)
{
    intArray[item] = rnd.Next(-10 ,10);

    if (item % 2 != 0)
    {
        Console.WriteLine($"Значення парного індексу {item} = {intArray[item]}");
    }
    //Console.Write($"\n");
}
Console.WriteLine($"\n---------------------------------\n");

// 2.Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число.
Console.WriteLine("2.Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число.");

int sumintArray = 0;    
foreach (int item in intArray) 
{
  sumintArray = sumintArray + item;
}
if (sumintArray < 0)
{
    Console.WriteLine($"\nСума значень масиву є від'мною = {sumintArray}\n");
}
else 
{
    Console.WriteLine($"\nСума значень масиву є позитивним = {sumintArray}\n");
}
Console.WriteLine($"\n---------------------------------\n");

// 3. Створити та заповнити двовимірний масив розміру 9х9 з результатами таблиці множення
// (у першому рядку мають бути записані добутки кожного з чисел від 1 до 9 на 1,
// у другому – на 2, ..., в останньому – на 9). Тобто в 1 строчці будуть значення від 1 до 9, а у другому 2,4,6,....,18 і т.д. 

Console.WriteLine("Створити та заповнити двовимірний масив розміру 9х9 з результатами таблиці множення.\n");
int[,] multipArray = new int[9,9];
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        multipArray[i, j] = (j+1) * (i+1);
        Console.Write("{0,3}", multipArray[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine($"\n---------------------------------\n");

// 4. Створити двовимірний масив 5х5. Заповнити його будь-якими числами.
// Визначити та вивести на екран:
// а) максимальний елемент масиву;
// б) мінімальний елемент масиву;
// в) координати мінімального елемента масиву.
// г) координати максимального елемента масиву.
//
// |0.0|0.1|0.2|0.3|0.4|0.5|0.6|0.7|0.8|0.9|
//-------------------------------------------
// |1.0|1.1|1.2|1.3|1.4|1.5|1.6|1.7|1.8|1.9|

Console.WriteLine("Створити двовимірний масив 5х5. Заповнити його будь-якими числами. Визначити та вивести на екран...\n");
int[,] maxminArray = new int[5,5];
int maxValue = 0, minValue = 1000;
int  maxStr = 0, maxColumn = 0, minStr = 0, minColumn = 0; 


for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        maxminArray[i, j] = rnd.Next(1000);
        Console.Write("{0,6}", maxminArray[i, j]);

        if (maxValue < maxminArray[i, j])
        {
            maxValue = maxminArray[i, j];
            maxStr = i;
            maxColumn = j;
        }

        if (maxminArray[i, j] <= minValue )
        {
            minValue = maxminArray[i, j];
            minStr = i; 
            minColumn = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine("Максимальне значення {0} - координати {1}", maxValue, (maxStr, maxColumn));
Console.WriteLine("Мінімальне значення {0} - координати {1}", minValue, (minStr, minColumn));
Console.WriteLine($"\n---------------------------------\n");

// 5.За допомогою enum створити програму, що буде запитувати у користувача кількість днів,
// а потім рахувати який буде день через введену кількість, якщо рахувати від понеділка і виводити результат

Console.Write("Введіть к-ть днів - ");
bool blenOut = int.TryParse( Console.ReadLine(),out int numDay);
if (blenOut)
{
    numDay = numDay - ((numDay / 7) * 7);
    nameDay quantityDayEnum = (nameDay)numDay;

    switch (quantityDayEnum)
    {
        case nameDay.Sunday:
            { Console.WriteLine(nameDay.Sunday); }
            break;
        case nameDay.Monday:
            { Console.WriteLine(nameDay.Monday); }
            break;
        case nameDay.Thuesday:
            { Console.WriteLine(nameDay.Thuesday); }
            break;
        case nameDay.Wednesday:
            { Console.WriteLine(nameDay.Wednesday); }
            break;
        case nameDay.Thursday:
            { Console.WriteLine(nameDay.Thursday); }
            break;
        case nameDay.Friday:
            { Console.WriteLine(nameDay.Friday); }
            break;
        case nameDay.Saturday:
            { Console.WriteLine(nameDay.Saturday); }
            break;
    }
}
else
{
    Console.WriteLine("Не корректне значення!");
}

enum nameDay 
{
    Sunday = 1 ,
    Monday,
    Thuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
}