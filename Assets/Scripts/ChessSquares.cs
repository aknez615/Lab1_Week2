using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessSquares : MonoBehaviour
{
    private Color gizmoColor = Color.white;
    private Vector3 squareCenter = Vector3.zero;
    public float squareSize = 1f;

    private void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawCube(transform.position + squareCenter, new Vector3(squareSize, 0.01f, squareSize));
    }
}
