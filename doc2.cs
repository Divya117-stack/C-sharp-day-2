using System;
class Class1
{
    void checkOddEven(int a)
    {
        Console.WriteLine(a);
        if(a%2==0)
        {
            Console.WriteLine("Even number");
        }
        else
        {
            Console.WriteLine("Odd number");
        }
    }
  static void Main() 
  {
 
         Class1 class1 = new Class1();
         class1.checkOddEven(6);
        Console.ReadLine();
  }
            
        }