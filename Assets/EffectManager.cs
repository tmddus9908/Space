using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    public static EffectManager instance = null;

    public GameObject AttackGun;

    private void Start()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }
}
