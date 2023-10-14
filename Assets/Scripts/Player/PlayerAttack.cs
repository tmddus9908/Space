using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerAttack : MonoBehaviour
{
    private Vector3 _leftAttackPosition;
    private Vector3 _rightAttackPosition;
    private Vector3 _attackPosition;
    private GameObject _attack;
    private GameObject _player;

    private void Awake()
    {
        _player = GameObject.Find("Player");
    }
    void OnAttackLeft()
    {
        Vector3 position = _player.transform.position;
        _leftAttackPosition = new Vector3((float)(position.x - 0.3), (float)(position.y + 0.2), position.z);
        _attack = Instantiate(EffectManager.Instance.AttackGun, _leftAttackPosition, quaternion.identity);
        Destroy(_attack, 2);
    }
    void OnAttackRight()
    {
        Vector3 position = _player.transform.position;
        _rightAttackPosition = new Vector3((float)(position.x + 0.3), (float)(position.y + 0.2), position.z);
        _attack = Instantiate(EffectManager.Instance.AttackGun, _rightAttackPosition, quaternion.identity);
        Destroy(_attack, 2);
    }
    void OnAttackMissile()
    {
        Vector3 position = _player.transform.position;
        _attackPosition = new Vector3((float)(position.x), (float)(position.y + 0.8), position.z);
        _attack = Instantiate(EffectManager.Instance.AttackMissile, _attackPosition, quaternion.identity);
        Destroy(_attack, 2);
    }
}
