using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour
{
    void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.name == "Target")
        {
            Destroy(col.gameObject);
        }
    }
}