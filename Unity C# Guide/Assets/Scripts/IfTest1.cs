using UnityEngine;

public class IfTest1 : MonoBehaviour
{
    int _score = 0;
    bool _isWinPrintable = true;
    [SerializeField]
    private GameObject _player;
    private Renderer _playerRenderer;

    private void Start()
    {
        _playerRenderer = _player.GetComponent<Renderer>();

        _playerRenderer.material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _score += 10;
            Debug.Log(_score);
        }

        if (_score >= 50 && _isWinPrintable)
        {
            _playerRenderer.material.color = Color.green;
            _isWinPrintable = false;
        }
    }
}
