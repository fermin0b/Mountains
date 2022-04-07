using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckpoint : MonoBehaviour
{
    public GameObject flag;
    Vector3 spawnPoint;

    void Start()
    {
        spawnPoint = gameObject.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -10f)
        {
            gameObject.transform.position = spawnPoint;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("checkpoint"))
        {
            spawnPoint = flag.transform.position;

        }
    }
}