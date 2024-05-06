using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Player
    {
        public string _name;
        public int _health;
        public int _gold;
        public int _exp;

        public Player(string name,int health =100, int gold = 0, int xp = 0 )
        {
            _name = name;
            _health = health;
            _gold = gold;
            _exp = xp;
        }

        public int ReturnStat(int i)
        {
            return i;
        }
        public void LevelUp()
        {
            
        }
    }
}
