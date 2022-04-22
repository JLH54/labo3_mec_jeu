using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterHealth : MonoBehaviour
{
    public Slider mainSlider;

    public void Start()
    {
        mainSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    void ValueChangeCheck()
    {
        Debug.Log(mainSlider.value);
    }
}
