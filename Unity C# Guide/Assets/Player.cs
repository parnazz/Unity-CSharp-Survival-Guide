using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //private float _speed = 2f;
    [SerializeField]
    private Transform _spherePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.right * _speed * Time.deltaTime);

        Vector3 directionToLook = _spherePos.position - transform.position;

        transform.rotation = Quaternion.LookRotation(directionToLook);
    }
}
