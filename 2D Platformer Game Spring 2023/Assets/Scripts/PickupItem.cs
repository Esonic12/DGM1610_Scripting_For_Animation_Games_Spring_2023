using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public InventoryManager inventoryManager;
    private bool isCollected = false;
    public Transform collectCheck;
    public LayerMask whatIsPlayer;
    public float checkRadius;

    // Start is called before the first frame update
    void Start()
    {
        inventoryManager = GameObject.Find("InventoryManager").GetComponent<InventoryManager>();  
    }

    void FixedUpdate()
    {
        isCollected = Physics2D.OverlapCircle(collectCheck.position, checkRadius, whatIsPlayer);
        if(isCollected)
        {
            inventoryManager.AddToInventory();
            Destroy(gameObject);
        }
    }
}
