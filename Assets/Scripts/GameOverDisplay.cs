using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//need to create another interface cause type is currently PlayerTurn
public class GameOverDisplay : MonoBehaviour, IObserver
{
    //reference to subject
    [SerializeField] Subject _playerSubject;

    //enum, assign each action to a constant (safe)
    public void OnNotify(EndStates endState) {

    }

    public void OnNotify(PlayerTurns p) {

    }

    //adds itself to subject's list of observers
    private void OnEnable() {
        _playerSubject.AddObserver(this);
    }

    //when the gameobject is disabled
    private void OnDisable() 
    {
        _playerSubject.RemoveObserver(this);
    }
}
