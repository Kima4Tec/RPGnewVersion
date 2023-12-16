using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGnewVersion
{

    enum MonsterType { ORK, DRAGE}
    internal class NPC : Base
    {
        MonsterType monsterType;
        internal MonsterType MonsterType { get => monsterType; set => monsterType = value; }

        public NPC()
        {
        }

        public NPC(string name, int hp, int xp, MonsterType type) 
        { 
        Name = name;
            HP = hp;
            XP = xp;
            MonsterType = type;        
        }

        public override void Attack(int attackBonus)
        {
base.Attack(attackBonus);
        }
    }
}
