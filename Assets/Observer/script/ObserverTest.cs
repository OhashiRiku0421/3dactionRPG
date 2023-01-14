using UnityEngine;
using UniRx;

public class ObserverTest : MonoBehaviour
{
    [SerializeField, Tooltip("�T�u�W�F�N�g")]
    private SubjectTest _subject;

    private void Start()
    {
        //�Ď�
        _subject.Health
            .Skip(1)
            .Subscribe(_ => Debug.Log("�ɂ��I"))
            .AddTo(this);//�Ď��I��
    }
}
