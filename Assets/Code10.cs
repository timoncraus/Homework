using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code10 : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(higherNumber(num1, num2).ToString() + " ������");
    }
    int higherNumber(int num1, int num2)
    {
        if(num1 > num2)
        {
            return num1;
        }
        return num2;
    }
}
