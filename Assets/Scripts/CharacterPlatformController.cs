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
    public int jumps = 1;
    private int extraJumpActual;
    [Header("FX")]
    public ParticleSystem dust;

    [Header("Dash")]
    public bool dashing;
    public float timeDashing = 0.5f;
    public float forceDashing = 500;
    public bool right = true;

    [Header("melee attack")]
    public bool attacking;
    public float timeAttacking;
    public GameObject attackZone;
    private void Start()
    {
        extraJumpActual = jumps;
        attackZone.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        if(Input.GetKeyDown(KeyCode.E) && !dashing)
        {
            Dash();
        }

        if(!dashing)
        {
            rb.velocity = new Vector2(x * Time.deltaTime * speedCharacter, rb.velocity.y);
            //salto
            if (rb.velocity.y < 0)
            {
                rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
            }
            else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
            {
                rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
            }

            if (Input.GetButtonDown("Jump") && extraJumpActual > 0)
            {
                Jump();
            }

        }

        if(isGrounded)
        {
            extraJumpActual = jumps;
        }
       
        if(rb.velocity.x < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
           
            right = false;
        }
        else if(rb.velocity.x > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            right = true;
        }
        anim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
        //anim.SetInteger("HP", HealthManager.instance.health);
        anim.SetInteger("HP", GetComponent<Health>().health);
        
        if(Mathf.Abs(rb.velocity.x) > 0 && isGrounded)
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
        if(Input.GetKeyDown(KeyCode.R) && !attacking)
        {
            MeleeAttack();
        }
    }
    public void Jump()
    {
        //rb.AddForce(Vector2.up * strengthJump);
        extraJumpActual--;
        rb.velocity = Vector2.zero;
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
    public void Dash()
    {        
        dashing = true;
        rb.velocity = Vector2.zero;
        rb.gravityScale = 0;
        if(right)
        {
            rb.AddForce(Vector2.right * forceDashing);
        }
        else
        {
            rb.AddForce(-Vector2.right * forceDashing);
        }
        StartCoroutine(Dashing());

    }
    IEnumerator Dashing()
    {
        yield return new WaitForSeconds(timeDashing);
        dashing = false;
        rb.gravityScale = 1;
        yield break;
    }
    public void MeleeAttack()
    {
        attacking = true;
        attackZone.SetActive(true);

       
        StartCoroutine(MeleeAttacking());

    }
    IEnumerator MeleeAttacking()
    {
        yield return new WaitForSeconds(timeAttacking);
        attacking = false;
        attackZone.SetActive(false);
        yield break;
    }
}
