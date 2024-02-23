using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    [SerializeField] private BlockSO blockData;
    //intrinsic data: 
    private int scale; 
    private int xMinBoundary;
    private int xMaxBoundary;
    private int yMinBoundary;
    private int yMaxBoundary;
    private ActivePieceControl apc;

    //extrinsic data:
    public SpriteRenderer sprite; // color of sprite
    public int rotation;
    public bool active; //checks if piece is active


    public Block (ActivePieceControl apc, int scale, int xMinBoundary, int xMaxBoundary, int yMinBoundary, int yMaxBoundary){
        this.apc = apc;
        this.scale = blockData.Scale;
    }

    void Start()
    {
        apc = GetComponent<ActivePieceControl>();
    }


}
