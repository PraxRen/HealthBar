using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private float _damage = 10;
    [SerializeField] private float _recovery = 10;
    [SerializeField] private ChangedHealthEvent _changedMaxHealthEvent;
    [SerializeField] private ChangedHealthEvent _changedHealthEvent;

    private const float _minHealth = 0;
    private float _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
        _changedMaxHealthEvent?.Invoke(_currentHealth);
    }

    public void Attack()
    {
        _currentHealth -= _damage;

        if(_currentHealth < _minHealth)
            _currentHealth = _minHealth;

        _changedHealthEvent?.Invoke(_currentHealth);
    }

    public void Heal()
    {
        _currentHealth += _recovery;

        if (_currentHealth > _maxHealth)
            _currentHealth = _maxHealth;

        _changedHealthEvent?.Invoke(_currentHealth);
    }
}
