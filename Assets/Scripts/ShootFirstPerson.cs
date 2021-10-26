using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFirstPerson : MonoBehaviour
{
    public GameObject bullet;
    public Transform canon;
    public float timeToDissappear;
    public float strengthShoot = 2000;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject bulletGo = Instantiate(bullet, canon.position, canon.rotation);
        bulletGo.GetComponent<Rigidbody>().AddForce(canon.forward * strengthShoot);
        Destroy(bulletGo, timeToDissappear);
       
    }
}
