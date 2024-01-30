using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER : MonoBehaviour
{
    public float upwardsForce = 500F;

    private Rigidbody2D _rigidBody2D;
    private Collider2D _collider2D;

    void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
        _collider2D = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (_rigidBody2D == null)
            return;
            
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidBody2D.velocity = Vector2.zero;
            _rigidBody2D.AddForce(Vector2.up * upwardsForce);
        }
    }
}
