using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;

    public Transform blaster;
    public GameObject laserBolt;
    public GameObject pickupItem;

    private AudioSource blasterAudio;
    public AudioClip laserBlast;

    private AudioSource pickupAudio;
    public AudioClip pickupSound;

    public int inventory = 0;

    void Start()
    {
        blasterAudio = GetComponent<AudioSource>();
        pickupAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Set horizontalInput to recieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        //Moves Player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y,transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            blasterAudio.PlayOneShot(laserBlast,1.0f);
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

    //Adds to the inventory count and writes it to the console
    public void AddToInventory()
    {
        pickupAudio.PlayOneShot(pickupSound,1.0f);
        inventory ++;
        Debug.Log(inventory);
    }
}
