using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolTest : MonoBehaviour
{
    Stack<PoolObject> _stack = new();
    [SerializeField, Tooltip("プールサイズ")]
    int _poolSize = 100;
    [SerializeField]
    PoolObject _poolObject;

    private void Start()
    {
        PoolObject poolObjeck = null;
        //Poolのサイズ分オブジェクトを生成
        for(int i = 0; i < _poolSize; i++)
        {
            poolObjeck = Instantiate(_poolObject);
            poolObjeck.gameObject.SetActive(false);
            _stack.Push(poolObjeck);
        }
    }

    /// <summary>
    /// オブジェクトをに実行するためのメソッド
    /// </summary>
    public PoolObject PoolPop(Transform gunTransform)
    {
        //スタックの数が0以下の時以下を実行する。
        if(_stack.Count <= 0)
        {
            PoolObject poolObjeck = Instantiate(_poolObject);
            poolObjeck.gameObject.SetActive(false);
            _stack.Push(poolObjeck);
            return poolObjeck;
        }

        PoolObject poolObject = _stack.Pop();
        poolObject.gameObject.SetActive(true);
        gunTransform = poolObject.gameObject.transform;
        return poolObject;
    }

    /// <summary>
    /// オブジェクトの使用が終わった時に実行するメソッド
    /// </summary>
    public void PoolPush(PoolObject poolObject)
    {
        poolObject.gameObject.SetActive(false);
        _stack.Push(poolObject);
    }
}
