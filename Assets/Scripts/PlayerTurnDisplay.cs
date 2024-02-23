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
        //gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        if(t == 'R'){      
            gameManager.switchColorto('B');
            return;
        } else if (t == 'B'){
            gameManager.switchColorto('R');
            return;
        }

        // switch ((int) turn){
        //     case 1:
        //        blueTurnText.gameObject.SetActive(true);
        //         redTurnText.gameObject.SetActive(false);
        //         break; 
        //     case 2:
        //         blueTurnText.gameObject.SetActive(false);
        //         redTurnText.gameObject.SetActive(true);
        //         break;
        // }
    }

    public void OnNotify(EndStates e){

    }

    // //adds itself to subject's list of observers
    // private void OnEnable() {
    //     _playerSubject.AddObserver(this);
    // }

    //when the gameobject is disabled
    // private void OnDisable() 
    // {
    //     _playerSubject.RemoveObserver(this);
    // }
}
