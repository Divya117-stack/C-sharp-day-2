using System;

class program
{
  static void Main ()
  {
    object str = "hello";
   char[] values = {'h', 'e', 'l', 'l', 'o'};
    object str2 = new string(values);
    Console.WriteLine("using equality operator" +(str==str2));
     Console.WriteLine("using equalmethod {0}", str.Equals(str2));
     Console.ReadLine();
  }


}