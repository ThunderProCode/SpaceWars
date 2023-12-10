namespace SpaceWarsServices;

public record JoinGameResponse(string Token, Location StartingLocation, string GameState, int Heading, int BoardWidth, int BoardHeight, List<IPurchaseable> Shop);
public record Location(int X, int Y);
public record GameStateResponse(string GameState, IEnumerable<Location> PlayerLocations);
public record PlayerMessageResponse(string Type, string Message);
public record QueueActionRequest(string Type, string? Request);
public record QueueActionResponse(string Message);


public interface IPurchaseable
{
    int Cost { get; init; }
    string Name { get; }
    IEnumerable<string> PurchasePrerequisites { get; set; }
}

public class PurchaseableItem : IPurchaseable
{
    public int Cost { get; init; }
    public string Name { get; init; }
    public IEnumerable<string> PurchasePrerequisites { get; set; }
}
