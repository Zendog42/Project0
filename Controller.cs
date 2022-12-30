using System;
using System.Collections.Generic;   // List<> is located in the Systems.Collection.Generic namespace

public class Controller
{
    string cmd = "";
    bool quit = false;

    public void Input(Player player1, Room[,] levelMap)
    {
        Console.Write("Command: ");
        cmd = Console.ReadLine().ToUpper(); 
        
        if(cmd.Count() == 1)
        {
            switch(cmd)
            {
                case "N":
                player1.Move(cmd, levelMap, player1);
                break;

                case "S":
                player1.Move(cmd, levelMap, player1);
                break;

                case "E":
                player1.Move(cmd, levelMap, player1);
                break;

                case "W":
                player1.Move(cmd, levelMap, player1);
                break;

                case "L":
                Console.Clear();
                player1.DisplayRoom(levelMap, player1);
                break;

                case "I":
                Console.Clear();
                player1.Inventory(player1);
                break;

                case "Q":
                player1.Quit();
                break;

                default:
                Console.WriteLine("I don't recognize that as a command.");
                Thread.Sleep(1000);
                Console.Clear();
                player1.DisplayRoom(levelMap, player1);
                break;
            }
        }

        else
        { 
            try
            {
                string[] splitCmdTest = cmd.Split(' ');
                string testVerb = splitCmdTest[0];
                string textNoun = splitCmdTest[1];
            }
            
            catch
            {
                if(cmd == "EXAMINE" || cmd == "GET" || cmd == "DROP" || cmd == "USE")
                {
                Console.WriteLine($"{cmd} what?");
                return;
                }

                else
                {
                    Console.WriteLine("I don't recognize that command.");
                    return;
                }
            }

            string[] splitCmds = cmd.Split(' ');
            string verb = splitCmds[0];
            string noun = splitCmds[1];
            bool inRoomObj = false;
            bool inRoomElement = false;
            bool onPlayer = false;

            inRoomObj = levelMap[player1.locX,player1.locY].roomObj.Exists(x => x.label == noun);
            inRoomElement = levelMap[player1.locX,player1.locY].roomElement.Exists(x => x.label == noun);
            onPlayer = player1.inventory.Exists(x => x.label == noun);
                
            if(inRoomObj == true)
            {
                switch(verb)
                {
                    case "EXAMINE":
                    Console.WriteLine(levelMap[player1.locX,player1.locY].roomObj.Find(x => x.label == noun).detail);
                    break;

                    case "GET":
                    player1.inventory.Add(levelMap[player1.locX,player1.locY].roomObj.Find(x => x.label == noun));
                    Console.WriteLine($"You take the {levelMap[player1.locX,player1.locY].roomObj.Find(x => x.label == noun).title}");
                    levelMap[player1.locX,player1.locY].roomObj.Remove(levelMap[player1.locX,player1.locY].roomObj.Find(x => x.label == noun));
                    break;

                    case "DROP":
                    Console.WriteLine("You don't have that.");
                    break;

                    case "USE":
                    
                    break;

                    default:
                    break;
                }
            }
            else if(inRoomElement == true)
            {
                switch(verb)
                {
                    case "EXAMINE":
                    Console.WriteLine(levelMap[player1.locX,player1.locY].roomElement.Find(x => x.label.ToUpper() == noun).detail);
                    break;

                    case "GET":
                    Console.WriteLine($"You can't get a {noun.ToLower()}.");
                    break;

                    case "DROP":
                    Console.WriteLine("You don't have that.");
                    break;

                    case "USE":
                    if(noun == "MIRROR")
                    {
                        List<string> winItems = new List<string>();
                        winItems.Add("COAT");
                        winItems.Add("SKATEBOARD");
                        winItems.Add("CIGARETTES");
                        // Steps through the player inventory using a Lambda function to check existence of each 'x' object in player.inventory
                        // This confirms that all winItems members exist in player.inventory
                        
                        bool gameOver = winItems.All(x => player1.inventory.Any(y => x == y.label));
                        // if(player1.inventory.Exists(x => x.label == "coat") && player1.inventory.Exists(x => x.label == "skateboard") && player1.inventory.Exists(x => x.label == "smokes"))
                        // {

                        // }
                        if(gameOver == true)
                        {
                            Console.WriteLine("The image in the mirror, at first wavery, now clearly resolves into the image of a laidback, hoopy frood \n" +  
                            "with a special sense of style and a complete lack of regard for convention.\n" +
                            "In the reflection, your image gives a lopsided grin, and in its hand there appears to be a car key. \n" +
                            "Looking down, you realize that you are now, in fact, holding a car key just as the image reflects. \n" +
                            "You now have the Car Key.");
                            player1.inventory.Add(new CarKey());
                        }
                        else
                        {
                            Console.WriteLine("The image is ambiguous and vague, as though you don't quite have everything.");
                        }
                    }
                    else if(noun == "CAR")
                    {
                        Console.WriteLine("That's not running right now.");
                    }
                    else
                    {
                        Console.WriteLine("Nothing to use.");
                    }
                    break;

                    default:
                    break;
                }
            }
            else if(onPlayer == true)
            {
                switch(verb)
                {
                    case "EXAMINE":
                    Console.WriteLine(player1.inventory.Find(x => x.label == noun).detail);
                    break;

                    case "GET":
                    Console.WriteLine("You are already in possession of that.");
                    break;

                    case "DROP":
                    levelMap[player1.locX,player1.locY].roomObj.Add(player1.inventory.Find(x => x.label == noun));
                    Console.WriteLine($"You drop the {levelMap[player1.locX,player1.locY].roomObj.Find(x => x.label == noun).title}");
                    player1.inventory.Remove(player1.inventory.Find(x => x.label == noun));
                    
                    break;

                    case "USE":
                    if(player1.inventory.Exists(x => x.label == noun))
                    {
                        Object keyItem = player1.inventory.Find(x => x.label == noun);
                     
                        if(levelMap[player1.locX,player1.locY].roomElement.Count > 0)
                        {
                            levelMap[player1.locX,player1.locY].roomElement[0].Use(keyItem);
                        }
                        else if (levelMap[player1.locX,player1.locY].roomElement.Count == 0)
                        {
                            Console.WriteLine("Nothing to use.");
                        }
                    }

                    break;

                    default:
                    break;

                }
            }
            else
            {
                Console.WriteLine($"I don't see a {noun.ToLower()} here.");
            }
        }     
    }
}