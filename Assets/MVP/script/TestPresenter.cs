using UnityEngine;
using UniRx;

/// <summary>
/// model�̃q�b�g�|�C���g���ύX���ꂽ�Ƃ�view�ɒʒm����B
/// </summary>
public class TestPresenter : MonoBehaviour
{
    [SerializeField]
    private TestModel _testModel;
    [SerializeField]
    private TestView _testView;

    private void Start()
    {
        _testView.Init(_testModel.MaxHealth);
        Presenter();
    }

    /// <summary>
    /// �q�b�g�|�C���g�̊Ď������A�ύX���ꂽ��ʒm����B
    /// </summary>
    private void Presenter()
    {
        _testModel.Health
            .Skip(1)
            .Subscribe(x => {
                _testView.HealthSlider(x);
                Debug.Log($"�c��{x}");
            })
            .AddTo(this);//�Ď����I��
    }
}
