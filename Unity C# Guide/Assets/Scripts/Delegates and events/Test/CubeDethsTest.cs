using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeDethsTest : MonoBehaviour
{
    public delegate void DethHandler();
    public static event DethHandler onDethEvent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onDethEvent != null)
            {
                onDethEvent();
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Main2");
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
