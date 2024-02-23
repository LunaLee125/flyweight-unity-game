using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForClick : MonoBehaviour
{

    public GameManager gameManager;
    public PlayerTurnDisplay ptd;

    public bool act;

    private int cooldown = 1000;
    // Start is called before the first frame update
    
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        ptd = new PlayerTurnDisplay();
        act = false;
        
    }

    private void OnMouseDown(){
        if (gameObject != null) {
                //Debug.Log ("CLICKED " + hit.collider.name);
                if(act == true){
                    Debug.Log("deactivating");
                    gameManager.setActiveObject(gameObject, false);
                    if (checkIfValid(gameObject) && gameManager.getTurn() == 'R'){
                        ptd.OnNotify('R');
                    } else if (checkIfValid(gameObject) && gameManager.getTurn() == 'B'){
                        ptd.OnNotify('B');
                    }

                    
                } else {
                    Debug.Log("activating");
                    gameManager.setActiveObject(gameObject, true);
                    
                }
                act = !act;
            } 
    }

    private void Update()
    {
        // if (Input.GetMouseButtonDown(0))
        // {
        //     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //     RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            // if (hit.collider != null) {
            //     Debug.Log ("CLICKED " + hit.collider.name);
            //     if(act == true){
            //         Debug.Log("deactivating");
            //         gameManager.setActiveObject(hit.collider.gameObject, false);
            //         if (checkIfValid(hit.collider.gameObject) && gameManager.getTurn() == 'R'){
            //             ptd.OnNotify('R');
            //             Debug.Log("????");
            //         } else if (checkIfValid(hit.collider.gameObject) && gameManager.getTurn() == 'B'){
            //             ptd.OnNotify('B');
            //         }

                    
            //     } else {
            //         Debug.Log("activating");
            //         gameManager.setActiveObject(hit.collider.gameObject, true);
                    
            //     }
            //     act = !act;
            // } 

            
        //}
           
    }

    public bool checkIfValid(GameObject g){
        Debug.Log(g.transform.position.x < 3 && g.transform.position.x > -3 && g.transform.position.y<3 && g.transform.position.y > -3);
        return g.transform.position.x < 3 && g.transform.position.x > -3 && g.transform.position.y<3 && g.transform.position.y > -3;
    }
}
