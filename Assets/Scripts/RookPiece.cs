using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RookPiece : MonoBehaviour
{
    public float squareSize = 1f;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;

        Vector3 rookPos = transform.position;

        for (int i = -1; i <= 1; i++)
        {
            if (i == 0) continue;

            Gizmos.DrawLine(rookPos, rookPos + new Vector3(i * squareSize, 0, 0));
            Gizmos.DrawLine(rookPos, rookPos + new Vector3(0, 0, i * squareSize));
        }
    }
}
