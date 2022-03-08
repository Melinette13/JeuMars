using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFloorColor : MonoBehaviour
{

    public float timer = 0.0f;

    
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2.0f)
        {
            
            Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            
            GetComponent<Renderer>().material.color = newColor;
            timer = 0;
        }

    }
}
