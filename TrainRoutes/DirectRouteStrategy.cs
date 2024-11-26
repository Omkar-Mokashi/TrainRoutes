namespace TrainRoutes;

public class DirectRouteStrategy : IRouteStrategy
{
    public int CalculateRoute(Graph graph, string startTown, string endTown, int maxStops = Int32.MaxValue)
    {
        var routes = graph.GetRoutesFromTown(startTown).FirstOrDefault(x => x.ToTown == endTown);
        return routes?.Distance ?? throw new ArgumentException($"There is no direct route from {startTown} to {endTown}");
    }
}