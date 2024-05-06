using static System.Formats.Asn1.AsnWriter;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prep shit
            bool running = true;
            Console.SetWindowSize(122, 35);
            Console.BufferHeight = 35;
            Console.BufferWidth = 122;

            var border = new Maps();
            var playerSprite = new PlayerSprite(50, 13);
            var Menus = new Menus();
            var cutscene = new Cutscenes();
            var mapSprites = new Sprites();
            string activeScene = "forest";

            Dictionary<string, Scenes> scenes = new Dictionary<string, Scenes>();
            scenes.Add("forest", new Scenes("Forest", () =>
            {

                scenes["forest"].IsActive = true;
            }, () =>
            {

                scenes["forest"].IsActive = false;
            }, true));

            scenes.Add("cave", new Scenes("Cave", () =>
            {

            }, () =>
            {

            }, true));
            scenes.Add("house1", new Scenes("House", () =>
            {

            }, () =>
            {

            }, true));
            scenes.Add("caveman", new Scenes("CavemanCS", () =>
            {

            }, () =>
            {

            }, true));

            Cutscenes.DrawScene(cutscene.opening, 0, 0);


            //// Gets Player Name
            Console.SetCursorPosition(50, 28);
            Console.WriteLine("Please enter a character name:");
            Console.SetCursorPosition(50, 29);
            string playerName = Console.ReadLine();
            Console.Clear();

            // Title Card
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.CursorVisible = false;
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
            scenes["forest"].Enter();
            mapSprites.Draw(mapSprites.cave, 25, 110);
            mapSprites.Draw(mapSprites.house1, 3, 40);
            Menus.MainStats(characterSheet);
            border.DrawBorder();
            playerSprite.Draw();
            Menus.DrawMenus(Menus.X, Menus.Y);
            foreach (var forest1 in border.forest1)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                mapSprites.Draw(mapSprites.tree1, forest1.Key, forest1.Value);
                Console.ResetColor();
            }


            while (running)
            {
                Console.CursorVisible = false;
                // draws the forest 1 sprites

                // draw the scene only while the forest scene is active here. Doing so by putting it in a while loop and using scene.IsActive bool
                if (scenes["forest"].IsActive)
                {
                    foreach (var forest1 in border.forest1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        mapSprites.Draw(mapSprites.tree1, forest1.Key, forest1.Value);
                        Console.ResetColor();
                        mapSprites.Draw(mapSprites.cave, 25, 110);
                        mapSprites.Draw(mapSprites.house1, 3, 40);

                        // for debugging position. Don't leave it on, causes memory leak
                        //Console.SetCursorPosition(10, 3);
                        //Console.Write("Y:" +playerSprite.posY);
                        //Console.SetCursorPosition(10, 3);
                        //Console.Write("X:"+playerSprite.posX);
                        if ((playerSprite.posX >= 108 && playerSprite.posX <= 111) && playerSprite.posY == 25) { scenes[activeScene].IsActive = false; scenes["cave"].Enter(); }
                        if ((playerSprite.posX >= 35 && playerSprite.posX <= 43) && (playerSprite.posY >= 2 && playerSprite.posY <= 4)) { scenes[activeScene].IsActive = false; scenes["house1"].Enter(); }
                    }
                }
                // checks play pos for cave enter

                if (scenes["cave"].IsActive)
                {

                    activeScene = "cave";
                    Menus.DrawMenus(Menus.X, Menus.Y);

                    if((playerSprite.posX >= 35 && playerSprite.posX <= 43) && (playerSprite.posY >= 2 && playerSprite.posY <= 4)) 
                    {
                        Console.Clear();
                        Cutscenes.DrawScene(cutscene.caveman,0,0);
                        Console.ReadKey();
                    }
                    foreach (var forest1 in border.forest1)
                    {

                        mapSprites.Draw(mapSprites.caveman, 4, 100);
                        mapSprites.Draw(mapSprites.cave, 10, 10);





                        // for debugging position. Don't leave it on, causes memory leak
                        //Console.SetCursorPosition(9, 10);
                        //Console.Write("Y:" + playerSprite.posY);
                        //Console.SetCursorPosition(10, 11);
                        //Console.Write("X:" + playerSprite.posX);

                    }
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