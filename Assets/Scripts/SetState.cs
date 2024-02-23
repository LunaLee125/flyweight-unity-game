using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetState : MonoBehaviour
{
    //state is either 0 or 1; 0 will pause, 1 will play
    //so now can create different types of buttons
    //all with the capability of stopping/playing the game
    public int state = 1;
    public IGameState gameState;

    public void ChangeGameState(IGameState state)
    {
        gameState?.SetState(state);
    }
}
