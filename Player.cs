class Player
{   // Player hit points (health)
    public int HP {get; set;}

    // Player spell points (magic/skill)
    public int SP {get; set;}

    // Player coordinates on 2D plane
    public int locX {get; set;}
    public int locY {get; set;}

    // Player object array (inventory)
    public Object[] inventory {get; set;}


    public void PlayerMove(string cmd, Room[,] levelMap, Player player)
    {
        string[] exits = levelMap[player.locX, player.locY].exits;

        if(cmd == "N" && exits.Contains("North"))
        {
            player.locX--;
            Console.WriteLine("You move North.\n");
            // DisplayRoom();
        }
        else if(cmd == "S" && exits.Contains("South"))
        {
            player.locX++;
            Console.WriteLine("You move South.\n");
            // DisplayRoom();
        }
        else if(cmd == "E" && exits.Contains("East"))
        {
            player.locY++;
            Console.WriteLine("You move East.\n");
            // DisplayRoom();
        }
        else if(cmd == "W" && exits.Contains("West"))
        {
            player.locY--;
            Console.WriteLine("You move West.\n");
            // DisplayRoom();
        }
        else 
        {
            Console.WriteLine("That is not a valid direction!");
            Thread.Sleep(1000);
            Console.Clear();
        }

    
    }   // end of PlayerMove()

    public bool PlayerQuit()
    {
        Console.Write("Are you sure? Progress will be lost. (Y/N): ");
        string qconf = Console.ReadLine().ToUpper();
        if(qconf == "Y")
        {
            Console.Clear();
            Console.WriteLine("From seemingly nowhere, Larry appears.");
            Console.WriteLine("Eyeing you with moderate yet unsurprised disappointment, he spits disdainfully on your shoe and mutters \"Figures\", as the world slowly fades away...");
            return true;
        }
        else
        {
            return false;
        }
    }   // end of PlayerQuit()
}