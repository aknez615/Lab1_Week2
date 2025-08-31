using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenPiece : MonoBehaviour
{
    public float squareSize = 1.5f;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;

        Vector3 queenPos = transform.position;

        for (int i = -1; i <=1; i++)
        {
            if (i == 0) continue;

            Gizmos.DrawLine(queenPos, queenPos + new Vector3(i * squareSize, 0, 0));

            Gizmos.DrawLine(queenPos, queenPos + new Vector3(0, 0, i * squareSize));
        }

        for (int i = -1; i <= 1; i++)
        {
            if (i == 0) continue;

            Gizmos.DrawLine(queenPos, queenPos + new Vector3(i * squareSize, 0, i * squareSize));

            Gizmos.DrawLine(queenPos, queenPos + new Vector3(-i * squareSize, 0, i * squareSize));
        }
    }
}
