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
        _attack = Instantiate(EffectManager.instance.AttackGun, _leftAttackPosition, quaternion.identity);
    }
    void OnAttackRight()
    {
        Vector3 position = _player.transform.position;
        _rightAttackPosition = new Vector3((float)(position.x + 0.3), (float)(position.y + 0.2), position.z);
        Instantiate(EffectManager.instance.AttackGun, _rightAttackPosition, quaternion.identity);
    }
}
