using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecieverLogic : MonoBehaviour
{
    public Button[] button;
    public buttonstuff[] bs;
    public BitManager bitManager;
    public GameObject[] synGameobject;
    public int s1,s2,s0;

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
        CalculateSyndrome();
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
            bs[rand].bit = 1;
        }
        else
        {
            button[rand].GetComponentInChildren<Text>().text="0";
            button[rand].GetComponent<Image>().color = Color.white;
            button[rand].GetComponentInChildren<Text>().color= Color.black;
            bs[rand].bit = 0;
        }
        DisableAll();
    }
    void DisableAll()
    {
        for(int i=0;i<7;i++)
        {
            button[i].interactable = false;
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

    void CalculateSyndrome()
    {
        s2 = (bs[2].bit + bs[3].bit + bs[0].bit + bs[4].bit)%2;
        s1 = (bs[0].bit + bs[1].bit + bs[2].bit + bs[5].bit)%2;
        s0 = (bs[1].bit + bs[2].bit + bs[3].bit + bs[6].bit)%2; 
        synGameobject[0].GetComponentInChildren<Text>().text = s2.ToString();
        if(s2==1)
        {
            synGameobject[0].GetComponent<Image>().color = Color.red;
            synGameobject[0].GetComponentInChildren<Text>().color = Color.white;
        }
        else
        {
            synGameobject[0].GetComponent<Image>().color = Color.white;
            synGameobject[0].GetComponentInChildren<Text>().color = Color.black;
        }
        synGameobject[1].GetComponentInChildren<Text>().text = s1.ToString();
        if(s1==1)
        {
            synGameobject[1].GetComponent<Image>().color = Color.red;
            synGameobject[1].GetComponentInChildren<Text>().color = Color.white;
        }
        else
        {
            synGameobject[1].GetComponent<Image>().color = Color.white;
            synGameobject[1].GetComponentInChildren<Text>().color = Color.black;
        }
        synGameobject[2].GetComponentInChildren<Text>().text = s0.ToString();
        if(s0==1)
        {
            synGameobject[2].GetComponent<Image>().color = Color.red;
            synGameobject[2].GetComponentInChildren<Text>().color = Color.white;
        }
        else
        {
            synGameobject[2].GetComponent<Image>().color = Color.white;
            synGameobject[2].GetComponentInChildren<Text>().color = Color.black;
        }
    }

    public void CopySenderCodeWord()
    {
        for(int i=0;i<7;i++)
        {
            button[i].GetComponentInChildren<Text>().text = bitManager.bitArray[i].ToString();
            if(bitManager.bitArray[i]==1)
            {
                bs[i].bit = bitManager.bitArray[i];
                button[i].GetComponent<Image>().color = Color.red;
                button[i].GetComponentInChildren<Text>().color= Color.white;
            }
            else
            {
                bs[i].bit = bitManager.bitArray[i];
                button[i].GetComponent<Image>().color = Color.white;
                button[i].GetComponentInChildren<Text>().color= Color.black;
            }
        }
    }
}
