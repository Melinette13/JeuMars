using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBall : MonoBehaviour
{
    public GameObject BonusBall ;
    public Transform spawnPos;
    public float SpawnTime;
    public float Spawndelay;
    public bool stopSpawning = false;

    int randomInt;

    void Start()
    {
        InvokeRepeating("SpawnBall", SpawnTime, Spawndelay);
    }


    void SpawnBall()
    {
        randomInt = Random.Range(0, 0);
        Instantiate(BonusBall, spawnPos.position, spawnPos.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnCube");
        }
    }
}
