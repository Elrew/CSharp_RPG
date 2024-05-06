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



        public Dictionary<int, int> forest1 = new Dictionary<int, int>
        {
            { 10, 100 },
            { 15, 78 },
            { 20, 20 },
            { 5, 54 },
            { 9, 9 },
            { 26, 65 },
            { 19, 110 },
            { 6, 4 },
            { 11, 36 },

        };

        
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
