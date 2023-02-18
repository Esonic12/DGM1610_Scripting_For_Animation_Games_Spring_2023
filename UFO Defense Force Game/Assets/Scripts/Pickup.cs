using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float speed;
    public float zRange;
    public PlayerController playerController;
    public Material m_Material;

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();

        m_Material = GetComponent<Renderer>().material;
        print("Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length);
        StartCoroutine(ColorCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        //Make the Pickups move down the screen
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        //Destroys the pickup if it moves offscreen
        if(transform.position.z < zRange)
        {
            print("Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length);
            Destroy(gameObject);
        }
    }

    //Calls the AddToInventory function when the pickup hits the player
    private void OnTriggerEnter(Collider other)
    {
        playerController.AddToInventory();
    }

    public IEnumerator ColorCoroutine()
    {
        m_Material.color = Color.yellow;
        yield return new WaitForSeconds(1);
        StartCoroutine(FlashingColor());
    }

    IEnumerator FlashingColor()
    {
        m_Material.color = Color.white;
        yield return new WaitForSeconds(1);
        StartCoroutine(ColorCoroutine());
    }

    void OnDestroy()
    {
        Destroy(m_Material);
        print("Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length);
    }
}
