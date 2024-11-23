using DG.Tweening;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Material))]
public class ColorChanger : MonoBehaviour
{
    private readonly Color _targetColor = Color.cyan;
    
    [SerializeField] private float _changingTime;

    private Material _material;

    private void Start()
    {
        _material = GetComponent<Renderer>().material;

        Change();
    }

    private void Change()
    {
        _material.DOColor(_targetColor, _changingTime)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);
    }
}