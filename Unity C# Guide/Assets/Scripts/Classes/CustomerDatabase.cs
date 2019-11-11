using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
    public Customer[] _customer;

    // Start is called before the first frame update
    void Start()
    {
        /*_customer[0] = new Customer("James", "Smith", 32, "male");
        _customer[1] = new Customer("John", "Dove", 16, "male");
        _customer[2] = new Customer("Mary", "Ann", 25, "female");*/

        for (int i = 0; i < _customer.Length; i++)
        {
            Debug.Log(_customer[i].firstName);
            Debug.Log(_customer[i].lastName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
