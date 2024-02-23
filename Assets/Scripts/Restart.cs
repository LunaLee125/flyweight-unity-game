using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : IGameState
{
    public void SetState(int state)
    {
        Time.timeScale = state;
    }

    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}
