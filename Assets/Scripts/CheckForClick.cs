using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForClick : MonoBehaviour
{

    public GameManager gameManager;

    bool active = true;
    // Start is called before the first frame update
    
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }

    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            

            if (hit.collider != null) {
                Debug.Log ("CLICKED " + hit.collider.name);
                if(active == true){
                    active = false;
                    Debug.Log("deactivating");
                    gameManager.setActiveObject(hit.collider.gameObject, false);
                    //gameObject.GetComponent<ActivePieceControl>().enabled = false;
                } else {
                    active = true;
                    Debug.Log("activating");
                    //gameObject.GetComponent<ActivePieceControl>().enabled = true;
                    gameManager.setActiveObject(hit.collider.gameObject, true);
                }
            } else {

            }

            
        }
           
    }
}
