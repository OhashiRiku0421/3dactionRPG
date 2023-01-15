using UnityEngine;
using UniRx;

/// <summary>
/// サブジェクトを監視するオブザーバークラス
/// </summary>
public class ObserverTest : MonoBehaviour
{
    [SerializeField, Tooltip("サブジェクト")]
    private SubjectTest _subject;

    private void Start()
    {
        //監視
        _subject.Health
            .Skip(1)
            .Subscribe(_ => Debug.Log("痛い！"))
            .AddTo(this);//監視終了
    }
}
