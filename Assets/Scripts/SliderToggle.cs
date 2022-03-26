using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderToggle : MonoBehaviour
{
    public void SetEnable(Toggle change)
    {
        GetComponent<Slider>().value = change.isOn?1:0;
        
    }
}
