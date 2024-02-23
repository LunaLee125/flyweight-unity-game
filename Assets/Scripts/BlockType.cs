using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockType : MonoBehaviour
{

    [SerializeField] private BlockSO blockData;
    //intrinsic data: 
    private int scale; 
    private int xMinBoundary = -7;
    private int xMaxBoundary = 7;
    private int yMinBoundary = -7;
    private int yMaxBoundary = 7;
    private ActivePieceControl apc;

    // public BlockType (ActivePieceControl apc, int scale, int xMinBoundary, int xMaxBoundary, int yMinBoundary, int yMaxBoundary){
    //     this.apc = apc;
    //     this.scale = blockData.Scale;
    // }

    public int getxMinBoundary() {
        return xMinBoundary;
    }

    public int getxMaxBoundary() {
        return xMaxBoundary;
    }

    public int getyMinBoundary() {
        return yMinBoundary;
    }

    public int getyMaxBoundary() {
        return yMaxBoundary;
    }

    void Start()
    {
        apc = GetComponent<ActivePieceControl>();
    }


}
