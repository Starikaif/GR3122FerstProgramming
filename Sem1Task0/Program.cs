//=================================================================================
// # 0 Напишите программу, которая на вход принимает какое-то число и выдает его квадрат 
//(число, умноженное само на себя).
//==================================================================================

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int outNumber = inputNumber * inputNumber;
    Console.WriteLine(outNumber);

}