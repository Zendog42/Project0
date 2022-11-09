class Player
{   // Player hit points (health)
    public int HP {get; set;}

    // Player spell points (magic/skill)
    public int SP {get; set;}

    // Player coordinates on 2D plane
    public int locX {get; set;}
    public int locY {get; set;}

    // Player object array (inventory)
    public Object[]? inventory {get; set;}          // Declare Object as a nullable variable (?) to clear a compiler warning


    public void Move(string cmd, Room[,] levelMap, Player player)
    {
        string[]? exits = levelMap[player.locX, player.locY].exits;      // Declare array as a nullable variable (?) to clear a compiler warning

        if(cmd == "N" && exits.Contains("North"))
        {
            player.locX--;
            Console.WriteLine("You move North.\n");
            DisplayRoom(levelMap, player);
        }
        else if(cmd == "S" && exits.Contains("South"))
        {
            player.locX++;
            Console.WriteLine("You move South.\n");
            DisplayRoom(levelMap, player);
        }
        else if(cmd == "E" && exits.Contains("East"))
        {
            player.locY++;
            Console.WriteLine("You move East.\n");
            DisplayRoom(levelMap, player);
        }
        else if(cmd == "W" && exits.Contains("West"))
        {
            player.locY--;
            Console.WriteLine("You move West.\n");
            DisplayRoom(levelMap, player);
        }
        else 
        {
            Console.WriteLine("That is not a valid direction!");
            Thread.Sleep(1000);
            Console.Clear();
        }

    
    }   // end of PlayerMove()
    public void DisplayRoom(Room[,] levelMap, Player player)
    {   
        Console.WriteLine(levelMap[player.locX,player.locY].title);
        Console.WriteLine(levelMap[player.locX,player.locY].detail);
        Console.Write("Obvious exits are: ");
        foreach(string exit in levelMap[player.locX, player.locY].exits)
        {
            Console.Write($"{exit} ");
        }
        Console.WriteLine();
    }
    public bool Quit()
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