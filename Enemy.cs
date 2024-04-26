using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame_v1
{
    internal class Enemy
    {
        public string Name { get; private set; }
        public int AttackPower { get; private set; }
        public int Defense { get; private set; }
        public int Health { get; private set; }

        public Enemy(string name, int attackPower, int defense, int health)
        {
            Name = name;
            AttackPower = attackPower;
            Defense = defense;
            Health = health;
        }
    }
}
