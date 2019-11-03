using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTime : MonoBehaviour
{
    [SerializeField]
    private float _timeScale = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _timeScale -= 0.01f;
            if (_timeScale < 0)
            {
                _timeScale = 0;
            }
        }
        else
        {
            _timeScale = 1;
        }
        Time.timeScale = _timeScale;
    }
}
