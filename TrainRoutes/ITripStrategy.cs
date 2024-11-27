namespace TrainRoutes;

public interface ITripStrategy
{
    int GetTripCount(Graph graph, string startTown, string endTown, CountCondition countCondition, int conditionValue = int.MaxValue);
}