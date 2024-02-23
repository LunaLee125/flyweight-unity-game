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
                if (checkIfValid(gameObject) && gameManager.getTurn() == 'R')
                {
                    ptd.OnNotify('R');
                }
                else if (checkIfValid(gameObject) && gameManager.getTurn() == 'B')
                {
                    ptd.OnNotify('B');
                }


            }
            else
            {
                gameManager.setActiveObject(gameObject, true);

            }
            act = !act;
        }
    }


    public bool checkIfValid(GameObject g)
    {
        Debug.Log(g.transform.position.x < 3 && g.transform.position.x > -3 && g.transform.position.y < 3 && g.transform.position.y > -3);
        return g.transform.position.x < 3 && g.transform.position.x > -3 && g.transform.position.y < 3 && g.transform.position.y > -3;
    }
}
