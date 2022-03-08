using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusDestroy : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "BonusBallDestroy")
        {
            Destroy(col.gameObject);
        }
    }
}
