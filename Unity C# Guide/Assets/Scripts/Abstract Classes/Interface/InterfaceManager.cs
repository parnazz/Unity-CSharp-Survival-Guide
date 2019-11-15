using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceManager : MonoBehaviour
{
    ITest any;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            any = new First();
            First first = (First) any;
            first.RandomMethod();
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            any = new Second();
        }

        if (Input.GetKeyDown(KeyCode.Space) && any != null)
        {
            any.MyMethod();
        }
    }
}
