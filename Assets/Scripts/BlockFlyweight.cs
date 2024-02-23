using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockFlyweight : MonoBehaviour
{
    //extrinsic data:
    public SpriteRenderer sprite; // color of sprite
    public int rotation;
    public bool active; //checks if piece is active

    public Block b;


    public BlockFlyweight (SpriteRenderer sprite, int rotation, bool active, Block b){
        this.sprite = sprite;
        this.rotation = rotation;
        this.active = active;
        this.b = b;
    }

    void Start()
    {
    }


}
