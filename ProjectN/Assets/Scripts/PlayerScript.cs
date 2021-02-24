using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MobBehaviour
{
    private PlayerScript mobBehaviour;

    public static bool debug;
    private void Start()
    {
        mobBehaviour = GetComponent<PlayerScript>();
    }
    void Update()
    {
        Movement();
    }
    private void Movement()
    {
        if(Input.GetKey(KeyCode.W) && isMovingUp)
        {
            transform.position = new Vector3(transform.position.x, 
                                             transform.position.y + speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A) && isMovingLeft)
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime,
                                             transform.position.y, 0);
        }
        if(Input.GetKey(KeyCode.D) && isMovingRigth)
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime,
                                             transform.position.y, 0);
        }
        if(Input.GetKey(KeyCode.S) && isMovingDown)
        {
            transform.position = new Vector3(transform.position.x,
                                             transform.position.y - speed * Time.deltaTime, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            debug = !debug;
            Debug.Log("Debug is: " + debug);
        }
            
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Collision!");
        if (collider.gameObject.tag == "Trap")
        {
            Destroy(gameObject);
            print(collider.gameObject.tag);
        }
            
    }
}
