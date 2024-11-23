using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleTime;
    [SerializeField] private Vector3 _targetScale;

    private Transform _transform;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    private void OnEnable()
    {
        Scale();
    }

    private void Scale()
    {
        _transform.DOScale(_targetScale, _scaleTime)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
