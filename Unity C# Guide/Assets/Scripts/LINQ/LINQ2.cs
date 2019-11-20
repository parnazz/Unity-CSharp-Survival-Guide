using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Item
{
    public string name;
    public int itemID;
    public int attackModifier;
}

public class LINQ2 : MonoBehaviour
{
    public List<Item> items;

    // Start is called before the first frame update
    void Start()
    {
        var idCheck = items.Where(id => id.itemID == 3);
        var attackCheck = items.Where(attack => attack.attackModifier > 35);
        var avg = items.Average(item => item.attackModifier);

        foreach (var item in idCheck)
        {
            Debug.Log("Item with ID = 3: " + item.name);
        }

        foreach (var item in attackCheck)
        {
            Debug.Log(item.name + " has attack modifier greater than 35");
        }

        Debug.Log("Average attack modifier is: " + avg);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
