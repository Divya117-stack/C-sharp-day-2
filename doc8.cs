using System;

public class Program  
{  
    public static void Main() 
{
    string str;
    int i, len, vowel, cons;
      Console.Write("Input string : ");
      str = Console.ReadLine();		

    vowel = 0;
    cons=0;
    len = str.Length;

    for(i=0; i<len; i++)
    {

        if(str[i] =='a' || str[i]=='e' || str[i]=='i' || str[i]=='o' || str[i]=='u' || str[i]=='A' || str[i]=='E' || str[i]=='I' || str[i]=='O' || str[i]=='U')
        {
            vowel++;
        }
        
    }
   Console.Write("\nThe total number of vowel in the string is : {0}\n", vowel);
  
	}  
}   