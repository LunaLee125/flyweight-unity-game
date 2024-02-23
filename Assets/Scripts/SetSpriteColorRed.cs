using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteColorRed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BlockFlyweight>().sprite.color = new Color(255,0,0,255);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
