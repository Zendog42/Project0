using System;

    class Program
    {
        public static void Main(string[] args)
        {
            // Global variables
            bool quit = false;
            string cmd = "";

            // Initial game setup
            Console.Clear();
            CmdHandler parser = new CmdHandler();
            Room[,] levelMap = Setup.Rooms();
            Object[] objects = Setup.Objects();
            Player player1 = Setup.Player();

            
            //Main Game Loop
            while(quit == false)
            {
                DisplayRoom();
                Console.Write("Command: ");
                cmd = Console.ReadLine().ToUpper();
            }
            
            
            void DisplayRoom()
            {
                Console.WriteLine(levelMap[player1.px,player1.py].title);
                Console.WriteLine(levelMap[player1.px,player1.py].detail);
            }
            
           
        }


    }