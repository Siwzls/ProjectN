using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    protected float speed;
    [SerializeField]
    private float hp;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }
    protected virtual void GetDagame(float dmg)
    {
        hp -= dmg;
        if (hp <= 0)
            Destroy(gameObject);
    }
}
