using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class PlayerSprite
    {
        public string _head;
        public string _body;
        public string _legs;
        public int posX { get; set; }
        public int posY { get; set; }

        public PlayerSprite(int posx, int posy, string head = "  ☺  ", string body = " /|\\ ", string legs = " / \\ ")
        {
            _head = head;
            _body = body;
            _legs = legs;
            posX = posx;
            posY = posy;
        }


        public void Draw()
        {
            Console.SetCursorPosition(posX , posY);
            Console.WriteLine(_head);
            // verticle sprite cleanup
            Console.SetCursorPosition(posX +2, posY -1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(posX, posY +1);
            Console.WriteLine(_body);
            Console.SetCursorPosition(posX, posY +2);
            Console.WriteLine(_legs);
            // verticle sprite cleanup
            Console.SetCursorPosition(posX, posY  +3);
            Console.WriteLine("    ");

            // sprite cleanup is done here to reduce flicker of the console image. 


        }

        public void Move(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    posY -= (posY > 1) ? 1 : 0; //stops from going off top 
                    break;
                case ConsoleKey.DownArrow:
                    posY += (posY < 26 ) ? 1 : 0; // stops from going off bottom
                    break;
                case ConsoleKey.LeftArrow:
                    posX -= (posX > 1) ? 1 : 0;// stops from going off left
                    break;
                case ConsoleKey.RightArrow:
                    posX += (posX < 115) ? 1 : 0; //stops from going off right
                    break;
            }
        }
    }
}
