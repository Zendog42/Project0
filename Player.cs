public class Player
{   // Player hit points (health)
    public int HP {get; set;}

    // Player spell points (magic/skill)
    public int SP {get; set;}

    // Player coordinates on 2D plane
    public int locX {get; set;}
    public int locY {get; set;}

    // Player object list (inventory)
    // public Object[]? inventory {get; set;}          // Declare Object as a nullable variable (?) to clear a compiler warning
    public List<Object> inventory = new List<Object>(); 

    // Player quit status
    public static bool quit = false;

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
            player.DisplayRoom(levelMap, player);
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
        foreach(Object roomObj in levelMap[player.locX,player.locY].roomObj)
        {
            Console.Write($"\n{roomObj.title} \t ({roomObj.summary})");
        }
        Console.WriteLine();
    }

    public void Inventory(Player player)
    {
        if (player.inventory.Count == 0)
        {
            Console.WriteLine("Your pockets are empty.");
        }
        else
        {
            Console.WriteLine("You are carrying: ");
            foreach(Object item in player.inventory)
            {
                Console.WriteLine($"{item.title}");
            }
        }

    }
    public void Quit()
    {
        Console.Write("Are you sure? Progress will be lost. (Y/N): ");
        string qconf = Console.ReadLine().ToUpper();
        if(qconf == "Y")
        {
            Console.Clear();
            Console.WriteLine("From seemingly nowhere, Larry appears.");
            Console.WriteLine("Eyeing you with moderate yet unsurprised disappointment, he spits disdainfully on your shoe and mutters \"Figures\", \n" +
                              "as the world slowly fades away...");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to close the window:");
            Console.ReadLine();
            Player.quit = true;
        }
        else
        {
            return;
        }
    }   // end of PlayerQuit()
}