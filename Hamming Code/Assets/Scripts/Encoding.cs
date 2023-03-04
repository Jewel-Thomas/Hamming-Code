using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Encoding : MonoBehaviour
{
    public buttonstuff[] bs;
    public Text text;
    public Image image;
    public string check;
    int r1,r2,r0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        ParityBits();
        if(check == "r0")
        {
            text.text = r0.ToString();
            if(r0==0)
            {
                image.color = Color.white;
            }
            else
            {
                image.color = Color.red;
            }
        }
        if(check == "r1")
        {
            text.text = r1.ToString();
            if(r1==0)
            {
                image.color = Color.white;
            }
            else
            {
                image.color = Color.red;
            }
        }
        if(check == "r2")
        {
            text.text = r2.ToString();
            if(r2==0)
            {
                image.color = Color.white;
            }
            else
            {
                image.color = Color.red;
            }
        }
    }

    void ParityBits()
    {
        r2 = (bs[2].bit + bs[3].bit + bs[0].bit)%2;
        r1 = (bs[0].bit + bs[1].bit + bs[2].bit)%2;
        r0 = (bs[1].bit + bs[2].bit + bs[3].bit)%2;
    }
}
