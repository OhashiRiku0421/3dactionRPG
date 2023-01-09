using UnityEngine;
using UniRx;

/// <summary>
/// modelのヒットポイントが変更されたときviewに通知する。
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
    /// ヒットポイントの監視をし、変更されたら通知する。
    /// </summary>
    private void Presenter()
    {
        _testModel.Health
            .Skip(1)
            .Subscribe(x => {
                _testView.HealthSlider(x);
                Debug.Log($"残り{x}");
            })
            .AddTo(this);//監視を終了
    }
}
