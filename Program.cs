using System;
using System.Threading;

int health = 150;
int distance = 5;

Console.WriteLine( "[START] Hvatun spawned with " + health + " HP!" );
Console.WriteLine( " [START] Sound System: Loud roar played!" );
Console.WriteLine("------------------------------------------");
while ( distance > 0)
{
    Console.WriteLine( "[UPDATE] Checking distance... Current: " + distance + "m");
    distance = distance - 1;
    if (distance < 2)
    {
         Console.WriteLine("[UPDATE] STATUS: ATTACK!");
         break;
    }
}