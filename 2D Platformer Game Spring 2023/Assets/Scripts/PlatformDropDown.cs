using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDropDown : MonoBehaviour
{
    private PlatformEffector2D effector2D;
    public float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        effector2D = GetComponent<PlatformEffector2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.S))
        {
            waitTime = 0.5f;
            effector2D.rotationalOffset = 0f;
        }   
        if(Input.GetKey(KeyCode.S))
        {
            if(waitTime <=0)
            {
                effector2D.rotationalOffset = 180f;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
