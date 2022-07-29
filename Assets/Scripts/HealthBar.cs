using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] private float _reduceSpeed = 15;

    private float _currentValue;

    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(float health)
    {
        _currentValue = health;
        StartCoroutine(ChangeHealth());
    }

    private IEnumerator ChangeHealth()
    {
        while (slider.value != _currentValue)
        {
            slider.value = Mathf.MoveTowards(slider.value, _currentValue, _reduceSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
