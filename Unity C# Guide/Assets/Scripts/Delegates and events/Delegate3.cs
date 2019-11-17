using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Delegate3 : MonoBehaviour
{
    public Action GetObjName;

    // Start is called before the first frame update
    void Start()
    {
        GetObjName = () =>
        {
            Debug.Log(gameObject.name);
        };

        GetObjName();
    }

   
}
