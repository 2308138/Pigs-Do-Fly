using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROTATOR : MonoBehaviour
{
    public float velocity = 0F;
    public float rotateUp = 20F;
    public float rotateDown = -10F;
    
    private  PLAYER _player;
    private float _currentY;
    private float _lastY;

    void Start()
    {
        _player = transform.parent.GetComponent<PLAYER>();
        _currentY = _lastY = transform.parent.position.y;
    }

    void FixedUpdate()
    {
        if (_player == null)
            return;

        _currentY = _player .transform.position.y;

        velocity = _currentY - _lastY;
        velocity *= 10F;
        velocity = Mathf.Clamp(velocity, -1, 1);
        velocity = Unity.Mathematics.math.remap(-1, 1, 0, 1, velocity);

        transform.rotation = Quaternion.Lerp(Quaternion.Euler(0, 0, rotateDown), Quaternion.Euler(0, 0, rotateUp), velocity);

        _lastY = _player .transform.position.y;
    }
}
