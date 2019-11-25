using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStarter : MonoBehaviour
{
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawnCoroutine());
    }

    IEnumerator StartSpawnCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            SpawnManager.Instance.StartSpawn(cube);
        }
    }
}
