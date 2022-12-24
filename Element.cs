public class Element
{
        public string label;
        public string summary;
        public string detail;
        bool solved;
        Type solution;

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
            Console.WriteLine("Congratulations, you finished the game!");
            Console.WriteLine($"Object type is: {keyItem.GetType()}");
            solved = true;
            Player.quit = true;
        }
    }
}
class Puzzle : Element
{
    public Puzzle(string label, string summary, string detail, Type solution) : base(label, summary, detail, solution)
    {

    }
}

class ChevyNova : Puzzle
    {
        public ChevyNova() : base(
        "CAR",
        "a 1988 Chevy Nova. It seems remarkable well-preserved and eminently functional.",
        "A detailed description of the car.",
        typeof(CarKey))
        {

        }
    }
class Mirror : Puzzle
{
    public Mirror() : base(
    "MIRROR",
    "The Mirror of Truth.",
    "A detailed description of the mirror.",
    typeof(CarKey))
    {

    }
}
class Door : Element
{
    public Door(string label, string summary, string detail, Type solution) : base(label, summary, detail, solution)
    {

    }

}
class RustyDoor : Door
    {
        public RustyDoor() : base(
        "DOOR",
        "a rusty door",
        "A detailed description of the rusty door.",
        typeof(RustyKey))
        {

        }
    }
    class SilverDoor : Door
    {
        public SilverDoor() : base(
        "DOOR",
        "a wooden door",
        "A detailed description of the door.",
        typeof(SilverKey))
        {

        }
    }