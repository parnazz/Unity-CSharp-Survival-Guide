using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method3 : MonoBehaviour
{
    private float _xPos = 5f;
    private float _yPos = 5f;
    private float _zPos = 5f;

    public Vector3[] randomPositions;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        randomPositions = GenRandomPosition();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetToRandomPosition();
        }
    }

    private Vector3[] GenRandomPosition()
    {
        Vector3[] randomPosition = new Vector3[5];

        for (int i = 0; i < randomPosition.Length; i++)
        {
            float _xRandom = Random.Range(-_xPos, _xPos);
            float _yRandom = Random.Range(-_yPos, _yPos);
            float _zRandom = Random.Range(-_zPos, _zPos);
            Vector3 randomVector = new Vector3(_xRandom, _yRandom, _zRandom);

            randomPosition[i] = randomVector;
        }

        return randomPosition;
    }

    private void SetToRandomPosition()
    {
        int randomIndex = Random.Range(0, randomPositions.Length);

        cube.transform.position = randomPositions[randomIndex];
    }
}
