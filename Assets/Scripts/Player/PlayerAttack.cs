using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Transform _leftAttackPosition;
    [SerializeField] private Transform _attackPosition;
    [SerializeField] private Transform _rightAttackPosition;
    
    private GameObject _attack;

    void OnAttackLeft()
    {
        _attack = Instantiate(EffectManager.Instance.AttackGun, _leftAttackPosition.position, quaternion.identity);
        Destroy(_attack, 2);
    }
    void OnAttackRight()
    {
        _attack = Instantiate(EffectManager.Instance.AttackGun, _rightAttackPosition.position, quaternion.identity);
        Destroy(_attack, 2);
    }
    void OnAttackMissile()
    {
        _attack = Instantiate(EffectManager.Instance.AttackMissile, _attackPosition.position, quaternion.identity);
        Destroy(_attack, 2);
    }
}
