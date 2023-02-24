using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float lowerBounds = -10.0f;
    public ScoreManager scoreManager;
    private DetectCollisions detectCollisions;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        detectCollisions = GetComponent<DetectCollisions>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds)
        {
            scoreManager.DecreaseScore(detectCollisions.scoreToGive);
            Destroy(gameObject);
        }
    }
}
