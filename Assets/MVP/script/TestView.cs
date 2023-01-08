using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

/// <summary>
/// model�ɂ���q�b�g�|�C���g�̒l���ύX���ꂽ�Ƃ�presenter���o�R����UI�ɔ��f����B
/// </summary>
public class TestView : MonoBehaviour
{
    [SerializeField, Tooltip("�q�b�g�|�C���g�̃X���C�_�[")]
    private Slider _slider;

    /// <summary>
    /// �X���C�_�[�̍ő�l��ݒ�
    /// </summary>
    public void Init(int maxHealth)
    {
        _slider.maxValue = maxHealth;
    }

    /// <summary>
    /// �q�b�g�|�C���g�̒l���X���C�_�[�ɔ��f
    /// </summary>
    public void HealthSlider(float value)
    {
        DOTween.To(() => _slider.value,
                x => _slider.value = x,
                value,
                1f);
    }

}
