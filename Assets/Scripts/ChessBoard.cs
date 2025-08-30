using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ChessBoard : MonoBehaviour
{
    public int gridSizeX = 8;
    public int gridSizeZ = 8;
    public Color gizmoColor = Color.white;
    public Color color1 = Color.white;
    public Color color2 = Color.cyan;
    public float squareSize = 1f;

    private void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        
        for (int x = 0; x < gridSizeX; x++)
        {
            for (int z = 0; z < gridSizeZ; z++)
            {
                bool isEven = (x + z) % 2 == 0;
                Gizmos.color = isEven ? color1 : color2;

                Vector3 center = new Vector3(x * squareSize, 0, z * squareSize);
                center -= new Vector3(gridSizeX * squareSize / 2f - squareSize / 2f, 0, gridSizeZ * squareSize / 2f - squareSize / 2f);

                Gizmos.DrawCube(center, new Vector3(squareSize, 0, squareSize));
            }
        }
    }
}
