using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lab1
{
    [CreateAssetMenu(fileName = "NewChessPiece", menuName = "Chess/ChessPiece")]
    public class ChessPieces : ScriptableObject
    {
        public string pieceName;
        public Sprite chessSprite;
        public GameObject piecePrefab;
    }
}
