//=================================================================================
// # 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//==================================================================================

string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int inputNumberN = int.Parse(inputLineN);
    if (inputNumberN > 1)
    {    
        wile (startNumber < inputNumberN);
        {
            Console.Write(startNumber + ", ");
            startNumber = startNumber + 1;
        }
        Console.Write(inputNumberN);
    }

}