using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respaw : MonoBehaviour
{
    public GameObject player;
    public Transform spawn;
    

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "BallRespawn")
        {
            player.transform.position = spawn.position;
        }
           
    }



}
