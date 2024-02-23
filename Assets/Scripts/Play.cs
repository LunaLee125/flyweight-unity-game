using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : IGameState
{

    public GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    public void SetState()
    {
        gameManager.gameActive = true;
        Time.timeScale = 1;
    }

}
