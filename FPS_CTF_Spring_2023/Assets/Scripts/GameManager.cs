using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool hasFlag;
    public bool flagPlaced;
    
    public int scoreToWin;
    public int curScore;

    public bool gamePaused;
    
    public static GameManager instance;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
       hasFlag = false;
       flagPlaced = false;

       Time.timeScale = 1.0f; 
    }

    // Update is called once per frame
    void Update()
    {
        if(flagPlaced)
        {
            WinGame();
        }

        if(Input.GetButtonDown("Cancel"))
        {
            TogglePauseGame();
        }
    }

    public void TogglePauseGame()
    {
        gamePaused = !gamePaused;
        Time.timeScale = gamePaused == true ? 0.0f : 1.0f;

        GameUI.instance.TogglePauseMenu(gamePaused);
        Cursor.lockState = gamePaused == true ? CursorLockMode.None : CursorLockMode.Locked;
    }

    public void AddScore(int score)
    {
        curScore += score;
    }

    void WinGame()
    {
        
    }
}
