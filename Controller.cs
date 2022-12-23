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
            bool inRoom = false;
            bool onPlayer = false;

            inRoom = levelMap[player1.locX,player1.locY].roomObj.Exists(x => x.label == noun);
            onPlayer = player1.inventory.Exists(x => x.label == noun);
                
            if(inRoom == true)
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

                        // if (player1.inventory.Find(x => x.label == noun).GetType() is tKey)
                        // {
                        //     tKey tkeyItem = (tKey) player1.inventory.Find(x => x.label == noun);
                        //     tkeyItem.magic();
                        // }
                     
                        if(levelMap[player1.locX,player1.locY].roomElement.Count > 0)
                        {
                            levelMap[player1.locX,player1.locY].roomElement[0].Use(keyItem);
                        }
                    }

                    break;

                    default:
                    break;

                }
            }
        }     
    }
}