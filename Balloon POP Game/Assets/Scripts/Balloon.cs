using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; // How many clicks before the balloon pops
    public float scaleToIncrease = 0.10f; // Scale increase each time the balloon is clicked
    public ScoreManager scoreManager; //A reference to the score manager
    public int scoreToGive = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        //Get ScoreManager Component
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnMouseDown()
    {
        clickToPop --; //Reduce clicks by one

        //Inflate balloon
        transform.localScale += Vector3.one * scaleToIncrease;

        //Check to see if clickToPop has reached zero
        if(clickToPop == 0)
        {
            //Tell the ScoreManager to increase the score by a certain amount
            scoreManager.IncreaseScoreText(scoreToGive);
            Destroy(gameObject); //Destroy and remove popped balloon
        }
    }
}
