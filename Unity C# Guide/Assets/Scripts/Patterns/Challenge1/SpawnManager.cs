using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private static SpawnManager _instance;

    public static SpawnManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.Log("SpawnManager is null");

            return _instance;
        }
    }

    // Start is called before the first frame update
    void Awake()
    {
        _instance = this;
    }

    public void StartSpawn(GameObject cube)
    {
        Vector3 randPos = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), 0);
        Instantiate(cube, randPos, Quaternion.identity);
    }
}
