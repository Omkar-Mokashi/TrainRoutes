namespace TrainRoutes;

public class ShortestPathStrategy : IRouteStrategy
{
    /// <summary>
    /// Implement Dijkstra's Algorithm to find the shortest path
    /// </summary>
    /// <param name="graph"></param>
    /// <param name="startTown"></param>
    /// <param name="endTown"></param>
    /// <param name="maxStops"></param>
    /// <returns>The shortest distance from startTown to endTown</returns>
    public int CalculateRoute(Graph graph, string startTown, string endTown, int maxStops = int.MaxValue)
    {
        return 1; // Placeholder for the shortest distance
    }
}