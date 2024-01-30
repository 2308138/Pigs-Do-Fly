using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPAWNMANAGER : MonoBehaviour
{
    public GameObject[] obstacles;
    public float spawnInterval = 1F;

    private float _timer;

    private void Start()
    {
        _timer = spawnInterval;
    }

    private void Update()
    {
        if (_timer > 0)
        {
            _timer -= Time.deltaTime;
            return;
        }

        _timer = spawnInterval;

        int randomizer = Random.Range(0, obstacles.Length);
        GameObject.Instantiate(obstacles[randomizer], transform.position, transform.rotation);
    }
}
