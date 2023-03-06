using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecieverLogic : MonoBehaviour
{
    public Button[] button;
    public buttonstuff[] bs;
    public BitManager bitManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            Reset();
        }
        if(!Randomizer.stats)
        {
            CopySenderCodeWord();
        }
    }

    public void ErrorMade()
    {
        Randomizer.stats = true;
    }

    public void RandomBitSelect()
    {
        Randomizer.stats = true;
        int rand = Random.Range(0,7);
        Debug.Log(rand);
        if(button[rand].GetComponentInChildren<Text>().text=="0")
        {
            button[rand].GetComponentInChildren<Text>().text="1";
            button[rand].GetComponent<Image>().color = Color.red;
            button[rand].GetComponentInChildren<Text>().color= Color.white;
        }
        else
        {
            button[rand].GetComponentInChildren<Text>().text="0";
            button[rand].GetComponent<Image>().color = Color.white;
            button[rand].GetComponentInChildren<Text>().color= Color.black;
        }
        DisableAll();
    }
    void DisableAll()
    {
        for(int i=0;i<7;i++)
        {
            if(bitManager.bitArray[i]!=bs[i].bit)
            {
                for(int j=0;j<i;j++)
                {
                    button[j].interactable = false;
                }
                for(int j=i+1;j<7;j++)
                {
                    button[j].interactable = false;
                }
            }
        }
    }

    public void Reset()
    {
        for(int i=0;i<7;i++)
        {
            button[i].interactable = true;
        }
        Randomizer.stats = false;
    }

    public void CopySenderCodeWord()
    {
        for(int i=0;i<7;i++)
        {
            button[i].GetComponentInChildren<Text>().text = bitManager.bitArray[i].ToString();
            if(bitManager.bitArray[i]==1)
            {
                // bs[i].bit = bitManager.bitArray[i];
                button[i].GetComponent<Image>().color = Color.red;
                button[i].GetComponentInChildren<Text>().color= Color.white;
            }
            else
            {
                // bs[i].bit = bitManager.bitArray[i];
                button[i].GetComponent<Image>().color = Color.white;
                button[i].GetComponentInChildren<Text>().color= Color.black;
            }
        }
    }
}
