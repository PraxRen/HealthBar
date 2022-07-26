using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxValue = 100;
    [SerializeField] private float _minValue = 0;
    [SerializeField] private HealthBar _healthBar;

    public float CurrentValue { get; private set; }
    
    private void Start()
    {
        CurrentValue = _maxValue;
        _healthBar.SetMaxHealth(_maxValue);
    }

    public void AddValueToCarrent(float value)
    {
        CurrentValue += value;
        
        if (CurrentValue < _minValue)
            CurrentValue = _minValue;
        else if (CurrentValue > _maxValue)
            CurrentValue = _maxValue;

        _healthBar.SetHealth(CurrentValue);
    }
}