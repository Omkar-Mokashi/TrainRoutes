namespace TrainRoutes.Strategies.RouteStrategy;

public interface IRouteStrategy
{
    int CalculateRoute(Graph graph, string startTown, string endTown, int maxStops = int.MaxValue);
}