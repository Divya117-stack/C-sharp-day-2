using System;

class program
{
  static void Main ()
  {
  Console.WriteLine("Enter a string");
  string inputString = Console.ReadLine();
  char []reversedStringArray= new char[inputString.Length];
  for(int i = inputString.Length-1; i>=0; i--)
  {
      reversedStringArray[i] = inputString[i];
  }
  string reversedString = new string( reversedStringArray);
  if(reversedString == inputString)
  {
      Console.WriteLine("Palindrome");
  }
      else
      {
           Console.WriteLine(" Please re-enter Palindrome");
      }
Console.ReadLine();
}
          
} 