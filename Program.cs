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

                // is this a move command?
                if(cmd == "N" || cmd =="E" || cmd == "W" || cmd == "S")
                {
                    player1.PlayerMove(cmd, levelMap, player1);
                    // Console.WriteLine("You would normally have moved here.");
                    // PlayerMove();
                }

                else if(cmd == "Q")
                {
                    quit = player1.PlayerQuit();
                }

                else
                {
                    Console.WriteLine("I don't recognize that as a command.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }

                // is this an attack command?
                // if()

                // if cmd is in playerEnums: do shit
                // if cmd is in monsterEnums: 
                // if cmd is directionEnums:
                // string "North"
            }
            
            
            void DisplayRoom()
            {   
                Console.WriteLine(levelMap[player1.locX,player1.locY].title);
                Console.WriteLine(levelMap[player1.locX,player1.locY].detail);
                Console.Write("Obvious exits are: ");
                foreach(string exit in levelMap[player1.locX, player1.locY].exits)
                {
                    Console.WriteLine(exit + " ");
                }
            }

                        
           
        }


    }