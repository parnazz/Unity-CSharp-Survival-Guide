using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First : ITest
{
    public void MyMethod()
    {
        Debug.Log("In the first class");
    }

    public void RandomMethod()
    {
        Debug.Log("Some text");
    }
}
