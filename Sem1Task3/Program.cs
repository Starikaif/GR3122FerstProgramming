﻿    // //=================================================================================
    // // # 3 Напишите программу, которая будет выдавать название
    // // дня недели по выбранному номеру
    // //==================================================================================

    // string? inputLine = Console.ReadLine();

    // if (inputLine != null)
    // {
    //     int inputDayOfWeek = int.Parse(inputLine);

    //     string[] DayOfWeek = new string[7];

    //     DayOfWeek[0] = "Понедельник";
    //     DayOfWeek[1] = "Вторник";
    //     DayOfWeek[2] = "Среда";
    //     DayOfWeek[3] = "Четверг";
    //     DayOfWeek[4] = "Пятница";
    //     DayOfWeek[5] = "Суббота";
    //     DayOfWeek[6] = "Воскресенье";

    //     if (inputDayOfWeek > 7 || inputDayOfWeek < 1)
    //     {
    //         Console.WriteLine("Такого дня нет.");
    //     }
    //     else
    //     {
    //         Console.WriteLine(DayOfWeek[inputDayOfWeek - 1]);
    //     }
    // 





    string outDayOfWeek = string.Empty;//""

    switch (inputDayOfWeek)
    {

        case 1: outDayOfWeek = "Понедельник"; break;
        case 2: outDayOfWeek = "Вторник"; break;
        case 3: outDayOfWeek = "Среда"; break;
        case 4: outDayOfWeek = "Четверг"; break;
        case 5: outDayOfWeek = "Пятница"; break;
        case 6: outDayOfWeek = "Суббота"; break;
        case 7: outDayOfWeek = "Воскресенье"; break;
        default: outDayOfWeek = "Такого дня нет"; break;

    }

    Console.WriteLine(outDayOfWeek);

    


