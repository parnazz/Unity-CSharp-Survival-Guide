using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Numbers from 1 to 10:");
        for (int i = 0; i <= 10; i++)
        {
            Debug.Log("i = " + i);
        }

        Debug.Log("Even numbers from 1 to 20:");
        for (int i = 0; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log("i = " + i);
            }
        }

        Debug.Log("Odd numbers from 1 to 30:");
        for (int i = 0; i <= 30; i++)
        {
            if (i % 2 == 1)
            {
                Debug.Log("i = " + i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
