using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObject : MonoBehaviour
{

    /// <summary>
    /// Pop���������ۂɎ��s����B
    /// </summary>
    public void PopInterval(ObjectPoolTest objectPool)
    {
        StartCoroutine(Interval(objectPool));
    }

    IEnumerator Interval(ObjectPoolTest objectPool)
    {
        yield return new WaitForSeconds(2);
        objectPool.PoolPush(this);
    }
}
