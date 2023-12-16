using System.Xml.XPath;

namespace RPGnewVersion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a player
            Player player = new Player("Peter", 100, 0, PlayerType.MENNESKE);
            //Creating a weapon for the player
            Equipment weapon = new Equipment("Excalibur", 12.5, 10);
            //Creating a monster
            NPC monster = new NPC("Orktip", 100, 0, MonsterType.ORK);
            //Checking that I can call the properties of monster and player
            Console.WriteLine("Player types:");
            Console.WriteLine($"{player.PlayerType}");
            Console.WriteLine($"{monster.MonsterType}");
            Console.WriteLine("Press ENTER to start battle");
            Console.ReadLine();
            //while loop checking if monster or human is dead
            while (!(player.IsDead() || monster.IsDead())) 
            { 
            //Player is attacking - call method
            player.Attack(weapon.AttackBonus);
                player.XP++;
                //monster is attacking
                monster.Attack(0);
                monster.XP++;
            }
            //Status after fight
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Status monster death: {monster.IsDead()}");
            Console.WriteLine($"Status player death: {player.IsDead()}");
            Console.WriteLine($"{player.Name}: HP {player.HP}, XP {player.XP}");
            Console.WriteLine($"{monster.Name}: HP {monster.HP}, XP {monster.XP}");
            Console.ResetColor();
        }
    }
}
