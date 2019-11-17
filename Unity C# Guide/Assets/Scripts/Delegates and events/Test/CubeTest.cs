using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CubeDethsTest.onDethEvent += ResetPos;
    }

    private void ResetPos()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    private void OnDisable()
    {
        CubeDethsTest.onDethEvent -= ResetPos;
    }
}
