using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hpbar : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private TMP_Text textDP;
    private Slider slider;
    private int maxValue;

    public void Awake()
    {
        slider = GetComponent<Slider>();
    }

    public void Setup(int maxValue)
    {
        this.maxValue = maxValue;

        slider.maxValue = maxValue;
        slider.value = maxValue;

        SetValue(maxValue);
    }

    public void SetValue(int value)
    {
        slider.value = value;
        textDP.text = value + "/" + maxValue;
    }





}
