using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedGame
{
    public class Player
    {
        public int Health {  get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }


        public Player(string name, int health, int attack, int defense) { 
            Name = name;
            Health = health;
            AttackPower = attack;
            Defense = defense;
        }


        private Random random = new Random();

        public bool AttackPlayer(Player opponent)
        {
            if(random.NextDouble() > 0.2)
            {
                int damage = Math.Max(1,AttackPower - opponent.Health);
                opponent.Health = Math.Max(0,opponent.Health - damage);
                Console.WriteLine($"{Name} attacked {opponent.Name} for {damage} damage!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
