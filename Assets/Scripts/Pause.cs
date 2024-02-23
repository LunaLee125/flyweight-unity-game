using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : IGameState
{
    public GameObject PauseButton;

    public void SetState(int state)
    {
        Time.timeScale = state;
    }
    // set visibility of button that called this method to false
    //set visibility of play button to true
    PauseButton.gameObject.SetActive(false);
    PlayButton.gameObject.SetActive(true);
}
