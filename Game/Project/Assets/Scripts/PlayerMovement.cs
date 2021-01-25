using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float moveSpeed = 8f;

    // Update is called once per frame
    void Update()
    {
        if (PlayerUtil.isGameOver)
            return;

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 moveDir = new Vector2(horizontalInput, verticalInput);

        transform.Translate(moveDir * moveSpeed * Time.deltaTime);
    }
}
