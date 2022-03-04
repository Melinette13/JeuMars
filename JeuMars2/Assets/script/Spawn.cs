using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject cube;
    public Vector3 center;
    public Vector3 size;

    void Start()
    {
        SpawnCube();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Z))

            SpawnCube();

    }
    void SpawnCube()
    {
        Vector3 position = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), 1, Random.Range(-size.z / 2, size.z / 2));
        Instantiate(cube, position, Quaternion.identity);
    }
}
