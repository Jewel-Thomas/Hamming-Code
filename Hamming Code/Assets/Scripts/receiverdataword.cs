using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class receiverdataword : MonoBehaviour
{
    public GameObject b1obj, b2obj;
    void Update()
    {
        if(b1obj.GetComponentInChildren<Text>().text == "1")
        {
            b2obj.GetComponentInChildren<Text>().text = "1";
            b2obj.GetComponent<Image>().color = Color.red;
            b2obj.GetComponentInChildren<Text>().color= Color.white;
        }
        else if(b1obj.GetComponentInChildren<Text>().text == "0")
        {
            b2obj.GetComponentInChildren<Text>().text = "0";
            b2obj.GetComponent<Image>().color = Color.white;
            b2obj.GetComponentInChildren<Text>().color= Color.black;
        }

    }
}
