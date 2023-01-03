static class Setup
{
    public static Room[,] Rooms()
    {
        // Setup 2D array for level
        Room[,] levelMap = new Room[3,3];

        // Overgrown Path
        levelMap[0,0] = new Room();
        levelMap[0,0].title = "Overgrown Path";
        levelMap[0,0].detail = "An overgrown path wends its way north and south.\n" +
                                "Rain-carved grooves travel down a long, sloping hill, opening up into a\n" +
                                "small field thickly choked with tall blades of razor-sharp grass and weeds.\n" +
                                "The way forward is impassable for any but the most intrepid or the patently foolish.\n";
        levelMap[0,0].exits = new string[] {"South"};
        levelMap[0,0].roomObj.Add(new Skateboard(10));
    
        // Mysterious Culvert
        levelMap[0,1] = new Room();
        levelMap[0,1].title = "Mysterious Culvert";
        levelMap[0,1].detail = "Travelling west from the thorny tangle of blackberry vines, the\n" +
                                "underbrush thins out, revealing the bank of a small creek.\n" +
                                "Though the creek itself appears innocuous, it flows into a pool at the foreboding\n" +
                                "entrance of a cavernous tunnel. The quietly trickling water suddenly exudes a\n" +
                                "sinister feeling into the air as it disappears into the inky depths of the culvert.\n";
        levelMap[0,1].exits = new string[] {"East"};

        // Briar Patch
        levelMap[0,2] = new Room();
        levelMap[0,2].title = "Briar Patch";
        levelMap[0,2].detail  = "Fibrous green ropes of woody thorns weave themselves into an intimidating nest of\n" +
                                "briars, decorated randomly by small, sweet clusters of ripe blackberries.\n" +
                                "The odor of the sweet fruit in contrast to the visual horror of contending with\n" +
                                "the ferocious tangles of flesh-shredding vines leaves a queasy yet wistful yearning in the stomach.\n" +
                                "The only visible path forward runs westward, parallel to the thicket.";
        levelMap[0,2].exits = new string[] {"West","South"};
        
        // Ravine
        levelMap[1,0] = new Room();
        levelMap[1,0].title = "Ravine";
        levelMap[1,0].detail = "A massive cleft in the landscape forms a lush ravine,\n" +
                                "densely populated by a variety of trees and saplings, tick-bearing underbrush\n" +
                                "of many varieties, and a slowly rotting carpet of dead branches and dry leaves.\n" +
                                "A lonely path twists northward, and to the south the ground rises back towards the house.\n";
        levelMap[1,0].exits = new string[] {"North","South"};
        
        // Garage
        levelMap[1,1] = new Room();
        levelMap[1,1].title = "Garage";
        levelMap[1,1].detail = "Four rickety wooden walls prop up the sadly sagging roof of a musty, barn-style garage.\n" +
                                "The wooden panels have been pierced countless times by rusty implements and fasteners.\n"+
                                "Daylight streams in, the dusty beams spraying mottled patterns of light upon the earthen floor.\n" +
                                "Against the wall, under a rotting oilcoth tarpaulin, is a remarkably well-maintained vintage car.\n" + 
                                "There is also a mirror here.";
        levelMap[1,1].exits = new string[] {"South"};
        levelMap[1,1].roomObj.Add(new TrenchCoat());
        // levelMap[1,1].roomObj.Add(new Skateboard(10));
        // levelMap[1,1].roomObj.Add(new Cigarettes(1));
        // levelMap[1,1].roomObj.Add(new Stick());
        // levelMap[1,1].roomObj.Add(new OwnerManual());
        levelMap[1,1].roomElement.Add(new ChevyNova());
        levelMap[1,1].roomElement.Add(new Mirror());

    
        // Firepit
        levelMap[1,2] = new Room();
        levelMap[1,2].title= "Firepit";
        levelMap[1,2].detail = "A small grassy clearing is occupied solely by a haphazardly-constructed brick fireplace.\n" +
                                "The anamolous appearance of such a fixture in the middle of nowhere lends a surreal quality\n" +
                                "to the weathered concrete and clay construct. A small pile of ashes rests within the embrace \n"+
                                "of the poorly-conceived oddity; stirring the ashes reveals the charred remnants of Campbell's soup cans, \n" +
                                "melted Coke bottles, and wads of aluminum foil with bits of dry yet greasy chicken still clinging to them.\n" +
                                "Further north, the landscape is obscured by a strangling wall of sweet-smelling briars.";
        levelMap[1,2].exits = new string[] {"North","South"};
        // levelMap[1,2].roomObj.Add(new CarKey());
        levelMap[1,2].roomObj.Add(new Cigarettes(1));

        // Back Door
        levelMap[2,0] = new Room();
        levelMap[2,0].title = "Back Door";
        levelMap[2,0].detail = "A two-story white house stands here; large screens enclose an exposed room, and french doors are visible\n" +
                                "leading further into the house. At the far corner, a small back door breaks the uniformity of\n" +
                                "rotting paint and ancient wood. The door is tightly locked, and there is currently no discernable\n" + 
                                "method to open it. North of here, a densely wooded ravine beckons.\n";
        levelMap[2,0].exits = new string[] {"North","East"};

        // Driveway
        levelMap[2,1] = new Room();
        levelMap[2,1].title = "Driveway";
        levelMap[2,1].detail = "A wide driveway wanders away from the double sliding barn doors of the rickety garage.\n" +
                                "Dusty hardpan peeks up here and there through the patchy covering of whitish pea-gravel.\n"+
                                "Tufts of grass struggle to pull enough moisture from the impacted dirt and the wafting\n" +
                                "smell of rotting vegetation, cut grass, school lunches, manure, and a mediocre future\n" +
                                "alternatively entice and repulse the senses.\n";
        levelMap[2,1].exits=new string[] {"North","West","East"};

        // Sloping Hill
        levelMap[2,2] = new Room();
        levelMap[2,2].title = "Sloping Hill";
        levelMap[2,2].detail = "A low, sloping hill slopes off to the distance.\n" +
                                "The featureless landscape stretching in every direction seems to absorb interest\n" +
                                "in exactly the same way acoustic foam absorbs sound. A few dozen yards away to the north\n" +
                                "there seems to be a small brick firepit, standing roughly knee-high.\n";
        levelMap[2,2].exits = new string[] {"North","West"};

        return levelMap;
    }
  
    public static Player Player()
    {
        Player player = new Player();
        player.locX = 1;
        player.locY = 1;

        return player;
    }
}