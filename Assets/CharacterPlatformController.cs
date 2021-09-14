using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPlatformController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speedCharacter;
    public Animator anim;    

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(x * Time.deltaTime * speedCharacter, rb.velocity.y);
        if(rb.velocity.x < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if(rb.velocity.x > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        anim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
        //anim.SetInteger("HP", HealthManager.instance.health);
        anim.SetInteger("HP", GetComponent<Health>().health);
    }
    private void OnMouseDown()
    {
        //HealthManager.instance.health--;
        GetComponent<Health>().TakeDamage(1);
    }
}
