using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;
    [SerializeField] private float _changeTime;

    private void Start()
    {
        _text1.DOText("Я заменил этот текст", _changeTime);
        _text1.DOColor(Color.white, _changeTime);
        
        _text2.DOText("\nЭто дополнение к тексту", _changeTime).SetRelative();
        _text2.DOColor(Color.yellow, _changeTime);
        
        _text3.DOText("Я взломал этот текст", _changeTime, true, ScrambleMode.All);
        _text3.DOColor(Color.red, _changeTime);
    }
}