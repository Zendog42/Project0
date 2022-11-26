public class Room
{
    public string? title {get; set;}        // Declare string as a nullable variable (?) to clear a compiler warning
    public string? detail {get; set;}       // Declare string as a nullable variable (?) to clear a compiler warning
    public string[]? exits {get; set;}      // Declare string array as a nullable variable (?) to clear a compiler warning
    public List<Object> roomObj = new List<Object>();
    public List<Element> roomElement = new List<Element>();
}