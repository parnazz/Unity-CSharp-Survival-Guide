using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    [SerializeField]
    private int[] _quizes;

    public float avgVal;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _quizes.Length; i++)
        {
            _quizes[i] = Random.Range(0, 101);
            avgVal += _quizes[i];
        }

        avgVal /= _quizes.Length;
        avgVal = Mathf.Round(avgVal);

        GradeCalculation();
    }

    // Update is called once per frame
    void GradeCalculation()
    {
        if (avgVal >= 90)
        {
            Debug.Log("You got A!");
        }
        else if (avgVal >= 80 && avgVal < 90)
        {
            Debug.Log("You got B");
        }
        else if (avgVal >= 70 && avgVal < 80)
        {
            Debug.Log("You got C.");
        }
        else
        {
            Debug.Log("You got F...");
        }
    }
}
