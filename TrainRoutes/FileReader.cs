namespace TrainRoutes;

public class FileReader
{
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