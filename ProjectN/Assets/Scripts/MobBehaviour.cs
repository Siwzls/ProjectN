using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector3 pos;

    [SerializeField]
    protected float speed;
    [SerializeField]
    private float hp;
    private float wallCheckBox = 0.3f;


    protected static bool isMovingUp;
    protected static bool isMovingLeft;
    protected static bool isMovingRigth;
    protected static bool isMovingDown;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }
    private void Update()
    {
        pos = GetComponent<Transform>().position;
        ObstacleCheck();
    }
    protected virtual void ObstacleCheck()
    {
        Collider2D[] colliderUp = Physics2D.OverlapBoxAll(new Vector3(pos.x, pos.y + wallCheckBox, pos.z), new Vector2(0.1f, wallCheckBox), 0);
        Collider2D[] colliderLeft = Physics2D.OverlapBoxAll(new Vector3(pos.x - wallCheckBox, pos.y , pos.z), new Vector2(wallCheckBox, 0.1f), 0);
        Collider2D[] colliderRigth = Physics2D.OverlapBoxAll(new Vector3(pos.x + wallCheckBox, pos.y, pos.z), new Vector2(wallCheckBox, 0.1f), 0);
        Collider2D[] colliderDown = Physics2D.OverlapBoxAll(new Vector3(pos.x, pos.y - wallCheckBox, pos.z), new Vector2(0.1f, wallCheckBox), 0);

        isMovingUp = colliderUp.Length < 2;
        isMovingLeft = colliderLeft.Length < 2;
        isMovingRigth = colliderRigth.Length < 2;
        isMovingDown = colliderDown.Length < 2;
    }
    protected virtual void GetDagame(float dmg)
    {
        hp -= dmg;
        if (hp <= 0)
            Destroy(gameObject);
    }
}
