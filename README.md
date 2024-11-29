Functional Requirements:
1. Find distance for a route
2. Find number trip in between nodes

These 2 also have 2 different methods of finding the values
1. Find distance for a route
   1. Find the shortest distance
   2. Find the direct distance
3. Find number of trips in between nodes
   1. Number of trips based on number of stops
   2. Number of trips based on distance

Therefore, as we are using different algorithms for different cases for similar set of case I am using here Strategy Design Pattern

Non-functional Requirements:
1. We want optimal solution
2. Follow proper design patters
3. Test coverage

- Optimal Solution: Dijkstra's Algorithm for finding the shortest path, used DFS for finding the number of trips.
- Design Patterns: Strategy design pattern as we have different algorithms for different cases
- Test Coverage: The major functional public methods have test coverage + all the specific test cases provider have been solved.

The high level flow of the program:

![TrainRoutes](https://github.com/user-attachments/assets/f6fac720-748b-45fa-a19c-b61d1c5a6c3f)

We have utilized the strategy pattern 2 times for 2 different use case:

1.Route Strategy

![ClassDiagramRouteStrategy](https://github.com/user-attachments/assets/613f1d4d-0e1f-4b03-b7d0-a398a3a3f650)

2. Trip Strategy

![ClassDiagramTripStrategy](https://github.com/user-attachments/assets/4b410be5-39d8-489c-9a09-062559066c27)
