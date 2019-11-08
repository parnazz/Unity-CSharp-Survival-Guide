using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method2 : MonoBehaviour
{
    public int healths;
    private int _maxHealths = 100;
    private bool _isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        healths = _maxHealths;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isAlive)
        {
            Damage();
        }
    }

    private void Damage()
    {
        int damage = Random.Range(1, 11);
        healths -= damage;

        if (healths <= 0)
        {
            healths = 0;
            Debug.Log("Player is DEAD!");
            _isAlive = false;
        }
    }
}
