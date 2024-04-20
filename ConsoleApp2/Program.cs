using System.ComponentModel.DataAnnotations;
using System.Numerics;

int[] array= { 1, 2, 3, 4, 5, 6, 7 };
//task1
Console.WriteLine("task1");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}


//task2
Console.WriteLine("task2");
int sum = 0;
for (int i = 0;i < array.Length; i++)
{
     sum+= array[i];
}
Console.WriteLine(sum);


//task3
Console.WriteLine("task3");
for (int i = array.Length-1; i >= 0; i--)
{
    Console.WriteLine(array[i]);
}

//task4
Console.WriteLine("task4");

int temp = 0;
for (int i = 0; i < array.Length / 2; i++)
{
    int j = array.Length - i - 1;
    temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}


//task5
Console.WriteLine("Task5");
int max = array[0];
for(int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine(max);


//task6
Console.WriteLine("Task6");
int count = 0;
for(int i = 0; i< array.Length; i++)
{
    count++;
}
Console.WriteLine(count);


//task7
Console.WriteLine("task7");
for (int i = 1; i < array.Length; i++)
{
    var key = array[i];
    var flag = 0;
    for (int j = i - 1; j >= 0 && flag != 1;)
    {
        if (key < array[j])
        {
            array[j + 1] = array[j];
            j--;
            array[j + 1] = key;
        }
        else flag = 1;
    }
}

for (int i = 0;i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}


//task8
Console.WriteLine("Task8");
int count2 = 0;
for( int i = 0; i < array.Length ; i++)
{
    if (array[i] == 0)
    {
        count2++;
    }
}
Console.WriteLine(count2);


//task9
Console.WriteLine("Task9");
int count3 = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        count3++;
    }
}
Console.WriteLine(count3);


//task10
Console.WriteLine("Task10");
int sum2 = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sum2 += array[i];
    }
}
Console.WriteLine(sum2);


//task11
Console.WriteLine("Task11");
for (int i = 0; i< array.Length; i++)
{
    array[i] = array[i] * array[i];
}
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}


