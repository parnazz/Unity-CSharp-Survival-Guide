using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop1 : MonoBehaviour
{
    private float _speed = 0;
    private float _maxSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        _maxSpeed = Random.Range(60, 120);

        StartCoroutine(SpeedIncrement());
    }

    IEnumerator SpeedIncrement()
    {
        while (_speed <= _maxSpeed)
        {
            _speed += 5;
            Debug.Log("Speed = " + _speed);
            yield return new WaitForSeconds(1f);
        }
    }
}
