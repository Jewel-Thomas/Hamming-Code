using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Codeword : MonoBehaviour
{
    public buttonstuff buttonstuff;
    public Text text;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CopyCodeWords();
    }

    void CopyCodeWords()
    {
        int tempBit = buttonstuff.bit;
        text.text = buttonstuff.bit.ToString();
        if(tempBit==0)
        {
            image.color = Color.white;
            text.color= Color.black;
        }
        else
        {
            image.color = Color.red;
            text.color= Color.white;
        }
    }
}
