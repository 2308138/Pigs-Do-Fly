using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVER : MonoBehaviour
{
    public float moveSpeed = 7F;

    void FixedUpdate()
    {
        if (transform.position.x <= -14)
            Destroy(gameObject);
        
        Vector2 targetMovePosition = transform.position;
        targetMovePosition.x -= moveSpeed * Time.deltaTime;
        transform.position = targetMovePosition;
    }
}
