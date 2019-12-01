using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ActionTest : MonoBehaviour
{
    public Func<float> Jump;

    public float jumpHeight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(LittleJump());
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log(HighJump());
        }
    }

    public float LittleJump()
    {
        Jump = () => jumpHeight = 30f;
        Jump();
        return jumpHeight;
    }

    public float HighJump()
    {
        Jump = () => jumpHeight = 90f;
        Jump();
        return jumpHeight;
    }
}
