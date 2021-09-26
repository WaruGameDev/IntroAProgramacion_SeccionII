using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPlatformController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speedCharacter;
    public Animator anim;
    [Header("Jump Mechanics")]
    [Range(1,10)]
    public float strengthJump = 10;
    public bool isGrounded = true;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2;
    [Header("FX")]
    public ParticleSystem dust;


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
        if(rb.velocity.y <0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if(rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }
        if(Mathf.Abs(rb.velocity.x) > 0)
        {
            if (!dust.isPlaying)
            {
                dust.Play();
            }
        }
        else
        {
            if (dust.isPlaying)
            {
                dust.Stop();
            }
        }
    }
    public void Jump()
    {
        //rb.AddForce(Vector2.up * strengthJump);
        rb.velocity = Vector2.up * strengthJump;
    }
    private void OnMouseDown()
    {
        //HealthManager.instance.health--;
        GetComponent<Health>().TakeDamage(1);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Floor"))
        {
            isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Floor"))
        {
            isGrounded = false;
        }
    }
}
