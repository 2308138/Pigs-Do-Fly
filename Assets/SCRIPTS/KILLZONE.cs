using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KILLZONE : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Destroy(collision.gameObject);
    }
}
