using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerControl : MonoBehaviour
{
    private float mapBorders = 2;
    private bool moveLeft;
    private bool moveRight;
    
    void Start()
    {


    }


    void Update()
    {
        moveLeft = Input.GetKeyDown(KeyCode.A);
        moveRight = Input.GetKeyDown(KeyCode.D);

        if (moveLeft && transform.position.x > -mapBorders)
        {
            transform.position += Vector3.left;
        }
        else if (moveRight && transform.position.x < mapBorders)
        {
            transform.position += Vector3.right;
        }
    }
}
