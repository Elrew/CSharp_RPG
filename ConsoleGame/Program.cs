namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prep shit
            bool running = true;
            Console.SetWindowSize(122,35 );

            
            var border = new Maps();
            var playerSprite = new PlayerSprite(50, 13);
            var Menus = new Menus();
            var cutscene = new Cutscenes();
            var mapSprites = new Sprites();

            Cutscenes.DrawScene(cutscene.opening, 0, 0);


            //// Gets Player Name
            Console.SetCursorPosition(50, 28);
            Console.WriteLine("Please enter a character name:");
            Console.SetCursorPosition(50, 29);
            string playerName = Console.ReadLine();
            Console.Clear();

            // Title Card
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Cutscenes.DrawScene(cutscene.titleCard, 0, 0);
            Console.SetCursorPosition(55, 20);
            Console.WriteLine("Press ENTER");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();

            //                       important part here
            var characterSheet = new Player(playerName);
            Console.SetCursorPosition(50, 15);
            Console.WriteLine("                               ");

            // first drawing of shit
            playerSprite.Draw();          
            border.DrawBorder();
            Menus.MainStats(characterSheet);
            Menus.DrawMenus(Menus.X,Menus.Y );
            foreach(var forest1 in border.forest1)
            {
                mapSprites.Draw(mapSprites.tree1, forest1.Key, forest1.Value);
            }
            

            while (running)
            {   
                // draws the forest 1 sprites
                foreach (var forest1 in border.forest1)
                {
                    Console.CursorVisible = false;
                    mapSprites.Draw(mapSprites.tree1, forest1.Key, forest1.Value);
                }

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    border.DrawBorder(); 
                    playerSprite.Move(key);
                    playerSprite.Draw();
                }

                





            }
        }
    }
}