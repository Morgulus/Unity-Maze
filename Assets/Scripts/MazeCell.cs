using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeCell : MonoBehaviour {

    public IntVector2 coordinates;

    private MazeCellEdge[] edges = new MazeCellEdge[MazeDirection.count];
    private int initializedEdgeCount;

    public void SetEdge(MazeDirections directions, MazeCellEdge edge)
    {
        edges[(int)directions] = edge;
        initializedEdgeCount += 1;
    }
    public MazeCellEdge GetEdge(MazeDirections directions)
    {
        return edges[(int)directions];
    }
    public bool IsFullyInitialized
    {
        get
        {
            return initializedEdgeCount == MazeDirection.count;
        }
    }

    public MazeDirections RandomUninitializedDirection
    {
        get
        {
            int skips = Random.Range(0, MazeDirection.count - initializedEdgeCount);
            for (int i = 0; i < MazeDirection.count; i++)
            {
                if (edges[i] == null)
                {
                    if (skips == 0)
                    {
                        return (MazeDirections)i;
                    }
                    skips -= 1;
                }
            }
            throw new System.InvalidOperationException("MazeCell has no uninitialized directions left.");
        }
    }
}
