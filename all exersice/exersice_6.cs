using System;
class  DanglineElse
{
    static void Main()
    {
        Console.Write("enter a number=");
        int num =int.Parse(Console.ReadLine());
         
        if (num < 10)
        {
            Console.WriteLine("Number is less than 10");
//dangling fix in loop 
            if (num < 5)
            {
                Console.WriteLine("number is less than 5");
            }
            else
            {
                Console.WriteLine("number is equal too or gratter than 5");
                
            }
        }
        else
        {
            Console.WriteLine("number is 10 or grater than");
        }
    }
}
 


 