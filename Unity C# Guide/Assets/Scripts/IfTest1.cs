using UnityEngine;

public class IfTest1 : MonoBehaviour
{
    int _score = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _score += 10;
            Debug.Log(_score);
        }
    }
}
