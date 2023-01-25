using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    int time = 304;
    public string weather = "clear";
    bool isStopLightRed = true;
    float gpa = 3.25f;
    double temperature = 101.45;

    // Start is called before the first frame update
    void Start()
    {
        //Check Time
        if(time >= 200)
        {
            Debug.Log("Rise and Shine!");
        }
        else
        {
            Debug.Log("It's too early, go back to bed!");
        }

        //Check Weather
        if(weather == "cloudy")
        {
            Debug.Log("It is cloudy outside");
        }
        else if(weather == "raining")
        {
            Debug.Log("It is raining outside!");
        }
        else if(weather == "clear")
        {
            Debug.Log("It is a beautiful day outside!");
        }
        else if(weather == "Thunder Lightning")
        {
            Debug.Log("There is thunder and lightning outside, stay indoors!!!");
        }
        else if(weather == "snowing")
        {
            Debug.Log("It is snowing outside, bundle up it is cold!");
        }
        else 
        {
            Debug.Log("Do what you want, it's a day.");
        }

        /*

        if(conditional_01)
        {
            //If condition_01 is true run this code
        }
        else if(conditional_02)
        {
            //If condition_02 is true run this code
        }
        else
        {
            //If no other conditions are true run this code
        }

        */
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
