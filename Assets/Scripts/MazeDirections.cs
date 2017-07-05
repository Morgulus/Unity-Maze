using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MazeDirections
{
    North,
    East,
    South,
    West
}
public static class MazeDirection
{
    public const int count = 4;

    public static MazeDirections RandomValue
    {
        get
        {
            return (MazeDirections)Random.Range(0, count);
        }
    }

    private static IntVector2[] vectors =
    {
        new IntVector2(0, 1),
        new IntVector2(1, 0),
        new IntVector2(0, -1),
        new IntVector2(-1, 0)
    };

    public static IntVector2 ToIntVector2(this MazeDirections direction)
    {
        return vectors[(int)direction];
    }

    private static MazeDirections[] opposites = 
    {
        MazeDirections.South,
        MazeDirections.West,
        MazeDirections.North,
        MazeDirections.East
    };

    public static MazeDirections GetOpposite(this MazeDirections direction)
    {
        return opposites[(int)direction];
    }

    private static Quaternion[] rotations = 
    {
        Quaternion.identity,
        Quaternion.Euler(0f, 90f, 0f),
        Quaternion.Euler(0f, 180f, 0f),
        Quaternion.Euler(0f, 270f, 0f)
    };

    public static Quaternion ToRotation(this MazeDirections direction)
    {
        return rotations[(int)direction];
    }

    
}
