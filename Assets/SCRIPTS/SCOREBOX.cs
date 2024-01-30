using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCOREBOX : MonoBehaviour
{
    public int scoreAmount = 50;

    private SCOREMANAGER _scoreManager;

    void Start()
    {
        _scoreManager = FindObjectOfType<SCOREMANAGER>();    
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (_scoreManager == null)
            return;

        _scoreManager.AddScore(scoreAmount);
        Debug.Log("+50");
    }
}
