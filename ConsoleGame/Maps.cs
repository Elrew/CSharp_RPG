using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Maps
    {
        public int _borderWidth;
        public int _borderHeight;

        public Maps(int borderLength = 120, int borderHeight = 30)
        {
            _borderWidth = borderLength;
            _borderHeight = borderHeight;
        }

        // put in a first overworld map and use the Draw method in Sprites to do it. 








        
        public void DrawBorder(char borderChar = '█')
        {

            // Draws horizonal borders 
            string horzBorder = new string(borderChar, _borderWidth);
            Console.SetCursorPosition(0, 0);
            Console.Write(horzBorder);
            Console.SetCursorPosition(0, _borderHeight );
            Console.Write(horzBorder);

            // Draws verticle borders
            for (int i = 0; i < _borderHeight +1; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(borderChar);
                Console.SetCursorPosition(_borderWidth, i);
                Console.Write(borderChar);
            }

        }

        public void DrawMap()
        {

        }
    }
}
