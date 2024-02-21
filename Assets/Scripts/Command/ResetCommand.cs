using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCommand : ICommand
{
    private GameObject o;
    private Vector3 initialPos;
    private Quaternion initialRotation;

    public ResetCommand(GameObject o){
        this.o = o;
        initialPos = o.transform.position;
        initialRotation = o.transform.rotation;
        
    }
    public void Execute(){
        o.transform.rotation = initialRotation;
        o.transform.position = initialPos;
    }

    public void Undo(){

    }
}
