using System;
using System.Linq;
using System.Collections.Generic;

public class Finder 
{
    const int INF = 100000; // Arbitrary Number
  
    private static bool isOnTopRow(int mazeWidth, int position) => position < mazeWidth;
    private static bool isOnBottomRow(int mazeWidth, int position) => position + mazeWidth >= mazeWidth * mazeWidth;
    private static bool isOnLeftColumn(int mazeWidth, int position) => position % mazeWidth == 0;
    private static bool isOnRightColumn(int mazeWidth, int position) => (position + 1) % mazeWidth == 0;
    
    private static List<int> getAdjacentPositions(int mazeWidth, string maze, int position)
    {
        List<int> adjacentPositions = new List<int>();
        
        if (!isOnLeftColumn(mazeWidth, position))
            adjacentPositions.Add(position - 1); 
        if (!isOnRightColumn(mazeWidth, position))
            adjacentPositions.Add(position + 1);
        if (!isOnBottomRow(mazeWidth, position))
            adjacentPositions.Add(position + mazeWidth);
        if (!isOnTopRow(mazeWidth, position))
            adjacentPositions.Add(position - mazeWidth);
      
        return adjacentPositions;
    }
  
    private static int MinimalDistance(int mazeWidth, string maze, int startingPosition, int targetPosition)
    {
        HashSet<int> positionSet = new HashSet<int>();
        int[] distance = new int[maze.Count()];
        
        for (int vertex = 0; vertex < maze.Count(); vertex++)  
        {
            distance[vertex] = INF;
            positionSet.Add(vertex);
        }
        distance[startingPosition] = 0;
      
        while (positionSet.Count > 0)
        { 
            Console.WriteLine(positionSet.Count);
            int currentPosition = positionSet.OrderBy((u) => distance[u]).First();
            
            positionSet.Remove(currentPosition);
          
            foreach (int adjacentPosition in getAdjacentPositions(mazeWidth, maze, currentPosition))
            {
                if (!positionSet.Contains(adjacentPosition))
                    continue;
                
                int alternativeDistance = distance[currentPosition] + Math.Abs(maze[currentPosition] - maze[adjacentPosition]);
                if (alternativeDistance < distance[adjacentPosition])
                    distance[adjacentPosition] = alternativeDistance;
            }
        }
      
        return distance[targetPosition];
    }
      
  
    public static int PathFinder(string maze) 
    {
        int mazeWidth = (int)Math.Sqrt(maze.Length);
        return MinimalDistance(mazeWidth, maze.Replace("\n", string.Empty), 0, mazeWidth * mazeWidth - 1);
    }
}
