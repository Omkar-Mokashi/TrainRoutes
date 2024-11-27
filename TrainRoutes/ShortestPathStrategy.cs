namespace TrainRoutes;

public class ShortestPathStrategy : IRouteStrategy
{
    public int CalculateRoute2(Graph graph, string startTown, string endTown, int maxStops = int.MaxValue)
    {
        // Dictionary to store the shortest distance to each town
        var distances = new Dictionary<string, int>();
        
        // Priority queue (min-heap) to store towns with their current shortest distance
        var priorityQueue = new PriorityQueue<string, int>();

        // Initialize distances
        foreach (var town in graph.GetAllTowns())
        {
            distances[town] = int.MaxValue;  // Set all distances to infinity
        }
        
        // Distance to the start town is 0
        distances[startTown] = 0;
        
        // Add the start town to the priority queue with distance 0
        priorityQueue.Enqueue(startTown, 0);

        // Track the shortest path
        var previousTowns = new Dictionary<string, string>();

        // Track the number of stops taken to reach each town
        var stops = new Dictionary<string, int>();
        stops[startTown] = 0; // Start town has 0 stops

        // Traverse the graph using Dijkstra's algorithm
        while (priorityQueue.Count > 0)
        {
            // Get the town with the smallest distance
            var currentTown = priorityQueue.Dequeue();

            // Case 1: If we are done and endTown is reached (non-circular)
            if (currentTown == endTown && startTown != endTown)
            {
                return distances[currentTown];  // Shortest path distance
            }

            // Case 2: If we are back at the start town (circular route) and took at least one stop
            if (currentTown == startTown && stops[currentTown] > 0 && startTown == endTown)
            {
                return distances[currentTown];  // Shortest round trip distance
            }

            // Get all the neighboring towns and their distances
            foreach (var route in graph.GetRoutesFromTown(currentTown))
            {
                var neighbor = route.ToTown;
                var newDistance = distances[currentTown] + route.Distance;
                var newStops = stops[currentTown] + 1;

                // If we exceed the maximum stops limit, skip the current path
                if (newStops > maxStops)
                {
                    continue;
                }

                // If a shorter path to the neighbor is found, update it
                if (newDistance < distances[neighbor])
                {
                    distances[neighbor] = newDistance;
                    previousTowns[neighbor] = currentTown;
                    stops[neighbor] = newStops;
                    priorityQueue.Enqueue(neighbor, newDistance);
                }
            }
        }

        // If no valid path is found, return -1 to indicate no valid path
        return -1;
    }
    
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
        // Dictionary to store the shortest distance to each town
        var distances = new Dictionary<string, int>();
        
        // Priority queue (min-heap) to store towns with their current shortest distance
        var priorityQueue = new PriorityQueue<string, int>();

        // Initialize distances
        foreach (var town in graph.GetAllTowns())
        {
            distances[town] = int.MaxValue;  // Set all distances to infinity
        }
        
        // Distance to the start town is 0
        distances[startTown] = 0;
        
        // Add the start town to the priority queue with distance 0
        priorityQueue.Enqueue(startTown, 0);

        // Track the shortest path
        var previousTowns = new Dictionary<string, string>();

        while (priorityQueue.Count > 0)
        {
            // Get the town with the smallest distance
            var currentTown = priorityQueue.Dequeue();

            // If we reached the destination, stop
            if (currentTown == endTown && previousTowns.Count != 0)
            {
                break;
            }

            // Get all the neighboring towns and their distances
            foreach (var route in graph.GetRoutesFromTown(currentTown))
            {
                var neighbor = route.ToTown;
                var newDistance = distances[currentTown] + route.Distance;

                // If a shorter path to the neighbor is found, update it
                if (newDistance < distances[neighbor] || distances[neighbor] == 0)
                {
                    distances[neighbor] = newDistance;
                    previousTowns[neighbor] = currentTown;
                    priorityQueue.Enqueue(neighbor, newDistance);
                }
            }
        }

        // If no path is found to the end town, return -1 or some indication that no path exists
        if (distances[endTown] == int.MaxValue)
        {
            return -1;
        }

        // Return the shortest distance to the end town
        return distances[endTown];
    }
}