using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float PlayerHp;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject obj = collision.gameObject;
        if (obj.GetComponent<AttackObject>())
        {
            StartCoroutine(EffectManager.Instance.ChangeAlpha(this.gameObject));
            PlayerHp -= obj.GetComponent<AttackObject>().damage;
        }
    }

}
