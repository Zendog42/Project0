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
            Console.Clear();
            Console.WriteLine("Screwing a Marlboro purposefully into your lips, a quick wrist snap ignites a match from the 'Jerry's' matchbook.\n" +
            "A sense of purpose floods your psyche as you fling the oilcloth from the waiting car, which you can now see is a deep, \n" +
            "wine red color. Tucking yourself behind the wheel, you slide the seat back, adjust the sideview mirror, and twist the \n" + 
            "key in the ignition: The car sputters, then roars to life! \n" +
            "Cranking the gear level on the side of the steering column into 'Drive', you firmly press the accelerator.\n" +
            "The car lurches forward, then smoothly cruises out of the garage. Embarking upon your new adventure, you casually\n" +
            "flick the lit cigarette over your shoulder and out the window, where it happens to land in puddles of ancient oil stains\n" +
            "pooling on the dirt floor. As you turn onto the street and drive towards the edge of town, small columns of dark smoke\n" +
            "go unnoticed in the rearview mirror. You turn onto the highway towards a new life; in only minutes the small rural town\n" + 
            "disappears over the horizon, never to be seen again...");
            // Console.WriteLine($"Object type is: {keyItem.GetType()}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("...Larry awakens from a doze in his recliner. Perpetually bored, he glances out the window, where a thick column of\n" +
            "black smoke can be seen above the townscape. As he stares at the the growing blaze for a long moment, the sound of small\n" + 
            "explosions echo across the featureless gray sky. At this, Larry smirks acridly, puts his hands on his hips and utters a\n" + 
            "caustic chuckle. Stretching with an uninterested yawn, he returns to his recliner and turns on his television.\n" +
            "As re-runs of 'The David Letterman Show' flicker to life, he nods quietly to himself, imagining how life could have been\n" +
            "if he had married a former drama student...");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You have completed the game. Press 'Enter' key to close the window:");
            Console.ReadLine();
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
        "The Chevrolet Chevy II/Nova is a small automobile manufactured by Chevrolet, \n" +
        "and produced in five generations for the 1962 through 1979,\n" +
        "and 1985 through 1988 model years. ",
        typeof(CarKey))
        {

        }
    }
class Mirror : Puzzle
{
    public Mirror() : base(
    "MIRROR",
    "The Mirror of Truth.",
    "This is the _second-truthiest_ truth thing out there.",
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