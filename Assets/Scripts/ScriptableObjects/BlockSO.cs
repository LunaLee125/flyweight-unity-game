using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//for creating a ScriptableObject
//ScriptableObjects are data containers used to save large amounts of data, independent of class instances

[CreateAssetMenu(fileName = "BlockData", menuName = "ScriptableObjects/BlockData", order = 1)]

public class BlockSO : ScriptableObject
{
    //intrinsic data:
    //public fields --> capitalized variables
    [field: Header("Block Data")]
    [SerializeField] private float timeBetweenMoves;
    [field: SerializeField] public int Scale {get; private set; }
    public WaitForSeconds MoveDelay {get; private set; }

    private void OnEnable()
    {
        MoveDelay = new WaitForSeconds(timeBetweenMoves);
    }
}
