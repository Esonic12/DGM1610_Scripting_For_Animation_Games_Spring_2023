using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score; //Keep track of the game score

    public TextMeshProUGUI scoreText; //Reference to a text object to be modified

    // Start is called before the first frame update
    void Start()
    {
      UpdateScoreText();  
    }

    public void IncreaseScoreText(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScoreText(int amount)
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
