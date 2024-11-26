using TrainRoutes;

class Program
{
    static void Main(string[] args)
    {
        var graph = FileReader.ReadGraphFromFile("Inputs\\Input.txt");

        // Test 1: Distance for A=>B=>C
        var routeCalculator = new RouteCalculator(new ShortestPathStrategy());
        var distance = routeCalculator.GetRouteDistance(graph, "A", "C");
        Console.WriteLine($"Distance for A=>B=>C: {distance}");
    }
}