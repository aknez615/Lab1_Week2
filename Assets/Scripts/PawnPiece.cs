using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PawnPiece : MonoBehaviour
{
    public float squareSize = 1f;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;

        Vector3 pawnPos = transform.position;

        for (int i = -1; i <= 1; i++)
        {
            if (i == 0) continue;

            Gizmos.DrawLine(pawnPos, pawnPos + new Vector3(squareSize, 0, 0));
        }
    }
}
