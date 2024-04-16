using System;

class Lower_to_Upper
{
    static void Main()
    {
       char ch = char.Parse(Console.ReadLine());
       bool result;
       result = Char.IsUpper(ch);
       if(result)
       {Console.WriteLine("upper-case");}
       else
       {Console.WriteLine("lower-case");} 
    }

}
