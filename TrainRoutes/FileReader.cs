namespace TrainRoutes;

public class FileReader
{
    /// <summary>
    /// The file reader function for our specific file format
    /// </summary>
    /// <param name="filePath">Input file path location in the project</param>
    /// <returns>The graph structure as provided by the input file</returns>
    public static Graph ReadGraphFromFile(string filePath)
    {
        var graph = new Graph();
        var lines = File.ReadAllLines(filePath);

        foreach (var line in lines)
        {
            var parts = line.Split(',');
            var fromTown = parts[0].Trim();
            var toTown = parts[1].Trim();
            var distance = int.Parse(parts[2].Trim());

            var route = new Route(fromTown, toTown, distance);
            graph.AddRoute(route);
        }

        return graph;
    }
}