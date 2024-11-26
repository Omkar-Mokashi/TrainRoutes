namespace TrainRoutes;

public class RouteCalculator
{
    private IRouteStrategy _strategy;

    public RouteCalculator(IRouteStrategy strategy)
    {
        _strategy = strategy;
    }

    public int GetRouteDistance(Graph graph, string startTown, string endTown, int maxStops = int.MaxValue)
    {
        return _strategy.CalculateRoute(graph, startTown, endTown, maxStops);
    }
}