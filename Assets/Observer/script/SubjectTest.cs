using UnityEngine;
using UniRx;

/// <summary>
/// 
/// </summary>
public class SubjectTest : MonoBehaviour
{
    private ReactiveProperty<int> _health = new(100);

    public IReactiveProperty<int> Health => _health;

    public void OnDamage()
    {
        _health.Value -= 10;
    }
}
