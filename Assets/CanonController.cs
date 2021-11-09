using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour
{
    public float speedCanon = 5;
    public GameObject bullet;
    public Transform canon;
    public float limitX, limitY;
    public float strenghtShoot = 1000;
    public bool doubleCanon;
    public GameObject dobleCanonObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * x * speedCanon * Time.deltaTime);
        transform.Translate(Vector3.up * y * speedCanon * Time.deltaTime);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -limitX, limitX);
        pos.y = Mathf.Clamp(pos.y, -limitY, limitY);
        transform.position = pos;

        if(Input.GetButtonDown("Jump"))
        {
            ShootCanon();
        }
        if(doubleCanon)
        {
            dobleCanonObject.SetActive(true);
        }
        else
        {
            dobleCanonObject.SetActive(false);
        }
    }

    public void ShootCanon()
    {
        if(!doubleCanon)
        {
            GameObject bulletGo = Instantiate(bullet, canon.position, Quaternion.identity);
            bulletGo.GetComponent<Rigidbody>().AddForce(canon.forward * strenghtShoot);
            Destroy(bulletGo, 5);
        }
        else
        {
            Vector3 newCanonPositon = canon.position;
            newCanonPositon.x = newCanonPositon.x + 1;
            GameObject bulletGo = Instantiate(bullet, newCanonPositon, Quaternion.identity);
            bulletGo.GetComponent<Rigidbody>().AddForce(canon.forward * strenghtShoot);
            Destroy(bulletGo, 5);


            newCanonPositon = canon.position;
            newCanonPositon.x = newCanonPositon.x - 5;
            GameObject bulletGo2 = Instantiate(bullet, newCanonPositon, Quaternion.identity);
            bulletGo2.GetComponent<Rigidbody>().AddForce(canon.forward * strenghtShoot);
            Destroy(bulletGo2, 5);
        }
        
    }
}
