

public class Element
{


        string label;
        string summary;
        string detail;
        bool solved;
        Type solution = typeof (Object);

    public Element(string label, string summary, string detail, Type solution)
    {

        this.label = label;
        this.summary = summary;
        this.detail = detail;
        this.solution = solution;
        this.solved = false;
    }

    public void Use(Object keyItem)
    {
        if(keyItem.GetType() == solution)
        {
            Console.WriteLine("Hey, you did a thing!");
            Console.WriteLine($"Object type is: {keyItem.GetType()}");
            solved = true;
        }
    }
        // string detail;
        // bool open = false;
        // bool locked = true;
}

class Door : Element
{
    public Door(string label, string summary, string detail, Type solution) : base(label, summary, detail, solution)
    {

    }

    public static Door Sdoor()
    {
        Door sDoor = new Door(
        "door",
        "a wooden door",
        "A detailed description of the door.",
        SKey.key().GetType());

        return sDoor; 

    }
}

// class Key : Object
// {
//     public static Key Skey()
//     {
//         Key sKey = new Key();
//         sKey.label = "KEY";
//         sKey.title = "Silver Key";
//         sKey.summary = "A slightly tarnished silver key.";

//         return sKey;
//     }
// }

            // Element door = new Element(
            // "Sturdy Door", 
            // "A sturdy wooden door.",
            // true
            // );