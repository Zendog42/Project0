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
            Console.WriteLine("Screwing a Marlboro purposefully into your lips, a quick wrist snap ignites a match from the 'Jerry's' matchbook./n" +
            "A new sense of purpose floods your psyche as you fling the oilcloth away from the waiting car, which you can now see is a deep, wine red color.\n" +
            "Tucking yourself behind the wheel, you slide the seat back, adjust the sideview mirror, and twist the key in the ignition.\n" +
            "The car sputters, then roars to life! Cranking the gear level on the side of the steering column into 'Drive', you firmly press the accelerator.\n" +
            "The car lurches forward, then smoothly cruises out of the garage. As you embark upon your new adventure, you casually flick the lit cigarette \n" +
            "over your shoulder and out the window, where it happens to land in a puddle of ancient oil stains pooling on the dirt floor.\n" +
            "As you pull out onto the street and turn towards the edge of town, a small column of smoke can be seen in the rearview mirror, unnoticed by you. \n" +
            "You turn on to the highway out of town, and in only minutes, the view of the small rural town disappears over the horizon, never to be seen again...");
            // Console.WriteLine($"Object type is: {keyItem.GetType()}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("...Larry awakes from a doze in his recliner. Perpetually bored, he glances out the window, \n" +
            "where a thick column of black smoke can be seen across the townscape.\n" +
            "Staring at the the growing blaze for a long moment, the sound of small explosions echo across the featureless rural sky.\n" +
            "At this, Larry smirks acridly, puts his hands on his hips and chuckles sardonically. With an uninterested yawn, \n" + 
            "he returns to his recliner, and turns on his television.\n" +
            "As re-runs of 'The David Letterman Show' flicker to life, he nods quietly to himself, imagining how his life could have been \n" +
            "if he had married a former drama student.");
            Console.WriteLine("Press any key to close the window:");
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