    // DEFINITIONS FOR BASE OBJECT CLASS //
public class Object
{
    public string label;       
    public string title ;      
    public string summary;     
    public string detail;      
    
    public int weight;

    public bool interactive;

// Object Constructor (defines requirements for all inherited classes)
    public Object(string label, string title, string summary, string detail)
    {
        this.label = label;
        this.title = title;
        this.summary = summary;
        this.detail = detail;
    }
}


    // DEFINITIONS FOR BASE "WEAPON" OBJECTS //
class Weapon : Object
{
    public int damage;

    public Weapon(string label, string title, string summary, string detail, int damage) : base(label, title, summary, detail)
    {

    }

    // public static Weapon Stick()
    // {
    //     stick.interactive = true;
    //     stick.label = "STICK";
    //     stick.title = "Old Stick";
    //     stick.summary = "It's brown and sticky.";
    //     stick.weight = 1;
    // }
}

class Stick : Weapon
{
    public Stick() : base("STICK","Old Stick","It's brown and sticky.","It looks old, yet sturdy enough to defend yourself with it.", 1)
    {

    }
}



    // DEFINITIONS FOR BASE "ARMOR" OBJECTS //
class Armor : Object
{
    public int resilience;

    public Armor(string label, string title, string summary, string detail, int resilience) : base(label, title, summary, detail)
    {
        // tcoat.label = "COAT";
        // tcoat.title = "Trench Coat";
        // tcoat.summary = "A faded yet reliable trench coat.";
        // tcoat.detail = "The trench coat is simply-styled, a light tan in color, and frayed and worn in every seam. \nNotwithstanding the overwhelming odor of sweat and cigarette smoke emanating from it, it seems to be an excellent fit.";
        // tcoat.defense = 1;
        // tcoat.weight = 1;
    }

}

// TRENCH COAT
class TrenchCoat : Armor
{
    public TrenchCoat() : base("COAT","Trench Coat","A faded yet reliable trench coat.","The trench coat is simply-styled, a light tan in color, and frayed and worn in every seam. \nNotwithstanding the overwhelming odor of sweat and cigarette smoke emanating from it, it seems to be an excellent fit.",1)
    {

    }
}

    // DEFINITIONS FOR BASE "BOOK" OBJECTS //
class Book : Object
{
    public int publish_date;

    public Book(string label, string title, string summary, string detail, int publish_date) : base(label, title, summary, detail)
    {
    }
}

// OWNER'S MANUAL
class OwnerManual : Book
{
    public OwnerManual() : base("MANUAL","Chevy Nova Owner's Manual","An operating manual for a 1988 Chevy Nova","It has an illustration of the 1988 Checy Nova on the cover. Perhaps it has some helpful information held within?",1988)
    {
    }
}

    // DEFINITIONS FOR BASE "KEY" OBJECTS //
class Key : Object 
{
    string material;
    public Key(string label, string title, string summary, string detail, string material) : base(label, title, summary, detail)
    {
        this.material = material;
    }
}


// TOURMALINE KEY
class TourmalineKey : Key
{

    public TourmalineKey() : base("TKEY", "Tourmaline Key", "A fancy key made of tourmaline", "Seriously, it's the fanciest key you've ever seen, and it's made of tourmaline.","tourmaline")
    {
        // no code function
    }
    public void Magic() {
        // does magic
        Console.WriteLine("Magic done!");
    }
}

// SILVER KEY
class SilverKey : Key
{
    public SilverKey() : base("SKEY", "Silver Key", "A slightly tarnished silver key", "You've seen cooler silver keys, but this one is a pretty good example of the item.","silver")
    {

    }

    public void Test()
    {
        // do stuff
    }
}

// BRONZE KEY
class BronzeKey : Key
{
    public BronzeKey() : base("BKEY", "Bronze Key", "A rough worn bronze key", "Not sure why someone made a key out of bronze, but you hold the proof of their dubious efforts.","bronze")
    {
    }

    public void Test()
    {
        // do stuff
    }
}

        // isTypeOf(Book) ? print(published_date) :''