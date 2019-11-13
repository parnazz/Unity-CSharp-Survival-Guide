using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List1 : MonoBehaviour
{
    public List<string> names = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        PrintNames();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && names.Count > 0)
        {
            DeleteRandomName();
            PrintNames();
        }
    }

    void PrintNames()
    {
        foreach (var name in names)
        {
            Debug.Log(name);
        }
    }

    void DeleteRandomName()
    {
        int randomIndex = Random.Range(0, names.Count);

        names.RemoveAt(randomIndex);
    }
}
