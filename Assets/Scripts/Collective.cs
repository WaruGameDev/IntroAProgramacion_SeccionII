using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collective : MonoBehaviour
{
    public GameObject particles;
    public AudioSource sfx;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(particles, transform.position, Quaternion.identity);
            GameManager.instance.puntaje++;
            sfx.Play();
            Destroy(gameObject);
            //print("Gato entro a la colision");
        }
    }
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        print("Gato salió de la colision");
    //    }
    //}
    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        print("Gato esta en la colision");
    //    }
    //}

}
