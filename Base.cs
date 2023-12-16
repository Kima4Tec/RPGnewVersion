using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGnewVersion
{
    internal abstract class Base
    {
        string name;
        int hP;
        int xP;

        public string Name { get { return name; } set { name = value; } }
        public int HP { get => hP; set => hP = value; }
        public int XP { get => xP; set => xP = value; }

        public bool IsDead()
        {
            if (HP > 0)
            {
                return false;
            }
            else { return true; }
        }

        public void DoDamage(int damage, int bonus)
        {
            //influence HP and maybe XP - weapon bonus is called by a argument HP = a random number + a bonus
            HP = HP - damage + bonus;
        }

        //Made abstract and to be used in player
        public virtual void Attack(int attackBonus)
        {
            //can be text about the attack calling DoDamage() - could also hold a check if the attack is succeful or not
            Random num = new Random();
            int checkHit = num.Next(0, 6);
            if (checkHit > 2)
            {
                int rndNr = num.Next(0, 15);
                //Calling DoDamage with a random number and a bonus 
                DoDamage(rndNr, attackBonus);
                Console.WriteLine($"{this.Name} hits and causes {rndNr + attackBonus} damage.");
            }
            else
            {

                Console.WriteLine($"{this.Name} does not hit.");
            }
        }
    }
}
