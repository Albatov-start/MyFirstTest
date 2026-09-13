using System;
using System.Threading;

int stamina = 500;
int distance = 5;
int PlayerHealth = 100;
int MedKits = 1;

Console.WriteLine("[START] Hvatun spawned!");
Console.WriteLine("[START] Hvatun has 300 stamina!");
Console.WriteLine("[START] Sound System: Loud roar played!");
Console.WriteLine("-------------------------------------");

while (distance > 1)
{
    Console.WriteLine("[UPDATE] Checking distance... Current: " + distance + "m");
    distance = distance - 1;
    Thread.Sleep(400); 
}

Console.WriteLine("\n[UPDATE] STATUS: ATTACK! Hvatun reached you!");

while (PlayerHealth > 0)
{
    PlayerHealth = PlayerHealth - 35;
    stamina = stamina - 100;

    Console.WriteLine("--------------------------------");
    Console.WriteLine("[ATTACK] Hvatun bites you for 35 damage!");
    Console.WriteLine("[INFO] Hvatun stamina left: " + stamina + " stamina");
    
    if (PlayerHealth < 0) 
    {
        PlayerHealth = 0; 
    }
    Console.WriteLine("[WARNING] You have now " + PlayerHealth + " HP");
    if (PlayerHealth <40 && MedKits > 0){
     PlayerHealth = PlayerHealth + 50;
      Console.WriteLine("[UPDATE] You have + 50 HP!");
      MedKits = 0;}
    Thread.Sleep(600); 
}

Console.WriteLine("\n================================");
Console.WriteLine("[GAME OVER] Hvatun killed you!");
Console.WriteLine("================================");






