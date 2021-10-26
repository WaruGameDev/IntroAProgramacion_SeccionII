using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Bullet"))
        {
            other.transform.eulerAngles = new Vector3(other.transform.eulerAngles.x,
                other.transform.eulerAngles.y, other.transform.eulerAngles.z + 180);
        }
    }
}
