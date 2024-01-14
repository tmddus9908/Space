using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingEntity : MonoBehaviour
{
    [SerializeField] private float _fallingSpeed;
    [SerializeField] public float damage;
    void Start()
    {
        Debug.Log("엔티티 스포너 필요함");
    }
    void Update()
    {
        Falling();
    }
    public void Falling()
    {
        Vector2 Y = new Vector2(transform.position.x, transform.position.y - _fallingSpeed);
        this.gameObject.transform.position = Y;
        this.gameObject.transform.Rotate(new Vector3(0, 0, 30f) * Time.deltaTime);
    }
    
    public void Destroy()
    {
        Destroy(this.gameObject);
    }
}
