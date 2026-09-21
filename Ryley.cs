using System;

class Player
{
    public int health = 100;
    public int medkits = 1;
    private int stamina = 150;

    public void UseMedkit()
    {
        if (health <= 40 && medkits > 0)
        {
            health = health + 50;
            medkits = medkits - 1;
            Console.WriteLine("[RILEY] Used MedKit! + 50 HP!");
        }   
    }

    public void HitWithKnife(Hvatun target)
    {
        target.health = target.health - 30;
        target.stamina = target.stamina - 50;
        Console.WriteLine("[RILEY] Slash! You hit hvatun with a knife for 30 damage.");
    }

    public bool TryDodge()
    {
        if (stamina < 50)
        {
            Console.WriteLine("[RILEY] Riley is too tired to dodge! (Stamina: " + stamina + ")");
            return false;
        }

        Console.WriteLine("[PROMPT] Press W to DODGE! (Riley Stamina: " + stamina + ")");
        ConsoleKey key = Console.ReadKey().Key;
        Console.WriteLine(); 

        if (key == ConsoleKey.W)
        {
            stamina = stamina - 50;
            Console.WriteLine("[RILEY] Perfect dodge! -50 Stamina.");
            return true;
        }
        else
        {
            Console.WriteLine("[RILEY] Failed to dodge!");
            return false;
        }
    }

    public void Rest()
    {
        stamina = stamina + 50;
        if (stamina > 150) 
        { 
            stamina = 150; 
        } 
        Console.WriteLine("[RILEY] Riley took a breath! +50 Stamina.");
    }
}