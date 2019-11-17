using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Delegate2 : MonoBehaviour
{
    //public delegate void SumResult();
    //SumResult sumResult;
    public Action<int, int> SumResult;

    public int a, b, sum;

    // Start is called before the first frame update
    void Start()
    {
        SumResult = (a, b) => sum = (a + b);
        SumResult(a, b);
        Debug.Log("Sum: " + sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
