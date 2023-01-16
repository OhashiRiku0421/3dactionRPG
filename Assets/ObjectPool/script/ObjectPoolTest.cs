using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolTest : MonoBehaviour
{
    List<PoolObject> _list = new();
    [SerializeField, Tooltip("プールサイズ")]
    int _poolSize = 100;
    [SerializeField]
    PoolObject _poolObject;

    private void Start()
    {
        PoolObject poolObjeck = null;
        //Poolのサイズ分オブジェクトを生成
        for (int i = 0; i < _poolSize; i++)
        {
            poolObjeck = Instantiate(_poolObject);
            poolObjeck.gameObject.SetActive(false);
            _list.Add(poolObjeck);
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            PoolPop(transform).PopInterval(this);
        }
    }

    /// <summary>
    /// オブジェクトをに実行するためのメソッド
    /// </summary>
    public PoolObject PoolPop(Transform gunTransform)
    {
        

        foreach (var pool in _list)
        {
            if (pool.gameObject.activeSelf == false)
            {
                pool.gameObject.SetActive(true);
                gunTransform = pool.gameObject.transform;
                return pool;
            }

        }

        //Poolが空な時に実行される。
        PoolObject poolObjeck = Instantiate(_poolObject);
        poolObjeck.gameObject.SetActive(false);
        _list.Add(poolObjeck);
        return poolObjeck;
    }

    /// <summary>
    /// オブジェクトの使用が終わった時に実行するメソッド
    /// </summary>
    public void PoolPush(PoolObject poolObject)
    {
        poolObject.gameObject.SetActive(false);
    }
}
