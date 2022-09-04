//=================================================================================
// # 9. Напишите программу, которая выводит случайное число из отрезка от [10, 99]
//    и показывает наибольшую цифру числа.
//==================================================================================

void oneVariant()
{
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);
    int ferstDigit = number / 10;
    int secondDigit = number % 10;
    if(ferstDigit > secondDigit)
    {
        Console.WriteLine(ferstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}

void VariantOfEvg()
{
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);
    int ferstDigit = number / 10;
    int secondDigit = number % 10;
    if(ferstDigit > secondDigit)
    {
        Console.WriteLine((ferstDigit > secondDigit) ? ferstDigit : secondDigit);
    }    
}

void charVariant()
{
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);
    //Вариант char
    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);
}

charVariant();

