using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _damage = 10;
    [SerializeField] private float _recovery = 10;
    [SerializeField] private Health _health;
    public void Attack()
    {
        _health.AddValueToCarrent(-_damage);
    }

    public void Heal()
    {
        _health.AddValueToCarrent(_recovery);
    }
}
