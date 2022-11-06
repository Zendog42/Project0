
static class Setup
{
    public static Room[,] Rooms()
    {
        // Setup 2D array for level
        Room[,] levelMap = new Room[2,2];

        // Room a1
        levelMap[0,0] = new Room();
        levelMap[0,0].title = "Room a1";
        levelMap[0,0].detail = "This is room a1";
        levelMap[0,0].exits = new string[] {"North","South"};

        // Room a2
        levelMap[0,1] = new Room();
        levelMap[0,1].title = "Room a2";
        levelMap[0,1].detail = "This is room a2";
        levelMap[0,1].exits = new string[] {"East", "West"};

        return levelMap;
    }

    public static void Objects()
    {
        // Setup object array for level
        Object[] objects = {};
    }
    
    public static Player Player()
    {
        Player player = new Player();
        player.px = 0;
        player.py = 0;

        return player;
    }
}