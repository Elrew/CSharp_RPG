using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Menus
    {
        // static positions for the menu options to start
        public int Y = 31;
        public int X = 0;

        //public List<string> options = new List<string>();
        public Dictionary<string, ConsoleColor> options = new Dictionary<string, ConsoleColor>();

        // Things that will be constant for the player
        public void MainStats(Player player) 
        {
            // key value pairs for the color added
            options.Add($"{player._name}", ConsoleColor.Blue);
            options.Add($"Health:{player._health}",ConsoleColor.Red);
            options.Add($"Gold:{player._gold}", ConsoleColor.Yellow);
            options.Add($"EXP:{player._exp}", ConsoleColor.Green);
        }

        // stores

        // draw the menus
        public void DrawMenus(int posy, int posx)
        {
            foreach (var option in options)
            {

                Console.SetCursorPosition(posy, posx);
                Console.ForegroundColor = option.Value;
                Console.Write(option.Key);
                Console.ResetColor();
                posx++;
            }
        }
    }
}
