using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List2 : MonoBehaviour
{
    public List<GameObject> objects = new List<GameObject>();
    public List<GameObject> createdObjects = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InstantiateObjects();

            if (createdObjects.Count >= 10)
            {
                ChangeColor();
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            DeleteAllCreatedObjects();
        }
    }

    void InstantiateObjects()
    {
        foreach (var obj in objects)
        {
            if (createdObjects.Count < 10)
            {
                Vector3 randomPos = new Vector3(Random.Range(-7f, 7f), Random.Range(-5f, 5f), 0);

                GameObject createdObj = Instantiate(obj, randomPos, Quaternion.identity);
                createdObjects.Add(createdObj);
            }
        }
    }

    void ChangeColor()
    {
        foreach (var obj in createdObjects)
        {
            obj.GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }

    void DeleteAllCreatedObjects()
    {
        foreach (var obj in createdObjects)
        {
            Destroy(obj);
        }

        createdObjects.Clear();
    }
}
