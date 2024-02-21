using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //intrinsic data:
    private ActivePieceControl apc;
    private int scale;

    //extrinsic data:
    public SpriteRenderer sprite; // color of sprite
    public int rotation;
    public bool active; //checks if piece is active

    public Block (ActivePieceControl apc, int scale){
        this.apc = apc;
        this.scale = scale;
    }

    void Start()
    {
        apc = GetComponent<ActivePieceControl>();
    }


}
