namespace TrainRoutes;

public class Route
{
    public string FromTown { get; }
    public string ToTown { get; }
    public int Distance { get; }

    public Route(string fromTown, string toTown, int distance)
    {
        FromTown = fromTown;
        ToTown = toTown;
        Distance = distance;
    }
}