using System;
class Class2
{
    void swap(int a, int b)
    {
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("a = "+a);
        Console.WriteLine("b = "+b);
       
    }
  static void Main() 
  {
 
        Class2 class1 = new Class2();
        int a= 5, b=6;
        class1.swap(a,b);
        Console.WriteLine("a = "+a);
        Console.WriteLine("b = "+b);
        Console.ReadLine();
  }
            
 }