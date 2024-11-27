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

Therefore as we different algorithms for different cases for similar set of case I am using here Strategy Design Pattern

Non-functional Requirements:
1. We want optimal solution
2. Follow proper design patters
3. Test coverage

- Optimal Solution: Dijkstra's Algorithm for finding the shortest path
- Desgin Patterns: Strategy designn pattern as we have different algorithms for different cases
- Test Coverage: The major functional public methods have test coverage + all the specific test cases provider have been solved.
