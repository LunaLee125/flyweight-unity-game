using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerTurnDisplay : IObserver
{
    //reference to subject
    [SerializeField] Subject _playerSubject;
    public GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();


    //enum, assign each action to a constant (safe)
    public void OnNotify(char t) {
        //display logic goes here

        Debug.Log("in notify");

        if(t == 'R'){      
            gameManager.switchColorto('B');
            return;
        } else if (t == 'B'){
            gameManager.switchColorto('R');
            return;
        }
    }

    public void OnNotify(EndStates e){

    }

}
