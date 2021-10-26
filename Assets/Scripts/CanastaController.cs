using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanastaController : MonoBehaviour
{
    public float speedCanasto = 5;
    private void Update()
    {
        float x = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * speedCanasto * x * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Fruit"))
        {
            GameFruitManager.instance.AddPuntaje(other.GetComponent<Fruit>().puntajeADar);
            Destroy(other.gameObject);
        }
    }
}
