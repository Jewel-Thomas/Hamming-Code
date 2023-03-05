using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Randomizer : MonoBehaviour
{
    public static bool stats=true;
    public GameObject r1txt;
    public void activate()
    {
        if(stats==false)
        {
            stats=true;
            randomize();
        }
        else
        {
            stats=false;
            r1txt.GetComponentInChildren<Text>().text = "Random Error : OFF";
        }
         
    }
    public void randomize()
    {
        r1txt.GetComponentInChildren<Text>().text = "Random Error : ON";
    }
}
