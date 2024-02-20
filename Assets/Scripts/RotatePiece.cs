using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//private GameObject block;

public class RotatePiece : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Vector2 rotationToAdd = new Vector2(90, 0);
            transform.Rotate(rotationToAdd);
        }
    }
}
