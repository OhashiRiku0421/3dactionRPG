using UnityEngine;
using UniRx;

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
