using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectButton : MonoBehaviour
{
    [SerializeField] private float _power = 10;
    [SerializeField] private Player _player;
    [SerializeField] private TypeEffectPower _powerType;

    public void Apply()
    {
        switch (_powerType)
        {
            case TypeEffectPower.Damage: _player.Attack(_power); break;
            case TypeEffectPower.Heal: _player.Heal(_power); break;
        }
    }
}

enum TypeEffectPower
{
    Damage,
    Heal
}
