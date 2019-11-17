using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Delegate5 : MonoBehaviour
{
    public Func<int, int, int> sumResult;

    // Start is called before the first frame update
    void Start()
    {
        sumResult = (a, b) => a + b;

        Debug.Log("Sum = " + sumResult(8, 5));
    }

}
