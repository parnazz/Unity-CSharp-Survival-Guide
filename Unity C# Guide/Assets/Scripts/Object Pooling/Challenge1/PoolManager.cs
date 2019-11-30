using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    private static PoolManager _instance;
    
    public static PoolManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("PoolManager is NULL");

            return _instance;
        }
    }

    [SerializeField]
    private GameObject _bulletContainer;
    [SerializeField]
    private GameObject _bulletPrefab;
    [SerializeField]
    private int _lengthOfPool;
    [SerializeField]
    private List<GameObject> _bulletsPool;

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        _bulletsPool = GenerateBulletsPool(_lengthOfPool);
    }

    public List<GameObject> GenerateBulletsPool(int lengthOfPool)
    {
        for (int i = 0; i < lengthOfPool; i++)
        {
            GameObject bullet = Instantiate(_bulletPrefab);
            _bulletsPool.Add(bullet);
            bullet.transform.parent = _bulletContainer.transform;
            bullet.SetActive(false);
        }

        return _bulletsPool;
    }

    public GameObject RequestBullet()
    {
        foreach (var _bullet in _bulletsPool)
        {
            if (!_bullet.activeInHierarchy)
            {
                _bullet.SetActive(true);

                return _bullet;
            }
        }

        GameObject newBullet = Instantiate(_bulletPrefab);
        _bulletsPool.Add(newBullet);
        newBullet.transform.parent = _bulletContainer.transform;

        return newBullet;
    }
}
