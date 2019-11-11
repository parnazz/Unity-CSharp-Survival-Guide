using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColorHelper
{
    public static void ColorChange(GameObject obj)
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        obj.GetComponent<MeshRenderer>().material.color = randomColor;
    }

}
