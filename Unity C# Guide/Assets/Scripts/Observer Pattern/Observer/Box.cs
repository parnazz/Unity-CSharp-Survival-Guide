using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Box : IObserver
{
    GameObject _boxObj;
    IBoxEvents _boxEvent;

    public Box(GameObject boxObj, IBoxEvents boxEvent)
    {
        _boxObj = boxObj;
        _boxEvent = boxEvent;
    }

    public void OnNotify()
    {
        Jump(_boxEvent.GetJump());
    }

    private void Jump(float jumpHeight)
    {
        if (_boxObj.transform.position.y < 0.55f)
        {
            _boxObj.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight);
        }
    }
}
