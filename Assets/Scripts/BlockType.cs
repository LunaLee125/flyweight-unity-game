using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockType : MonoBehaviour
{

    [SerializeField] private BlockSO blockData;
    //intrinsic data: 
    private int scale; 
    private int xMinBoundary;
    private int xMaxBoundary;
    private int yMinBoundary;
    private int yMaxBoundary;
    private ActivePieceControl apc;

    public BlockType (ActivePieceControl apc, int scale, int xMinBoundary, int xMaxBoundary, int yMinBoundary, int yMaxBoundary){
        this.apc = apc;
        this.scale = blockData.Scale;
    }

    void Start()
    {
        apc = GetComponent<ActivePieceControl>();
    }


}
