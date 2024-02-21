using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCommand : ICommand
{
    private GameObject o;
    public RotateCommand(GameObject o){
        this.o = o;
    }
    public void Execute(){
        o.transform.Rotate(new Vector3(0, 0, 90));
    }

    public void Undo(){
        o.transform.Rotate(new Vector3(0, 0, -90));
    }
}
