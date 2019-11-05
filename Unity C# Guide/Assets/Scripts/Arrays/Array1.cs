using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array1 : MonoBehaviour
{
    public string[] names;
    public int[] ages;
    public string[] colors;

    int _randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        _randomIndex = Random.Range(0, names.Length);

        Debug.Log(names[_randomIndex]);
        Debug.Log(ages[_randomIndex]);
        Debug.Log(colors[_randomIndex]);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(names[_randomIndex]);
            Debug.Log(ages[_randomIndex]);
            Debug.Log(colors[_randomIndex]);
        }
    }
}
