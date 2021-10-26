using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitByBullet : MonoBehaviour
{
    public string tagBullet = "BulletPlayer";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(tagBullet))
        {
            GetComponent<Health>().TakeDamage(collision.GetComponent<BulletSpaceShooter>().damage);
            Destroy(collision.gameObject);
        }
    }
}
