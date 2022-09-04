//=================================================================================
// # 2 Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел.
//==================================================================================

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineС = Console.ReadLine();

if (inputLineA != null && inputLineB != null && inputLineС != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberС = int.Parse(inputLineС);

    if (inputNumberA > inputNumberB)
    if (inputNumberA > inputNumberC)

    {
        Console.Write("max = ");
        Console.WriteLine(inputLineA);
    }
    if (inputNumberB > inputNumberA)
    if (inputNumberB > inputNumberC)

    {
        Console.Write("max = ");
        Console.WriteLine(inputLineB);  
    }
    else
    {
        Console.Write("max = ");
        Console.WriteLine(inputLineC);
    }
}
