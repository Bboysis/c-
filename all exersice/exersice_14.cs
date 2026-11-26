using System;

bool IfYearIsLeap(int year)
{
    return (year % 400 == 0) ||
           (year % 4 == 0 && year % 100 != 0);
}

Console.WriteLine(IfYearIsLeap(2016));
Console.WriteLine(IfYearIsLeap(2018));
//365 or 366 day yhonal 