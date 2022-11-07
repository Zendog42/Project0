using System;
using System.Collections.Generic;   // List<> is located in the Systems.Collection.Generic namespace

public class CmdHandler
{
    private List<Verb> verbs = new List<Verb>();
    // private List<Noun> nouns = new List<Noun>();

    public void Input(string cmd)
    {
        if(cmd == "N" || cmd =="E" || cmd == "W" || cmd == "S")
        {
            // Console.WriteLine("You would normally have moved here.");
            // PlayerMove();
        }

        // else
        // {
        //     Console.WriteLine("That's not a command I recognize.");
        //     return "";
        // }
    }

    // public void PlayerMove()
    // {
    //      cmd = "N" then playerpx++.
    // }

    
}