using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerControl : MonoBehaviour
{
    private bool moveLeft;
    private bool moveRight;
    private bool rotationPlayer;

    private bool isMoving;
    private Vector3 originalPos, targetPos;
    private float timeToMove = 0.2f;
    private void MovePlayer()
    {
        moveLeft = Input.GetKeyDown(KeyCode.A);
        moveRight = Input.GetKeyDown(KeyCode.D);


        if (moveLeft && !isMoving)
        {
            StartCoroutine(MovePlayerCoroutine(Vector3.left));
        }
        else if (moveRight && !isMoving)
        {
            StartCoroutine(MovePlayerCoroutine(Vector3.right));
        }
    }
    private void RotatePlayer()
    {
        rotationPlayer = Input.GetKeyDown(KeyCode.Space);

        if (rotationPlayer)
        {
            transform.Rotate(Vector3.back, 90f);
        }
    }
   
    void Update()
    {
        MovePlayer();
        RotatePlayer();
    }

    private IEnumerator MovePlayerCoroutine(Vector3 direction)
    {
        isMoving = true;

        float elapsedTime = 0;

        originalPos = transform.position;
        targetPos = originalPos + direction;

        while (elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(originalPos, targetPos, (elapsedTime / timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPos;

        isMoving = false;
    }
}
