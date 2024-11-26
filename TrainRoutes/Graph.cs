namespace TrainRoutes;

public class Graph
{
    private Dictionary<string, List<Route>> routes = new Dictionary<string, List<Route>>();

    // Add route between towns
    public void AddRoute(Route route)
    {
        if (!routes.ContainsKey(route.FromTown))
        {
            routes[route.FromTown] = new List<Route>();
        }
        routes[route.FromTown].Add(route);
    }

    // Get all routes from a town
    public List<Route> GetRoutesFromTown(string town)
    {
        return routes.ContainsKey(town) ? routes[town] : new List<Route>();
    }
}