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

    // DEFINITIONS FOR BASE "WIN" OBJECTS //
class Skateboard : Object
{
    public Skateboard(int weight) : base(
        "SKATEBOARD",
        "Well-Used Skateboard",
        "This skateboard is really beat up.",
        "The dilapidated skateboard is bowed from supporting angsty teenagers for hundreds of miles, \n" +
        "the edges battered and splintered from dozens of skateboard trick attempts (both successfull and not).")
    {
        this.weight = weight;
    }
}

class Cigarettes : Object
{
    public Cigarettes(int weight) : base(
        "CIGARETTES",
        "Pack of Marlboro 'Reds'",
        "Twenty nails to pound into your coffin.",
        "A slightly crumpled, half-expended pack of cigarettes forms a dull wad in your fist.\n" +
        "tucked inside the cellophane wrapper is a small book of matches bearing the logo `Jerry's Super Value`.")
    {
        this.weight = weight;
    }
}

    // DEFINITIONS FOR BASE "WEAPON" OBJECTS //
class Weapon : Object
{
    public int damage;

    public Weapon(string label, string title, string summary, string detail, int damage) : base(label, title, summary, detail)
    {
        this.damage = damage;
    }
}

class Stick : Weapon
{
    public Stick() : base(
    /*label*/   "STICK",
    /*title*/   "Old Stick",
    /*summary*/ "It's brown and sticky.",
    /*detail*/  "It looks old, yet sturdy enough to defend yourself with it.",
    /*damage*/ 1
     )
    {

    }

}

    // DEFINITIONS FOR BASE "ARMOR" OBJECTS //
class Armor : Object
{
    public int resilience;

    public Armor(string label, string title, string summary, string detail, int resilience) : base(label, title, summary, detail)
    {

    }

}

// TRENCH COAT
class TrenchCoat : Armor
{
    string label = "COAT";
    string title = "Trench Coat";
    string summary = "A faded yet reliable trench coat.";
    string detail = "The trench coat is simply-styled, a light tan in color, and frayed and worn in every seam. \nNotwithstanding the overwhelming odor of sweat and cigarette smoke emanating from it, it seems to be an excellent fit.";
    int resilience = 1;
    public TrenchCoat() : base("COAT","Trench Coat","A faded yet reliable trench coat.","The trench coat is simply-styled, a light tan in color, and frayed and worn in every seam. \nNotwithstanding the overwhelming odor of sweat and cigarette smoke emanating from it, it seems to be an excellent fit.",1)
    {
        label = "COAT";

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
    public OwnerManual() : base("MANUAL","Chevy Nova Owner's Manual","An operating manual for a 1988 Chevy Nova","It has an illustration of the 1988 Chevy Nova on the cover. Perhaps it has some helpful information held within?",1988)
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

// CAR KEY
class CarKey : Key
{

    public CarKey() : base("KEY", "Car Key", "A key of unknown origin.", "It seems as though it could be used in an automobile.","metal")
    {
        // no code function
    }
    public void Magic() {
        // does magic
        Console.WriteLine("Magic done!");
    }
}

// GENERIC KEY
class RustyKey : Key
{

    public RustyKey() : base("RKEY", "Rusty Key", "A key; it's super rusty.", "Seriously, it's the rustiest key you've ever seen.","rust")
    {
        // no code function
    }
    public void Magic() {
        // does magic
        Console.WriteLine("Magic done!");
    }
}

// TOURMALINE KEY
class TourmalineKey : Key
{

    public TourmalineKey() : base("TKEY", "Tourmaline Key", "A fancy key made of tourmaline", "Seriously, it's the fanciest key you've ever seen, and it's made of tourmaline.","tourmaline")
    {
        // no code function
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

        // isTypeOf(Book) ? print(published_date) :'' -- cwoodword