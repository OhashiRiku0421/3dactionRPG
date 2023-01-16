using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolTest : MonoBehaviour
{
    List<PoolObject> _list = new();
    [SerializeField, Tooltip("�v�[���T�C�Y")]
    int _poolSize = 100;
    [SerializeField]
    PoolObject _poolObject;

    private void Start()
    {
        PoolObject poolObjeck = null;
        //Pool�̃T�C�Y���I�u�W�F�N�g�𐶐�
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
    /// �I�u�W�F�N�g���Ɏ��s���邽�߂̃��\�b�h
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

        //Pool����Ȏ��Ɏ��s�����B
        PoolObject poolObjeck = Instantiate(_poolObject);
        poolObjeck.gameObject.SetActive(false);
        _list.Add(poolObjeck);
        return poolObjeck;
    }

    /// <summary>
    /// �I�u�W�F�N�g�̎g�p���I��������Ɏ��s���郁�\�b�h
    /// </summary>
    public void PoolPush(PoolObject poolObject)
    {
        poolObject.gameObject.SetActive(false);
    }
}
