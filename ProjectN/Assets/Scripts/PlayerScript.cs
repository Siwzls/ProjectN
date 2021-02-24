using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MobBehaviour
{

    private bool isMoving = true;

    void Start()
    {

    }
    void Update()
    {
        Movement();
    }
    private void Movement()
    {
        if(isMoving)
        {
            if(Input.GetKey(KeyCode.W))
            {
                transform.position = new Vector3(transform.position.x, 
                                                 transform.position.y + speed * Time.deltaTime, 0);
            }
            if(Input.GetKey(KeyCode.A))
            {
                transform.position = new Vector3(transform.position.x - speed * Time.deltaTime,
                                                 transform.position.y, 0);
            }
            if(Input.GetKey(KeyCode.D))
            {
                transform.position = new Vector3(transform.position.x + speed * Time.deltaTime,
                                                 transform.position.y, 0);
            }
            if(Input.GetKey(KeyCode.S))
            {
                transform.position = new Vector3(transform.position.x,
                                                 transform.position.y - speed * Time.deltaTime, 0);
            }
        }
    }
}
