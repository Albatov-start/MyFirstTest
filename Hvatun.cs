using System;
class Hvatun{
    public int health = 150;
    public int stamina = 300;
    
    
    public void Rest()
    {
        stamina = 150;
        Console.WriteLine("[UPDATE] Hvatun recovery 150 stamina!");
    }
    public bool IsTired()
    {
        if (stamina <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void LoseStamina()
    {
        stamina = stamina - 100;
        Console.WriteLine("[DODGE] Hvatun  missed and lost 100 stamina!");
    }
    public void Bite(Player target, Random dice){
        if (stamina <= 0)
        {
            stamina = stamina + 150;
            Console.WriteLine("[UPDATE] Hvatun is tired!");
        }
        else
        {
           int damage = dice.Next(15, 36);
         stamina = stamina - 100;
         target.health = target.health - damage;
         Console.WriteLine("[HVATUN] Bite attack for " + damage + " damage!");
         Console.WriteLine("[HVATUN] Stamina left: " + stamina + "");  
        }
     if ( health <= 0)
        {
            health = 0;
            Console.WriteLine("[HVATUN] Hvatun died!. You win!");
        }
    }
}