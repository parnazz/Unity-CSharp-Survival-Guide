using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch3 : MonoBehaviour
{
    int _weaponID;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _weaponID = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _weaponID = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _weaponID = 3;
        }

        switch(_weaponID)
        {
            case 1:
                Debug.Log("You selected knife");
                break;
            case 2:
                Debug.Log("You selected pistol");
                break;
            case 3:
                Debug.Log("You selected machine gun");
                break;
            default:
                _weaponID = 1;
                break;
        }
    }
}
