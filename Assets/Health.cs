using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Health : MonoBehaviour
{
    public float health = 10;
   
    public void TakeDamage(float damage)
    {
        health -= damage;
        StartCoroutine(Hurting());

        if(health <= 0)
        {
            Destroy(gameObject);
        }    
    }
    IEnumerator Hurting()
    {
        foreach (Transform g in transform)
        {
            g.GetComponent<Renderer>().material.DOColor(Color.red, .2f);
        }       
        yield return new WaitForSeconds(.2f);
        foreach (Transform g in transform)
        {
            g.GetComponent<Renderer>().material.DOColor(Color.white, .2f);
        }        
        yield break;
    }
}
