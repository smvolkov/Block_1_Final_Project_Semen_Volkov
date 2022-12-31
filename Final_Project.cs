//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

void FinalTask(string[] InStrings)
{
    string[] OutputStrings = {};

    for (int i = 0; i < InStrings.Length; i++)
    {
        if (InStrings[i].Length <= 3) 
        {
            Array.Resize(ref OutputStrings, OutputStrings.Length+1);
            OutputStrings[OutputStrings.Length - 1] = InStrings[i]; 
        }
    }

    Console.WriteLine(String.Join(",", OutputStrings));
}

string[] FillInputArray()
{
    string[] InputStrings = {};
    string newString = "";

    while (true)
    {
        Console.WriteLine("Введите следующий элемент массива. Для завершения введите End");
        newString = Console.ReadLine();
        if (newString == "End") break;
        Array.Resize(ref InputStrings, InputStrings.Length+1);
        InputStrings[InputStrings.Length - 1] = newString; 
    }

    Console.WriteLine(String.Join(",", InputStrings));

    return InputStrings;
}

FinalTask(FillInputArray());