using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    public static EffectManager Instance = null;


    public GameObject AttackGun;
    public GameObject AttackMissile;
    private void Start()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this.gameObject);
    }
    public IEnumerator ChangeAlpha(GameObject obj)
    {
        Color origin = obj.GetComponent<SpriteRenderer>().color;
        obj.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.7f);
        yield return new WaitForSeconds(0.5f);

        ReturnAlpha(obj, origin);
    }
    public void ReturnAlpha(GameObject obj, Color origin)
    {
        obj.GetComponent<SpriteRenderer>().color = origin;
    }
}
