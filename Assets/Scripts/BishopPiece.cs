using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BishopPiece : MonoBehaviour
{
    public float squareSize = 2f;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;

        Vector3 bishopPos = transform.position;

        for (int i = -1; i <= 1; i++)
        {
            if (i == 0) continue;

            Gizmos.DrawLine(bishopPos, bishopPos + new Vector3(-2, 0, i * squareSize));
        }
    }
}
