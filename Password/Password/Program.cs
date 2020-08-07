using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Pas pas = new Pas();
            
            pas.Pass();
        }
    }

}

public class Pas
{
 public void Pass()
    {
        // 1st -Random Password

        Random random = new Random();
      System.Int64 passi = 354623;
        Int64 i = 1,psw=1,j=1;
        here:
       int ps = random.Next(100000, 1000000);
        //Console.WriteLine(ps);
        if (ps!=passi)
        {
           // ps++;
            i++;
            goto here;
           
        }
        else
        {
            Console.WriteLine(" ------- Random search Password! ----------");
            Console.WriteLine("\nAfter {0} combinations",i);
                Console.WriteLine("Password is succesfully found: "+ps);           
        }

        
        //Linear search Password

       
    me:
      
        if (psw != passi)
        {
            psw++;
            j++;
            goto me;

        }
        else
        {
            Console.WriteLine("\n\n ------- Linear search Password! ----------");
            Console.WriteLine("\nAfter {0} combinations", j);
            Console.WriteLine("Password is succesfully found: " + psw);

        }
    }
}
