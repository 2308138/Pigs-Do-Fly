using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCOREBOX : MonoBehaviour
{
    public int scoreAmount = 1;

    private SCOREMANAGER _scoreManager;

    void Start()
    {
        _scoreManager = FindObjectOfType<SCOREMANAGER>();    
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (_scoreManager == null)
            return;

        if (!collision.gameObject.CompareTag("Player"))
            return;

        _scoreManager.AddScore(scoreAmount);
        Debug.Log("+1 points.");
    }
}
