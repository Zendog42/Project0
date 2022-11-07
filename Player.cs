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
            player.locX--;
            Console.WriteLine("You move North.\n");
            // DisplayRoom();
        }
        else if(cmd == "W" && exits.Contains("South"))
        {
            player.locX--;
            Console.WriteLine("You move North.\n");
            // DisplayRoom();
        }
        else if(cmd == "E" && exits.Contains("South"))
        {
            player.locX--;
            Console.WriteLine("You move North.\n");
            // DisplayRoom();
        }
        else 
        {
            Console.WriteLine("That is not a valid direction!");
        }

            
    }   // end of PlayerMove()
}