using System;
class Pro
{
    static void Main()
    {
        string F_name = "Muhammad";
        string L_name = "Ali";
        string Full_name = F_name + " " + L_name;
        Console.WriteLine("Full name is:"+Full_name);
        Console.WriteLine("comparison of two strings: \n0 if both are equal\n1 if 2nd string is > than first\n-1 if 1st is > than 2nd");
      
           Console.WriteLine( String.Compare(F_name, L_name));

    }
}
