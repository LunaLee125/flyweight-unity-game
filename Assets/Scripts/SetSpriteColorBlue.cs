using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteColorBlue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BlockFlyweight>().sprite.color = new Color(0,0,255,255);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
