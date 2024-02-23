using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI blueTurnText;
    public TextMeshProUGUI redTurnText;

    private char turn;

    void Start(){
        Debug.Log("creating manager");
        turn = 'R';
    }

    void Update(){
        
    }

    public char getTurn(){
        return turn;
    }


   public void setActiveObject(GameObject gm, bool a){
        GameObject[] allBlocks;
        allBlocks = GameObject.FindGameObjectsWithTag("Block");

        for (int i = 0; i < allBlocks.Length; i++){
            if(allBlocks[i]!=null)
                allBlocks[i].GetComponent<ActivePieceControl>().enabled = false;
        }

        Debug.Log("in method");
        if(gm != null && gm.tag == "Block"){
            gm.GetComponent<ActivePieceControl>().enabled = a;
            //gm.GetComponent<ActivePieceControl>().active = true;
        } else {
            gm.GetComponent<ActivePieceControl>().enabled = true;
        }
        
   }

   public void switchColorto(char c){
        if(c == 'B'){
            Debug.Log("BLUE TURN");
            blueTurnText.gameObject.SetActive(true);
            redTurnText.gameObject.SetActive(false);
            turn = 'B';
            return;
        } else {
            Debug.Log("RED TURN");
            blueTurnText.gameObject.SetActive(false);
            redTurnText.gameObject.SetActive(true);
            turn = 'R';
        }
   }
}
