using System;
using System.Linq;
using System.Collections.Generic;

public class Finder 
{
    const int INF = -1;
  
    private static bool isOnTopRow(int mazeWidth, int position) => position < mazeWidth;
    private static bool isOnBottomRow(int mazeWidth, int position) => position + mazeWidth >= mazeWidth * mazeWidth;
    private static bool isOnLeftColumn(int mazeWidth, int position) => position % mazeWidth == 0;
    private static bool isOnRightColumn(int mazeWidth, int position) => (position + 1) % mazeWidth == 0;
    
    private static List<int> getAdjacentPositions(int mazeWidth, string maze, int position)
    {
        List<int> adjacentPositions = new List<int>();
        
        if (!isOnLeftColumn(mazeWidth, position) && (maze[position - 1] != 'W'))
            adjacentPositions.Add(position - 1); 
        if (!isOnRightColumn(mazeWidth, position) && (maze[position + 1] != 'W'))
            adjacentPositions.Add(position + 1);
        if (!isOnBottomRow(mazeWidth, position) && (maze[position + mazeWidth] != 'W'))
            adjacentPositions.Add(position + mazeWidth);
        if (!isOnTopRow(mazeWidth, position) && (maze[position - mazeWidth] != 'W'))
            adjacentPositions.Add(position - mazeWidth);
      
        return adjacentPositions;
    }
  
    private static int MinimalDistance(int mazeWidth, string maze, int startingPosition, int targetPosition)
    {
        Queue<int> positionQueue = new Queue<int>();
        int[] distance = new int[maze.Count()];
        
        Array.Fill(distance, INF);
        
        distance[startingPosition] = 0;
        positionQueue.Enqueue(startingPosition);
      
        while (positionQueue.Count > 0)
        {
            int currentPosition = positionQueue.Dequeue();
            if (currentPosition == targetPosition)
                return distance[currentPosition];
          
            foreach (int adjacentPosition in getAdjacentPositions(mazeWidth, maze, currentPosition))
            {
                if (distance[adjacentPosition] == INF)
                {
                    distance[adjacentPosition] = distance[currentPosition] + 1;
                    positionQueue.Enqueue(adjacentPosition);
                }
            }
        }
      
        return INF;
    }
      
  
    public static int PathFinder(string maze) 
    {
        int mazeWidth = (int)Math.Sqrt(maze.Length);
        return MinimalDistance(mazeWidth, maze.Replace("\n", string.Empty), 0, mazeWidth * mazeWidth - 1);
    }
}
