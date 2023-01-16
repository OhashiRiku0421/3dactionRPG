using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaunController : MonoBehaviour
{
    [SerializeField]
    ObjectPoolTest _objectPool;
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            _objectPool.PoolPop(transform).PopInterval(_objectPool);
        }
    }
}
