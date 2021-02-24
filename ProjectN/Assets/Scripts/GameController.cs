using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MobBehaviour
{
    private Vector3 playerPos;
    void Update()
    {
        playerPos = GameObject.FindWithTag("Player").transform.position;
    }
}
