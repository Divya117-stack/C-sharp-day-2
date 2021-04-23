using System;
class program {
  static void Main() {
    Console.WriteLine("Enter string");
    int[] charCount = new int[256];
    int Length = inputString.Length;
    for(index index=0; index < inputString.Length; index++)
    {
        charcount[inputString[index]]++;
    }
    int maxcount = -1;
    char character = ' ';
    for(int i=0; i<length; i++)
    {
        if(maxcount<charCount[inputString[i]])
        {
            maxcount = charCount[inputString[i]];
            character = inputString[i];
        }
    }
    Console.WriteLine("The string is {0}", inputString);
    Console.WriteLine("The highest occuring character us is :"+character+" and count is "+maxcount);
    Console.ReadLine();
  }
}