using UnityEngine;
using UniRx;

public class SubjectTest : MonoBehaviour
{
    private ReactiveProperty<int> _health = new(100);

    public ReactiveProperty<int> Health => _health;

    public void OnDamage()
    {
        _health.Value -= 10;
    }
}
