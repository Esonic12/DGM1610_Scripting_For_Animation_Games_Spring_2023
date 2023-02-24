using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    private ScoreManager scoreManager;
    public int scoreToGive;
   // public ParticleSystem explosionParticle;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();    
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("LaserBolt"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        //Explosion();
        scoreManager.IncreaseScore(scoreToGive);
    }

   /* void Explosion()
    {
        Instantiate(explosionParticle, transform.position, transform.rotation);
    } */
}
