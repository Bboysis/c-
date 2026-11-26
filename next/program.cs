using System;


//using  next;

namespace HelloEthiopiaApplication
{    
    class HelloEthiopia
    {        
        static void Main(String[] args)
        { 
            int i;
            do
            {
                Console.Write("""


                *****************************************************
                =================[ C# EXERSICES ]====================
                *****************************************************
                
                Which exercise would you like to See?
                    1.  Ex-1   - correct identifiers                   

                TO EXIT FROM THE PROGRAM ENTER 0
                
                please enter your preference: 
                """);
                i = int.Parse(Console.ReadLine());

                switch (i)
                {                    
                    case 1:  
                    TestHouse.creatHouse();                      
                        break;                    

                    default:
                        Console.WriteLine("Incorect input! please try again");
                        break;
                }


            } while (i != 0);

        }                          
    }
}