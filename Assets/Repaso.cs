using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repaso : MonoBehaviour
{
    public int numerosEnteros;
    public float numerosDecimales;
    public string textos;
    public bool tocado;

    public Rigidbody rb;
    public Repaso repaso;
    private Renderer ren;
    // + - * / %
    // + "hola" + "mundo" == "holamundo"


    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<Renderer>();
        //rb.isKinematic = false;
       // StartCoroutine(Contador());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }
    IEnumerator Contador()
    {
        yield return new WaitForSeconds(5);
        rb.isKinematic = false;
        yield break;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet") && !tocado)
        {
            tocado = true;
            other.GetComponent<Renderer>().material.color = Color.blue;
            CuboManager.instance.cubosTocados++;
            ren.material.color = Color.red;
            StartCoroutine(Contador());
        }
    }
}
