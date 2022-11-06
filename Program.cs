using System;

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CoffeeTalk - talk amonsgt yourselves.");
            
            Room[,] levelMap = Setup.Rooms();
            Setup.Objects();
            Player player1 = Setup.Player();

            DisplayRoom();
            
            
            void DisplayRoom()
            {
                Console.WriteLine(levelMap[player1.px,player1.py].title);
                Console.WriteLine(levelMap[player1.px,player1.py].detail);
            }
           
        }


    }