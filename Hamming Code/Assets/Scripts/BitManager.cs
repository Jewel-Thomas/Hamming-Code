using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitManager : MonoBehaviour
{
    public buttonstuff[] bs;
    public Encoding ec;
    public int[] bitArray;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateBitArray();
    }

    void UpdateBitArray()
    {
        for(int i=0;i<4;i++)
        {
            bitArray[i] = bs[i].bit;
        }
        bitArray[4] = ec.r2;
        bitArray[5] = ec.r1;
        bitArray[6] = ec.r0;
    }
}
