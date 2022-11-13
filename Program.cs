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
            // Object[] levelObj = Setup.Objects();
            Room[,] levelMap = Setup.Rooms();
            Player player1 = Setup.Player();
            player1.DisplayRoom(levelMap, player1);
            
            
            //Main Game Loop
            while(quit == false)
            {
                
                Console.Write("Command: ");
                cmd = Console.ReadLine().ToUpper();

                // Evaluate for various command functions
                if(cmd == "N" || cmd =="E" || cmd == "W" || cmd == "S")
                {
                    player1.Move(cmd, levelMap, player1);
                }

                else if(cmd == "L" || cmd == "LOOK")
                {
                    Console.Clear();
                    player1.DisplayRoom(levelMap, player1);
                }

                else if(cmd == "Q" || cmd == "QUIT")
                {
                    quit = player1.Quit();
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
            
            


                        
           
        }


    }