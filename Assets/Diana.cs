using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Diana : MonoBehaviour
{
    public GameObject explosion;
    public bool isMovible;
    public enum DIRECTION
    {
        HORIZONTAL, VERTICAL    
    }
    public DIRECTION direction;
    private void Start()
    {
        if(isMovible)
        {
            if(direction == DIRECTION.HORIZONTAL)
            {
                transform.DOMoveX(-4, 2).SetRelative(true).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
            }
            else
            {
                transform.DOMoveY(-4, 2).SetRelative(true).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
            }
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }
}
