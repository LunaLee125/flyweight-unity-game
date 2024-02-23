using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : IGameState
{
    public Button PlayButton;
    public Button PauseButton;

    public void SetState(int state)
    {
        Time.timeScale = 1;
    }
    // set visibility of button that called this method to false
    //set visibility of pause button to true
    PlayButton.gameObject.SetActive(false);
    PauseButton.gameObject.SetActive(true);
}
