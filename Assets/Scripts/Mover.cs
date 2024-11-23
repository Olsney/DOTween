using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;

public class Mover : MonoBehaviour
{
    [SerializeField] private Transform _targetPoint;
    [SerializeField] private float _moveTime;

    private Transform _transform;
    
    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    private void OnEnable()
    {
        Move();
    }

    private void Move()
    {
        _transform.DOMove(_targetPoint.position, _moveTime)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
