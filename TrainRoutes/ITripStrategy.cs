namespace TrainRoutes;

public interface ITripStrategy
{
    int GetTripCount(Graph graph, string startTown, string endTown, int conditionValue = int.MaxValue);
}