using TrainRoutes;

class Program
{
    static void Main(string[] args)
    {
        var graph = FileReader.ReadGraphFromFile("Inputs\\Input.txt");

        var routeCalculator = new RouteCalculator(new DirectRouteStrategy());
        var distance1 = routeCalculator.GetRouteDistance(graph, "A", "B");
        var distance2 = routeCalculator.GetRouteDistance(graph, "A", "D");
        var distance3 = routeCalculator.GetRouteDistance(graph, "D", "C");
        var distance4 = routeCalculator.GetRouteDistance(graph, "A", "E");
        var distance5 = routeCalculator.GetRouteDistance(graph, "E", "B");
        var distance6 = routeCalculator.GetRouteDistance(graph, "B", "C");
        var distance7 = routeCalculator.GetRouteDistance(graph, "C", "D");
        
        routeCalculator = new RouteCalculator(new ShortestPathStrategy());
        
        var distance8 = routeCalculator.GetRouteDistance(graph, "A", "C");
        var distance9 = routeCalculator.GetRouteDistance(graph, "B", "B");
        Console.WriteLine($"Distance for A=>B=>C: {distance1 + distance6}");
        Console.WriteLine($"Distance for A=>D: {distance2}");
        Console.WriteLine($"Distance for A=>D=>C: {distance2 + distance3}");
        Console.WriteLine($"Distance for A=>E=>B=>C=>D: {distance4 + distance5 + distance6 + distance7}");
        Console.WriteLine($"Distance for A=>C: {distance8}");
        Console.WriteLine($"Distance for A=>C: {distance8}");
        Console.WriteLine($"Distance for B=>B: {distance9}");
    }
}