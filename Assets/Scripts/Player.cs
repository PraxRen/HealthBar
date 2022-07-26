using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private float _damage = 10;
    [SerializeField] private float _recovery = 10;
    [SerializeField] private float _currentHealth;
    [SerializeField] private HealthBar _healthBar;

    private const float MinHealth = 0;

    private void Start()
    {
        _currentHealth = _maxHealth;
        _healthBar.SetMaxHealth(_maxHealth);
    }

    public void Attack()
    {
        _currentHealth -= _damage;

        if(_currentHealth < MinHealth)
            _currentHealth = MinHealth;

        _healthBar.SetHealth(_currentHealth);
    }

    public void Heal()
    {
        _currentHealth += _recovery;

        if (_currentHealth > _maxHealth)
            _currentHealth = _maxHealth;

        _healthBar.SetHealth(_currentHealth);
    }
}
