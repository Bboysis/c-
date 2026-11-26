using System;

string ReturnEvenNumbers()
{
    string result = "";

    for (int i = 2; i < 100; i += 2)
    {
        result += i + " ";
    }

    return result.Trim();
}

Console.WriteLine(ReturnEvenNumbers());
//print all even no eske 100