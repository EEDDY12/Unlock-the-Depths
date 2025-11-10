using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour
{
    public Slider healthSlider;

    private void OnEnable()
    {
        PlayerHealth.OnHealthChanged += UpdateBar;
    }

    private void OnDisable()
    {
        PlayerHealth.OnHealthChanged -= UpdateBar;
    }

    void UpdateBar(int current, int max)
    {
        healthSlider.maxValue = max;
        healthSlider.value = current;
    }
}

