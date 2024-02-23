using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForClick : MonoBehaviour
{

    public GameManager gameManager;
    public PlayerTurnDisplay ptd;

    public bool act;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        ptd = new PlayerTurnDisplay();
        act = false;

    }

    private void OnMouseDown()
    {
        if (gameObject != null)
        {
            if (act == true)
            {
                gameManager.setActiveObject(gameObject, false);
                if (checkIfValid(gameObject, 'a') && gameManager.getTurn() == 'R')
                {
                    ptd.OnNotify('R');
                    checkIfValid(gameObject, 'R');
                }
                else if (checkIfValid(gameObject, 'a') && gameManager.getTurn() == 'B')
                {
                    ptd.OnNotify('B');
                    checkIfValid(gameObject, 'B');
                }


            }
            else
            {
                gameManager.setActiveObject(gameObject, true);

            }
            act = !act;
        }
    }


    public bool checkIfValid(GameObject g, char c)
    {
        if(g.transform.position.x < 3 && g.transform.position.x > -3 && g.transform.position.y < 3 && g.transform.position.y > -3){
            g.GetComponent<ActivePieceControl>().active = false;
        }
        return g.transform.position.x < 3 && g.transform.position.x > -3 && g.transform.position.y < 3 && g.transform.position.y > -3;
    }
}
