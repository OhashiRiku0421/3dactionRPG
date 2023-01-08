using UnityEngine;
using UniRx;

/// <summary>
/// �q�b�g�|�C���g�̒l�������Ă���N���X
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
    /// health�̒l����������B
    /// </summary>
    public void OnDamage()
    {
        _health.Value -= _damage;
    }

    /// <summary>
    /// health�̒l�����Z�b�g����B
    /// </summary>
    public void OnReset()
    {
        _health.Value = _maxHealth;
    }
}
