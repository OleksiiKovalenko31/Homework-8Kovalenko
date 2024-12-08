// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;


// 1. Створити масив із 10 елементів типу int. Присвоїти їм випадкові значення від -10 до 10, використовуючи клас Random
// Вивести на екран елементи масиву з парним індексом. (не парні значення, а саме парні індекси!!)
Random rnd = new Random();
int[] intArray = new int[10];

for (int item = 0; item < intArray.Length; item++)
{
    intArray[item] = rnd.Next(-10 ,10);
    Console.WriteLine($"{item}) Значение = {intArray[item]} ");
    if (item % 2 != 0)
    {
        Console.Write($" {item}) Значение parn index = {intArray[item]}\n");
    }

}

// 2.Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число.
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
Console.WriteLine($"---------------------------------");

// 3. Створити та заповнити двовимірний масив розміру 9х9 з результатами таблиці множення
// (у першому рядку мають бути записані добутки кожного з чисел від 1 до 9 на 1,
// у другому – на 2, ..., в останньому – на 9). Тобто в 1 строчці будуть значення від 1 до 9, а у другому 2,4,6,....,18 і т.д.
// 
// |0.0|0.1|0.2|0.3|0.4|0.5|0.6|0.7|0.8|0.9|
//-------------------------------------------
// |1.0|1.1|1.2|1.3|1.4|1.5|1.6|1.7|1.8|1.9|
//
int[,] multipArray = new int[9,9];
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        multipArray[i, j] = (j+1) * (i+1);
        Console.Write($"{multipArray[i, j]} ");
    }
    Console.Write($"\n");
}