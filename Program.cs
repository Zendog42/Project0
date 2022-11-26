using System;

    class Program
    {
        public static void Main(string[] args)
        {
            // Global variables

            

            // Initial game setup
            Console.Clear();
            Controller commands = new Controller();
            Room[,] levelMap = Setup.Rooms();
            Player player1 = Setup.Player();
            player1.DisplayRoom(levelMap, player1);

            //Main Game Loop
            while(Player.quit == false)
            {
                commands.Input(player1, levelMap);
            }  
        }
    }