using System;
using System.Linq;
using System.Collections.Generic;

public class Finder 
{
    
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
  
    private static bool CanReach(int mazeWidth, string maze, int startingPosition, int targetPosition)
    {
        Queue<int> positionQueue = new Queue<int>();
        bool[] discovered = new bool[maze.Count()];
      
        discovered[startingPosition] = true;
        positionQueue.Enqueue(startingPosition);
      
        while (positionQueue.Count > 0)
        {
            int currentPosition = positionQueue.Dequeue();
            if (currentPosition == targetPosition)
                return true;
          
            foreach (int adjacentPosition in getAdjacentPositions(mazeWidth, maze, currentPosition))
            {
                if (!discovered[adjacentPosition])
                {
                    discovered[adjacentPosition] = true;
                    positionQueue.Enqueue(adjacentPosition);
                }
            }
        }
      
        return false;
    }
      
  
    public static bool PathFinder(string maze) 
    {
        int mazeWidth = (int)Math.Sqrt(maze.Length);
        return CanReach(mazeWidth, maze.Replace("\n", string.Empty), 0, mazeWidth * mazeWidth - 1);
    }
}
