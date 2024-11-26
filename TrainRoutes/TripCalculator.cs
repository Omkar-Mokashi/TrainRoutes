namespace TrainRoutes;

public class TripCalculator
{
    private ITripStrategy _strategy;

    public TripCalculator(ITripStrategy strategy)
    {
        _strategy = strategy;
    }

    public int GetTripCount(Graph graph, string startTown, string endTown, int conditionValue = int.MaxValue)
    {
        return _strategy.GetTripCount(graph, startTown, endTown, conditionValue);
    }
}