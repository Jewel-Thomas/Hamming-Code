using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Randomizer : MonoBehaviour
{
    public RecieverLogic recieverLogic;
    public static bool stats=false;
    public GameObject r1txt;
    public void activate()
    {
        if(stats==false)
        {
            stats=true;
            randomize();
            recieverLogic.RandomBitSelect();
        }
        else
        {
            stats=false;
            r1txt.GetComponentInChildren<Text>().text = "Random Error : OFF";
            recieverLogic.Reset();
        }
         
    }
    public void randomize()
    {
        r1txt.GetComponentInChildren<Text>().text = "Random Error : ON";
    }
}
