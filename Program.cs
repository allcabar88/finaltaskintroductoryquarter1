/*Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении 
не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

// устанавливаем начальное значение массива слов 
string[] array1 = new string[7]{"123244", "hi", "Russia", "love", "ra", "UAZ", "git"};
// отношение второго массива к первому по длине 
string[] array2 = new string [array1.Length];

//Алгоритм обработки инфмормации из первого масссива по длине слова
void arrayif(string[] array1, string[] array2)
{
    int count =0;
    for (int i = 0; i < array1.Length; i++)
        {   
            if(array1[i].Length <=3)
            {
                array2[count] = array1[i];
                count++;
            }
        }
}

// Алгоритм вывода полученного результата на экран

void printres(string[] arrayres)
{
    for (int i = 0; i < arrayres.Length; i++)
    {
        Console.WriteLine($"{arrayres[i]}");

    }
   
} 

arrayif (array1, array2);
printres (array2);