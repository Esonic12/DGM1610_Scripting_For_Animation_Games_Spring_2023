using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float speed;
    public float yRange;
    public PlayerController playerController;

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Make the Pickups move down the screen
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        //Destroys the pickup if it moves offscreen
        if(transform.position.z < yRange)
        {
            Destroy(gameObject);
        }
    }

    //Calls the AddToInventory function when the pickup hits the player
    private void OnTriggerEnter(Collider other)
    {
        playerController.AddToInventory();
    }
}
