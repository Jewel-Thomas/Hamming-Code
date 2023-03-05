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
    public int r1,r2,r0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ParityBits();
        BitDistributer();
    }

    void BitDistributer()
    {
        if(check == "r0")
        {
            text.text = r0.ToString();
            changevisual(r0);
        }
        if(check == "r1")
        {
            text.text = r1.ToString();
            changevisual(r1);
        }
        if(check == "r2")
        {
            text.text = r2.ToString();
            changevisual(r2);

        }
    }
    void ParityBits()
    {
        r2 = (bs[2].bit + bs[3].bit + bs[0].bit)%2;
        r1 = (bs[0].bit + bs[1].bit + bs[2].bit)%2;
        r0 = (bs[1].bit + bs[2].bit + bs[3].bit)%2;
    }

    void changevisual(int r)
    {
            if(r==0)
            {
                image.color = Color.white;
                text.color= Color.black;
            }
            else if(r==1)
            {
                image.color = Color.red;
                text.color= Color.white;
            }
    }
}
