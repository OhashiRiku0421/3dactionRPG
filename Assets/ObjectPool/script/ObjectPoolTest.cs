using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolTest : MonoBehaviour
{
    Stack<PoolObject> _stack = new();
    [SerializeField, Tooltip("�v�[���T�C�Y")]
    int _poolSize = 100;
    [SerializeField]
    PoolObject _poolObject;

    private void Start()
    {
        PoolObject poolObjeck = null;
        //Pool�̃T�C�Y���I�u�W�F�N�g�𐶐�
        for(int i = 0; i < _poolSize; i++)
        {
            poolObjeck = Instantiate(_poolObject);
            poolObjeck.gameObject.SetActive(false);
            _stack.Push(poolObjeck);
        }
    }

    /// <summary>
    /// �I�u�W�F�N�g���Ɏ��s���邽�߂̃��\�b�h
    /// </summary>
    public PoolObject PoolPop(Transform gunTransform)
    {
        //�X�^�b�N�̐���0�ȉ��̎��ȉ������s����B
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
    /// �I�u�W�F�N�g�̎g�p���I��������Ɏ��s���郁�\�b�h
    /// </summary>
    public void PoolPush(PoolObject poolObject)
    {
        poolObject.gameObject.SetActive(false);
        _stack.Push(poolObject);
    }
}
