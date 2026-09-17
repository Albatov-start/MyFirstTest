using System;
using System.Security.Cryptography.X509Certificates;
class Player{
    public int health = 100;
    public int medkits = 1;
    public void UseMedkit(){
        if ( health <= 40 && medkits > 0){
            health = health + 50;
            medkits = medkits - 1;
            Console.WriteLine("[RILEY] Used MedKit! + 50 HP!");
           }   }
  public void HitWithKnife(Hvatun target){
    target.health = target.health - 30;
    target.stamina = target.stamina - 50;
    Console.WriteLine("[RILEY] Slash! You hit hvatun with a knife for 30 damage.");}
    public bool TryDodge()
    {
        Console.WriteLine("Press W to DODGE!");
        ConsoleKey key = Console.ReadKey().Key;
        if (key == ConsoleKey.W)
        {
            Console.WriteLine("[RILEY] Perfect dodge!");
            return true;
        }
        else
        {
            Console.WriteLine("[RILEY] Failed to dodge!");
            return false;
        }
    }

  }
   
