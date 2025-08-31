using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class KnightPiece : MonoBehaviour
{
    public float squareSize = 1f;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;

        Vector3 knightPos = transform.position;

        List<Vector3> linePoints = new List<Vector3>();

        Vector2Int[] knightMoves = new Vector2Int[]
        {
            new Vector2Int(2, 1),
            new Vector2Int(1, 2),
            new Vector2Int(-1, 2),
            new Vector2Int(-2, 1),
            new Vector2Int(-2, -1),
            new Vector2Int(-1, -2),
            new Vector2Int(1, -2),
            new Vector2Int(2, -1)
        };

        foreach (var move in knightMoves)
        {
            Vector3 firstStep = Vector3.zero;
            Vector3 secondStep = Vector3.zero;

            if (Mathf.Abs(move.x) == 2)
            {
                firstStep = new Vector3(move.x / 2f * squareSize, 0f, 0f);
                secondStep = new Vector3(0f, 0f, move.y * squareSize);
            }

            else
            {
                firstStep = new Vector3(0f, 0f, move.y / 2f * squareSize);
                secondStep = new Vector3(move.x * squareSize, 0f, 0f);
            }

            Vector3 midPoint = knightPos + firstStep;
            Vector3 endPoint = midPoint + secondStep;

            linePoints.Add(knightPos);
            linePoints.Add(midPoint);

            linePoints.Add(midPoint);
            linePoints.Add(endPoint);
        }

        using (var nativePoints = new NativeArray<Vector3>(linePoints.ToArray(), Allocator.Temp))
        {
            Gizmos.DrawLineList(nativePoints);
        }
    }
}
