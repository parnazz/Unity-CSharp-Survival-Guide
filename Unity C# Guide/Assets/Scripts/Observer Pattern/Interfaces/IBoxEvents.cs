using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IBoxEvents
{
    float GetJump();
}

public class LittleJump : IBoxEvents
{
    public float GetJump()
    {
        return 30f;
    }
}

public class MiddleJump : IBoxEvents
{
    public float GetJump()
    {
        return 60f;
    }
}


public class HighJump : IBoxEvents
{
    public float GetJump()
    {
        return 90f;
    }
}