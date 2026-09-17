using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
class Program
{
    static void Main()
    {
        Player riley = new Player();
        Hvatun hvatun = new Hvatun();
        Random cryptoDice = new Random();
        Console.WriteLine("[START] Batlle initiated! Riley vs Hvatun!");
        Console.WriteLine("-------------------------------------------");
        while (riley.health > 0 && hvatun.health > 0)
        {
            bool success = riley.TryDodge();
          
             if ( success = false )
             {
         hvatun.Bite(riley, cryptoDice);
             }
            else
            {
                hvatun.stamina = hvatun.stamina - 100;
                Console.WriteLine("[DODGE] Hvatun missed!");                   
                                            
            }
            if (hvatun.stamina <= 0)
             {
                riley.HitWithKnife(hvatun);
                Console.WriteLine("[UPDATE] Hvatun has " + hvatun.health + " HP!");
             }
                riley.UseMedkit();
            if (riley.health < 0) { riley.health = 0; }
            Console.WriteLine("[STATUS] Riley HP: " + riley.health);
            Console.WriteLine("-----------------------------------");
            Thread.Sleep(900);

            
              
               
           

        }
     Console.WriteLine("/n--------------------------------------");
     Console.WriteLine("[GAME OVER] The battle is finished!");
     Console.WriteLine("----------------------------------------");
    }
}

