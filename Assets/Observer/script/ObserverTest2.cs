using UnityEngine;
using UniRx;

public class ObserverTest2 : MonoBehaviour
{
    [SerializeField, Tooltip("サブジェクト")] 
    private SubjectTest _subject;

    private void Start()
    {
        //監視
        _subject.Health
            .Skip(1)
            .Subscribe(x => Debug.Log($"残り{x}"))
            .AddTo(this);//監視終了
    }
}
