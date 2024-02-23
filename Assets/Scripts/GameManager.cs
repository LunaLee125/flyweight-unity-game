using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    void Update(){
        
    }
   public void setActiveObject(GameObject gm, bool active){
        GameObject[] allBlocks;
        allBlocks = GameObject.FindGameObjectsWithTag("Block");

        for (int i = 0; i < allBlocks.Length; i++){
            allBlocks[i].GetComponent<ActivePieceControl>().enabled = false;
        }
        Debug.Log("in method");
        if(gm != null){
            gm.GetComponent<ActivePieceControl>().enabled = active;
        }
        
   }
}
