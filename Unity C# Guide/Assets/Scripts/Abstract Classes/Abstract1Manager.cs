using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Abstract1Manager : MonoBehaviour
{
    public FullTime fulltimeWorker;
    public PartTime parttimeWorker;

    // Start is called before the first frame update
    void Start()
    {
        //fulltimeWorker = new FullTime(12000);
        //parttimeWorker = new PartTime(80, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            fulltimeWorker.CalculateMonthlySalary();
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            parttimeWorker.CalculateMonthlySalary();
        }
    }
}
