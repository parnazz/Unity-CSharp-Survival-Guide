using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate1 : MonoBehaviour
{
    public delegate void ActionHandler();
    public static event ActionHandler TeleportEvent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && TeleportEvent != null)
        {
            TeleportEvent();
        }
    }
}
