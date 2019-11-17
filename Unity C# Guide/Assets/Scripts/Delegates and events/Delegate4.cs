using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Delegate4 : MonoBehaviour
{
    public Func<int> nameLength;

    // Start is called before the first frame update
    void Start()
    {
        nameLength = () => gameObject.name.Length;

        Debug.Log(nameLength());
    }

    
}
