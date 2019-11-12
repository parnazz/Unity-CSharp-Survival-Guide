using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property1 : MonoBehaviour
{
    static float _speed = 5f;

    static float Speed
    {
        get
        {
            return _speed;
        }
    }

    public string Name { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        Name = "Josh";

        Debug.Log("Name: " + Name);
        Debug.Log("Speed: " + Speed);
    }

}
