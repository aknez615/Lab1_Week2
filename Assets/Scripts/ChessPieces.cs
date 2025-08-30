using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lab1
{
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnScriptableObject")]
    public class ChessPieces : ScriptableObject
    {
        public string prefab;
    }
}
