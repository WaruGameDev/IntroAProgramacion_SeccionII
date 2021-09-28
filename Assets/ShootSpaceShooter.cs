using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSpaceShooter : MonoBehaviour
{
    public List<Transform> canones;
    public float timeToDissapear = 2;
    public GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        foreach(Transform canon in canones)
        {
            GameObject bulletGo = Instantiate(bullet, canon.position, Quaternion.identity);
            Destroy(bulletGo, timeToDissapear);
        }
    }
}
