using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIfTest : MonoBehaviour
{
    private float _speed = 0;
    private float _acceleration = 5;
    private bool _isTooSlow = true;
    private bool _isTooFast = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _speed += Time.deltaTime * _acceleration;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _speed -= Time.deltaTime * _acceleration;
        }

        _speed = Mathf.Clamp(_speed, 0, 30);

        if (_speed <= 0 && _isTooSlow)
        {
            Debug.Log("You need to speed up");
            _isTooSlow = false;
            _isTooFast = true;
        }
        else if (_speed >= 20 && _isTooFast)
        {
            Debug.Log("You need to slow down");
            _isTooSlow = true;
            _isTooFast = false;
        }
    }
}
