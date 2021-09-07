using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuasoMovimiento : MonoBehaviour
{
    public Animator anim;
    public float speedCharacter;
    public Rigidbody rb;    

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rb.MovePosition(transform.position + new Vector3(x, y, 0).normalized * speedCharacter * Time.deltaTime);
        anim.SetFloat("Speed", Mathf.Abs(rb.velocity.magnitude));

        if(Input.GetKeyDown(KeyCode.I))
        {
            anim.SetInteger("Estado", 1);
        }
        if(Input.GetKeyDown(KeyCode.O))
        {
            anim.SetInteger("Estado", 2);
        }

    }
}
