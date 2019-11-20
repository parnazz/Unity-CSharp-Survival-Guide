using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LINQ1 : MonoBehaviour
{
    public int[] quizGrades = new int[10];

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < quizGrades.Length; i++)
        {
            quizGrades[i] = Random.Range(0, 101);
        }

        var result = quizGrades.Where(grade => grade > 69).OrderBy(grade => grade);

        foreach (var grade in result)
        {
            Debug.Log(grade);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
