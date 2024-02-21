using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePieceControl : MonoBehaviour
{
    private ResetCommand r;
    // Start is called before the first frame update
    void Start()
    {
        r = new ResetCommand(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.z = 0;
        transform.position = mousePos;

        if (Input.GetKeyDown("r"))
        {
            rotateCommand(new RotateCommand(gameObject));
        } else if (Input.GetKeyDown("e"))
        {
            undoRotateCommand(new RotateCommand(gameObject));
        } else if (Input.GetKeyDown("escape")){
            escapeCommand(r);
        }
    }

    public void rotateCommand(ICommand command){
        command.Execute();
    }

    public void escapeCommand(ICommand command){
        command.Execute();
        Destroy(GetComponent("ActivePieceControl"));
    }

    public void undoRotateCommand(ICommand command){
        command.Undo();
    }
}
