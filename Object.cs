public class Object
{
    public string? label;       // Declare string as a nullable variable (?) to clear a compiler warning
    public string? title ;      // Declare string as a nullable variable (?) to clear a compiler warning
    public string? summary;     // Declare string as a nullable variable (?) to clear a compiler warning
    public string? detail;      // Declare string as a nullable variable (?) to clear a compiler warning
    public int weight;

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
        tcoat.label = "COAT";
        tcoat.title = "Trench Coat";
        tcoat.summary = "A faded yet reliable trench coat.";
        tcoat.detail = "The trench coat is simply-styled, a light tan in color, and frayed and worn in every seam. \nNotwithstanding the overwhelming odor of sweat and cigarette smoke emanating from it, it seems to be an excellent fit.";
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
        stick.label = "STICK";
        stick.title = "Old Stick";
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
        manual.label = "MANUAL";
        manual.title = "Owner's Manual";
        manual.summary = "An operating manual for a 1988 Chevy Nova";
        manual.publish_date = 1988;

        return manual;
    }
}

        // isTypeOf(Book) ? print(published_date) :''