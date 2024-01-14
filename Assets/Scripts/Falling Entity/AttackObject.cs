using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackObject : FallingEntity
{
    public float ObjectHp;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision);
        GetAttack(collision.gameObject);
    }
    private void GetAttack(GameObject obj)
    {
        ObjectHp -= obj.GetComponent<Attack>().damage;
        if (ObjectHp == 0 || ObjectHp < 0)
            Destroy();
        StartCoroutine(EffectManager.Instance.ChangeAlpha(this.gameObject));
    }
}
