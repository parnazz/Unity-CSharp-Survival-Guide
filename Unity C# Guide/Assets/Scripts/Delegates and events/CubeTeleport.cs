using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTeleport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Delegate1.TeleportEvent += TeleportCube;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TeleportCube()
    {
        transform.position = new Vector3(5, 2, 0);
    }

    private void OnDisable()
    {
        Delegate1.TeleportEvent -= TeleportCube;
    }
}
