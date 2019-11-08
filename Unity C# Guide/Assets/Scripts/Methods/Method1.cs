using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method1 : MonoBehaviour
{
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        ChangeColor(cube, Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ChangeColor(GameObject cube, Color color)
    {
        cube.GetComponent<MeshRenderer>().material.color = color;
    }
}
