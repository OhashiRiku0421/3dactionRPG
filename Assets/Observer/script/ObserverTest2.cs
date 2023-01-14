using UnityEngine;
using UniRx;

public class ObserverTest2 : MonoBehaviour
{
    [SerializeField, Tooltip("�T�u�W�F�N�g")] 
    private SubjectTest _subject;

    private void Start()
    {
        //�Ď�
        _subject.Health
            .Skip(1)
            .Subscribe(x => Debug.Log($"�c��{x}"))
            .AddTo(this);//�Ď��I��
    }
}
