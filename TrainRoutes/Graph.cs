namespace TrainRoutes;

public class Graph
{
    private Dictionary<string, List<Route>> routes = new Dictionary<string, List<Route>>();

    /// <summary>
    /// Add route between towns
    /// </summary>
    /// <param name="route"></param>
    public void AddRoute(Route route)
    {
        if (!routes.ContainsKey(route.FromTown))
        {
            routes[route.FromTown] = new List<Route>();
        }
        routes[route.FromTown].Add(route);
    }

    /// <summary>
    /// Get all routes from a town as specified in the input file
    /// </summary>
    /// <param name="town"></param>
    /// <returns></returns>
    public List<Route> GetRoutesFromTown(string town)
    {
        return routes.ContainsKey(town) ? routes[town] : new List<Route>();
    }
    
    /// <summary>
    /// Get all existing towns according to the input specified
    /// </summary>
    /// <returns></returns>
    public IEnumerable<string> GetAllTowns()
    {
        return routes.Keys;
    }
}