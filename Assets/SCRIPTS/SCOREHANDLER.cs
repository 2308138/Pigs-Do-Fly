using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SCOREHANDLER : MonoBehaviour
{
    public TMP_Text scoreUI;

    private SCOREMANAGER _scoreManager;

    void Start()
    {
        _scoreManager = FindObjectOfType<SCOREMANAGER>();
        scoreUI = GetComponent<TMP_Text>();
    }

    void Update()
    {
        if (_scoreManager == null || scoreUI == null)
            return;

        scoreUI.text = "Score: " +  _scoreManager.currentScore.ToString();
    }
}
