using UnityEngine;
using UniRx;

/// <summary>
/// ヒットポイントの値を持っているクラス
/// </summary>
public class TestModel : MonoBehaviour
{
    private ReactiveProperty<int> _health = new();
    private int _damage = 10;
    private int _maxHealth = 100;

    public ReactiveProperty<int> Health => _health;
    public int MaxHealth => _maxHealth;

    private void Start()
    {
        _health.Value = _maxHealth;
    }

    /// <summary>
    /// healthの値が減少する。
    /// </summary>
    public void OnDamage()
    {
        _health.Value -= _damage;
    }

    /// <summary>
    /// healthの値をリセットする。
    /// </summary>
    public void OnReset()
    {
        _health.Value = _maxHealth;
    }
}
