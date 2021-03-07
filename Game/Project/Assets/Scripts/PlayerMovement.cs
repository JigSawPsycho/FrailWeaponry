using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;

    float moveSpeed = 8f;

    // Update is called once per frame
    void Update()
    {
        

        //transform.Translate(moveDir * moveSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        if (PlayerUtil.isGameOver)
            return;

        rb.MovePosition(transform.localPosition + FlyVector());
    }

    Vector3 FlyVector()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        Vector3 moveDir = (transform.right * horizontalAxis) + (transform.up * verticalAxis);

        return moveDir * Time.deltaTime * moveSpeed;
    }
}
