using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : IGameState
{

    public GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    public void SetState()
    {
        Time.timeScale = 0;
        gameManager.gameActive = false;
    }

}
