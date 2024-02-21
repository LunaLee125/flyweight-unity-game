using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    [SerializeField] private BlockSO blockData;
    //intrinsic data: 
    public int scale; 

    //extrinsic data:
    public SpriteRenderer sprite; // color of sprite
    public int rotation;
    public bool active; //checks if piece is active
    public ActivePieceControl apc;

    public Block (ActivePieceControl apc, int scale){
        this.apc = apc;
        this.scale = blockData.Scale;
    }

    void Start()
    {
        apc = GetComponent<ActivePieceControl>();
    }


}
