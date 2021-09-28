using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpaceShooter : MonoBehaviour
{
    public float speedBullet = 200;
    public Vector2 direction = new Vector2(0, 1);    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speedBullet * Time.deltaTime);
    }
}
