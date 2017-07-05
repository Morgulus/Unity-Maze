using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MazeCellEdge : MonoBehaviour {

    public MazeCell cell, otherCell;

    public MazeDirections directions;

    public void Initialize(MazeCell cell, MazeCell otherCell, MazeDirections directions)
    {
        this.cell = cell;
        this.otherCell = otherCell;
        this.directions = directions;
        cell.SetEdge(directions, this);
        transform.parent = cell.transform;
        transform.localPosition = Vector3.zero;
        transform.localRotation = directions.ToRotation();
    }
}
