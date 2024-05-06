using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Sprites
    {

        // sprites are arrays so I can iterate through them

        public string[] tree1 =
            {"  @@",
             " @@@@",
             "  ||",
             "  ||"   
            };
        public string[] cave =
             {
             "  ___",
             " /░░░\\ ",
             "/░░█░|"
            };
        public string[] house1 =
     {
             " /-\\",
             "/___\\",
             "|-Θ-|",
             "| █ |",
             "¨¨¨¨¨",
            };
        public string[] caveman =
            {
            "  /-\\",
            " |@▼@|",
            "  \\σ/",
            " / _ \\",
            "/_____\\"
            };



        public void Draw( string[]sprite, int posx,int posy)
        {
            foreach (string line in sprite)
            {
                Console.SetCursorPosition(posy, posx);
                Console.Write(line);
                posx++;
               
            }



        }
    }


}
