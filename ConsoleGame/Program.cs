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

            Cutscenes.DrawScene(cutscene.opening, 0, 0);


            //// gets player name
            Console.SetCursorPosition(50, 28);
            Console.WriteLine("Please enter a character name:");
            Console.SetCursorPosition(50, 29);
            string playerName = Console.ReadLine();
            Console.Clear();

            Cutscenes.DrawScene(cutscene.titleCard, 0, 0);
            Console.ReadKey();
            Console.Clear();

            //                       important part here
            var characterSheet = new Player(playerName);
            Console.SetCursorPosition(50, 15);
            Console.WriteLine("                               ");

            // first drawing of shit
            playerSprite.Draw();          
            border.DrawBorder();
            Menus.MainStats(characterSheet);
            Menus.DrawMenus(Menus.X,Menus.Y );
            

            while (running)
            {
                
                
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