using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoy : MonoBehaviour
{
    public GameObject explod;
    public AudioSource FireWork; 

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "destructible")
        {
            Destroy(col.gameObject);
            FireWork.Play();
            GameObject explosition = Instantiate(explod, transform.position, transform.rotation);
            Destroy(explosition, 0.75f);
            Score.scoreValue += 1;
        }
    }

}
