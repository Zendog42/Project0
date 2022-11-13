class Object
{
    public string? title {get; set;}        // Declare string as a nullable variable (?) to clear a compiler warning
    public string? summary {get; set;}      // Declare string as a nullable variable (?) to clear a compiler warning
    public string? detail {get; set;}       // Declare string as a nullable variable (?) to clear a compiler warning
    public int weight {get; set;}

    // public bool mutable{get; set;}
    // public int locX {get; set;}
    // public int locY {get; set;}
}

class Armor : Object
{
    public int defense;

    public static Armor TrenchCoat()
    {
        Armor tcoat = new Armor();
        tcoat.title = "Trench Coat";
        tcoat.defense = 1;
        tcoat.weight = 1;

        return tcoat;

    }

}

class Weapon : Object
{
    public int damage;

    public static Weapon Stick()
    {
        Weapon stick = new Weapon();
        stick.title = "A Stick";
        stick.summary = "It's brown and sticky.";
        stick.weight = 1;

        return stick;
    }
}

class Book : Object
{
    public int publish_date;

    public static Book Manual()
    {
        Book manual = new Book();
        manual.title = "Owner's Manual";
        manual.summary = "An operating manual for a 1988 Chevy Nova";
        manual.publish_date = 1988;

        return manual;
    }
}

        // isTypeOf(Book) ? print(published_date) :''