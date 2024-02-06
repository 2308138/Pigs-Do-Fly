using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCROLLER : MonoBehaviour
{
    public float speed = 0.3F;

    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (_spriteRenderer == null)
            return;

        Vector2 offset = new Vector2(Time.time * speed, 0);

        _spriteRenderer.material.mainTextureOffset = offset;
    }
}
