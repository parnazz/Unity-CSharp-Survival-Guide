using UnityEngine;

public class Switch2 : MonoBehaviour
{
    int _score = 0;
    [SerializeField]
    private GameObject _player;
    private Renderer _playerRenderer;

    private void Start()
    {
        _playerRenderer = _player.GetComponent<Renderer>();

        _playerRenderer.material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _score = 1;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            _score = 2;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            _score = 3;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            _score = 4;
        }
       
        switch (_score)
        {
            case 1:
                _playerRenderer.material.color = Color.red;
                break;
            case 2:
                _playerRenderer.material.color = Color.green;
                break;
            case 3:
                _playerRenderer.material.color = Color.blue;
                break;
            case 4:
                _playerRenderer.material.color = Color.black;
                break;
            default:
                _playerRenderer.material.color = Color.white;
                break;
        }
    }
}
