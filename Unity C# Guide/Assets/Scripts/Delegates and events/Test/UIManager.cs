using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text dethText;
    public static int[] dethCounter = new int[2];

    // Start is called before the first frame update
    void Start()
    {
        CubeDethsTest.onDethEvent += UpdateText;
    }

    public void UpdateText()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        dethCounter[sceneIndex]++;
        dethText.text = "DETHS: " + dethCounter[sceneIndex];
    }

    private void OnDisable()
    {
        CubeDethsTest.onDethEvent -= UpdateText;
    }
}
