using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private ChangedHealthEvent _changedMaxHealthEvent;
    [SerializeField] private ChangedHealthEvent _changedHealthEvent;

    private const float _minHealth = 0;
    private float _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
        _changedMaxHealthEvent?.Invoke(_currentHealth);
    }

    public void Attack(float damage)
    {
        _currentHealth = Mathf.Clamp(_currentHealth - damage, _minHealth, _maxHealth);
        _changedHealthEvent?.Invoke(_currentHealth);
    }

    public void Heal(float recovery)
    {
        _currentHealth = Mathf.Clamp(_currentHealth + recovery, _minHealth, _maxHealth);
        _changedHealthEvent?.Invoke(_currentHealth);
    }
}
