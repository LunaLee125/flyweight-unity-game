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

    public Button restartButton;
    public Button playButton;
    public Button pauseButton;

    private char turn;

    public bool gameActive;

    public IGameState gameState;


    void Start()
    {
        restartButton.onClick.AddListener(RestartGame);
        playButton.onClick.AddListener(playPattern);
        pauseButton.onClick.AddListener(pausePattern);
        turn = 'R';
        gameActive = true;
    }

    void Update()
    {
        gameState.SetState();
    }

    public char getTurn()
    {
        return turn;
    }


    public void setActiveObject(GameObject gm, bool a)
    {
        if (gameActive)
        {
            GameObject[] allBlocks;
            allBlocks = GameObject.FindGameObjectsWithTag("Block");

            for (int i = 0; i < allBlocks.Length; i++)
            {
                if (allBlocks[i] != null)
                    allBlocks[i].GetComponent<ActivePieceControl>().enabled = false;
            }

            Debug.Log("in method");
            if (gm != null && gm.tag == "Block")
            {
                gm.GetComponent<ActivePieceControl>().enabled = a;
            }
            else
            {
                gm.GetComponent<ActivePieceControl>().enabled = true;
            }
        }


    }

    public void switchColorto(char c)
    {
        if (c == 'B')
        {
            Debug.Log("BLUE TURN");
            blueTurnText.gameObject.SetActive(true);
            redTurnText.gameObject.SetActive(false);
            turn = 'B';
            return;
        }
        else
        {
            Debug.Log("RED TURN");
            blueTurnText.gameObject.SetActive(false);
            redTurnText.gameObject.SetActive(true);
            turn = 'R';
        }
    }

    //context class for strategy pattern
    public void pausePattern()
    {
        gameState = new Pause();
        
    }

    public void playPattern()
    {
        gameState = new Play();
        
    }

    public void RestartGame()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
