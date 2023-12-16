using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RPGnewVersion
{
    enum PlayerType { MENNESKE, ELVER}
    internal class Player : Base
    {
        //field for enums
        PlayerType playerType;

        //field, instantiating a new list to use for equipment using the constructor and properties from Class Equipment
        List<Equipment> _equipmentList = new List<Equipment>();


        //property to get the enums
        public PlayerType PlayerType { get => playerType; set => playerType = value; }

        public Player()
        {
        }

        public Player(string name, int hp, int xp, PlayerType type)
        {
            Name = name;
            HP = hp;
            XP = xp;           
            PlayerType = type;
        }

        public override void Attack(int attackBonus)
        {
base.Attack(attackBonus);
        }
    }
}
