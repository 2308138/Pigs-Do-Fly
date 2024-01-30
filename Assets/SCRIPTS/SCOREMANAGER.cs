using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCOREMANAGER : MonoBehaviour
{
    public int currentScore = 0;

    public void AddScore(int score)
    {
        currentScore += score;
        Debug.Log("Current Score: " + currentScore);
    }
}
