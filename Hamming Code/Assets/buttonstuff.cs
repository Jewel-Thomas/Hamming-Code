using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonstuff : MonoBehaviour
{
    //public Button b1;
    //public text t1;
    public GameObject b1obj;

    public void ChangeValue()
    {
        if(b1obj.GetComponentInChildren<Text>().text == "0")
        {
            b1obj.GetComponentInChildren<Text>().text = "1";
            b1obj.GetComponent<Image>().color = Color.red;
            b1obj.GetComponentInChildren<Text>().color= Color.white;
        }
        else if(b1obj.GetComponentInChildren<Text>().text == "1")
        {
            b1obj.GetComponentInChildren<Text>().text = "0";
            b1obj.GetComponent<Image>().color = Color.white;
            b1obj.GetComponentInChildren<Text>().color= Color.black;
        }
    }
}
