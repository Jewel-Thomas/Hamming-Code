using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonstuff : MonoBehaviour
{
    //public Button b1;
    //public text t1;
    public GameObject b1obj;
    public int bit = 0;
    public int recieverBit = 0;
    public RecieverLogic recieverLogic;

    void Start()
    {
        recieverBit = bit;
        try{
            recieverLogic.CopySenderCodeWord();
        }
        catch
        {

        }
    }

    public void ChangeValue()
    {
        if(bit == 0)
        {
            b1obj.GetComponentInChildren<Text>().text = "1";
            b1obj.GetComponent<Image>().color = Color.red;
            b1obj.GetComponentInChildren<Text>().color= Color.white;
            bit = 1;
            recieverBit = bit;
        }
        else if(bit == 1)
        {
            b1obj.GetComponentInChildren<Text>().text = "0";
            b1obj.GetComponent<Image>().color = Color.white;
            b1obj.GetComponentInChildren<Text>().color= Color.black;
            bit = 0;
            recieverBit = bit;
        }
        // try
        // {
        //     recieverLogic.CopySenderCodeWord();
        // }
        // catch
        // {

        // }
    }
}
